using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileController : MonoBehaviour {

	private static float Y_DIRECTION = -1f;
	private static float BASE_SPEED = 0.05f;

	private float speed;
	private Vector3 move;

	public ProjectileController(float x) {
		// Create bullet at x coordinate going upwards.
		transform.position = new Vector3(x, 0, 0);
	}

	// Use this for initialization
	void Start () {
		speed = BASE_SPEED;
        move = new Vector3(0, Y_DIRECTION, 0);
    }

	
	// FixedUpdate is called once per physics
	void FixedUpdate () {
        transform.position += move * speed;
	}
}
