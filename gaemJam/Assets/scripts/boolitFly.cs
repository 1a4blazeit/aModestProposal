using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boolitFly : MonoBehaviour {

    public Vector3 move;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("space"))
        {
            print("space key was pressed");
            transform.position = GameObject.Find("victim").transform.position;
        }
    }

    void FixedUpdate ()
    {
        move = new Vector3(0, 0.5f, 0);
        transform.position += move;
    }
}
