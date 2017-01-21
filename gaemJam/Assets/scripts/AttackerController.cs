using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerController : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Shoot"))
		{
			Debug.Log("Shooting");
		}
	}
}
