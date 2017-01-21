using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VictimController : MonoBehaviour {

    private float speed;
	private bool shieldEnabled;

    public Vector3 move;


	// Use this for initialization
	private void Start () {
        speed = 0.2f;
		shieldEnabled = false;
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

    void VictimKilled()
    {
        GameObject.Find("MainModel").GetComponent<MainController>().VictimKilledEnd();
    }

	void OnTriggerEnter2D(Collider2D other){
		if (other.CompareTag("Shield")){
			Debug.Log("Shield enabled!");
			shieldEnabled = true;
		}
		if (other.CompareTag("SpeedBoost")){
			Debug.Log("Speed Boost enabled!");
		}
		if (other.tag == "Bullet")
		{
			Debug.Log("HIT");
			if (shieldEnabled) {
				Debug.Log ("Victim didn't die because of shield!");
				shieldEnabled = false;
			} else {
				VictimKilled ();
			}
		}
	}

	void enableSpeedBoost(){

	}

	void disableSpeedBoost(){

	}
}
