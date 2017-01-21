using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerController : MonoBehaviour {

	public Rigidbody bullet;

	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Shoot"))
		{
			FireBullet ();
		}
	}

	void FireBullet(){
		//TODO: Call InstantiateGameObject(bullet) from the MainController
		Debug.Log("Calling InstantiateGameObject(bullet) from the MainController");
	}
}
