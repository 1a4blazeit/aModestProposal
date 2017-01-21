using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainController : MonoBehaviour {

	public float powerupFrequency = 0.2f;

	public GameObject powerup;
	public GameObject bullet;

    public void InstantiateProjectile(string gunner)
    {
		Vector3 gunLocation = GameObject.Find(gunner).transform.position;

		GameObject projectileType = determineProjectileType ();
		Instantiate(projectileType, gunLocation, Quaternion.identity);

        //GameObject.Find("GameModel/Text").GetComponent<GameController>().CountUp();
    }

    public void TerminateGameObject(UnityEngine.Object to_terminate)
    {
        Destroy(to_terminate);
    }
		
	private GameObject determineProjectileType(){
		float number = UnityEngine.Random.value;
		if (number <= powerupFrequency) {
			Debug.Log ("A powerup is generated! " + number);
			return powerup;
		} else {
			Debug.Log ("A bullet is generated! " + number);
			return bullet;
		}
	}

    public void VictimKilledEnd()
    {
        //TODO trigger the ending for when the Victim is killed
        Debug.Log("VICTIM DIED");
    }

}
