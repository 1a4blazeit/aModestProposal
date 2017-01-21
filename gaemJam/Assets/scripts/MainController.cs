using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainController : MonoBehaviour {

	public float powerupFrequency = 0.2f;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void InstantiateGameObject(UnityEngine.Object to_clone, string sourceName)
    {
		//Determine whether the projectile is a bullet or a powerup
		//TODO: Determine if the to_clone object is tagged with "bullet" before calling "determineProjectileType()"
		determineProjectileType();

        Vector3 location = GameObject.Find(sourceName).transform.position;

        Instantiate(to_clone, location, Quaternion.identity);
        GameObject.Find("GameModel/Text").GetComponent<GameController>().CountUp();

    }

    public void TerminateGameObject(UnityEngine.Object to_terminate)
    {
        Destroy(to_terminate);
        print("i did it!\n");
    }
		
	private void determineProjectileType(){
		float number = UnityEngine.Random.value;
		if (number <= powerupFrequency) {
			Debug.Log ("A powerup is generated! " + number);
		} else {
			Debug.Log ("A bullet is generated! " + number);
		}
	}
}
