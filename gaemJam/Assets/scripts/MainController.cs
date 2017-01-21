using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainController : MonoBehaviour {


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void InstantiateGameObject(UnityEngine.Object to_clone, string sourceName)
    {

        Vector3 location = GameObject.Find(sourceName).transform.position;

        Instantiate(to_clone, location, Quaternion.identity);
        GameObject.Find("GameModel/Text").GetComponent<GameController>().CountUp();

    }

    public void TerminateGameObject(UnityEngine.Object to_terminate)
    {
        Destroy(to_terminate);
        print("i did it!\n");
    }
}
