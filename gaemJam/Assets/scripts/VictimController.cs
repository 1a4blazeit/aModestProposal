using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VictimController : MonoBehaviour {

    private float speed;
    public Vector3 move;

	// Use this for initialization
	private void Start () {
        speed = 0.5f;
	}
	
	// Update is called once per frame
	private void FixedUpdate () {
        
        move = new Vector3(Input.GetAxisRaw("Horizontal"), 0, 0);

        transform.position += move * speed;

        if (transform.position.x > 7)
            transform.position = new Vector3(7, transform.position.y, 0);

        if (transform.position.x < -7)
            transform.position = new Vector3(-7, transform.position.y, 0);
    }

    public void speedMod (string changeTo)
    {
        if ( changeTo == "boost")
        {
            speed = 1.0f;
        } else if ( changeTo == "reset"){
            speed = 0.5f;
        } else if ( changeTo == "slow")
        {
            speed = 0.2f;
        }
    }
}
