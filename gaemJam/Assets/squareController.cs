﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#pragma strict



public class squareController : MonoBehaviour {

    public float speed;
    public Vector3 gravity;
    public Vector3 move;

	// Use this for initialization
	void Start () {
        speed = 0.5f;
	}
	
	// Update is called once per frame
	void Update () {


        move = new Vector3(Input.GetAxis("Horizontal"), 0, 0);

        if ((transform.position + move * speed).x < 7 && (transform.position + move * speed).x > -7)
            transform.position += move * speed;



    }

    void FixedUpdate()
    {

    }
}