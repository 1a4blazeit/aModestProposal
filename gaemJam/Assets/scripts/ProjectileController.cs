using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileController : MonoBehaviour {

	private static float BASE_SPEED = 0.5f;
	private static float Y_DIRECTION = 1f;
	private float speed;
	private Vector3 move;

	public ProjectileController(float x) {
		// Create bullet at x coordinate going upwards.
		move = new Vector3(x, Y_DIRECTION, 0);
	}

	// Use this for initialization
	void Start () {
		speed = BASE_SPEED;
	}
	
	// Update is called once per frame
	void Update () {
        transform.position += move * speed;
	}
}
