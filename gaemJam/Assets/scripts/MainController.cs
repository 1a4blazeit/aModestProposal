using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainController : MonoBehaviour {

	public float powerupFrequency = 0.2f;

	public GameObject projectile;
	public GameObject powerup;
	public GameObject bullet;
	public GameObject speedboost;
	public GameObject shield;

    public void InstantiateProjectile(string gunner)
    {
		Vector3 gunLocation = GameObject.Find(gunner).transform.position;

		GameObject projectileType = determineProjectileType ();
		GameObject projectileGO = Instantiate (projectile, gunLocation, Quaternion.identity);
		Instantiate (projectileType, projectileGO.transform, false);

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
}
