using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void InstantiateGameObject(Object to_clone)
    {
        Vector3 location = new Vector3(0, 0, 0);
        //for now, instantiate the object at 0, 0, 0. in future, check what kind of object it is and spawn appropriately accordingly.
        Instantiate(to_clone, location);

    }
}
