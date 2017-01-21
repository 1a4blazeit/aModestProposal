using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerController : MonoBehaviour {

	public GameObject cannon1;
	public GameObject cannon2;
	public GameObject cannon3;
	public GameObject cannon4;

    // Update is called once per frame
    void Update () {
		if (Input.GetButtonDown("Fire1"))
		{
			FireBullet (cannon1);
		}

		if (Input.GetButtonDown("Fire2"))
        {
            FireBullet(cannon2);
        }

		if (Input.GetButtonDown("Fire3"))
        {
            FireBullet(cannon3);
        }

		if (Input.GetButtonDown("Fire4"))
		{
			FireBullet(cannon4);
		}

    }

	void FireBullet(GameObject gunner){

		GameObject.Find("MainModel").GetComponent<MainController>().InstantiateProjectile(gunner);
	}
}
