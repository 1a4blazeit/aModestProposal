using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    string writeText;
    int count;
    public Text interText;

	// Use this for initialization
	void Start () {
        writeText = "shots fired: " + 0;
        count = 0;
        GetComponent<Text>().text = writeText;
	}
	
	// Update is called once per frame
	void Update () {
 
    }

    public void CountUp()
    {

        count++;
        writeText = "shots fired: " + count;

        GetComponent<Text>().text = writeText;
    }
}
