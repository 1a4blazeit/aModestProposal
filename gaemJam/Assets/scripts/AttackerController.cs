using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerController : MonoBehaviour {

    public Transform bullet;

    // Update is called once per frame
    void Update () {
		if (Input.GetButtonDown("Shoot"))
		{
			FireBullet ("shooter3");
		}

        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            FireBullet("shooter1");
        }

        if(Input.GetKeyDown(KeyCode.RightControl))
        {
            FireBullet("shooter2");
        }

    }

	void FireBullet(string gunner){

        GameObject.Find("MainModel").GetComponent<MainController>().InstantiateGameObject(bullet, gunner);
	}
}
