using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerController : MonoBehaviour {

    public Transform bullet;

    // Update is called once per frame
    void Update () {
		if (Input.GetButtonDown("Shoot"))
		{
			FireBullet ();
		}
	}

	void FireBullet(){

        GameObject.Find("MainModel").GetComponent<MainController>().InstantiateGameObject(bullet);
	}
}
