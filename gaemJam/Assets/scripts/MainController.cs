using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainController : MonoBehaviour {

	public float powerupFrequency = 0.2f;

	public GameObject bullet;
	public GameObject speedboost;
	public GameObject shield;

    public void InstantiateProjectile(GameObject gunner)
    {
		Vector3 gunLocation = gunner.transform.position;

		GameObject projectileType = determineProjectileType ();
		Instantiate (projectileType, gunLocation, Quaternion.identity);

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
			//Determine what kind of powerup
			return determinePowerupType();
		} else {
			Debug.Log ("A bullet is generated! " + number);
			return bullet;
		}
	}
		
	public GameObject determinePowerupType(){
		float number = UnityEngine.Random.value;
		//For now we only have 2 powerups
		if (number <= 0.5) {
			return speedboost;
		} else {
			return shield;
		}
	}

    public void VictimKilledEnd()
    {
        //TODO trigger the ending for when the Victim is killed
        Debug.Log("VICTIM DIED");
    }

    public bool VictimSpeedBoost()
    {
        //TODO add condition in which the powerup is already active so it returns false
        return true;
    }
}
