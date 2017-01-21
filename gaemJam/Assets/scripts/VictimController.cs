using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VictimController : MonoBehaviour {

    private float speed;
	private bool shieldEnabled;

	public GameObject shield;

    public Vector3 move;

	private GameObject shieldgo;


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
			enableShield ();
		}
		if (other.CompareTag("SpeedBoost")){
			Debug.Log("Speed Boost enabled!");
		}
		if (other.tag == "Bullet")
		{
			Debug.Log("HIT");
			if (shieldEnabled) {
				Debug.Log ("Victim didn't die because of shield!");
				disableShield ();
			} else {
				VictimKilled ();
			}
		}
	}

	void enableShield(){
		shieldEnabled = true;
		shieldgo = Instantiate (shield, gameObject.transform, false);
		shieldgo.transform.localScale = new Vector3(4,4,1);
	}

	void disableShield(){
		shieldEnabled = false;
		Destroy (shieldgo);
	}

	void enableSpeedBoost(){
		
	}

	void disableSpeedBoost(){

	}
}
