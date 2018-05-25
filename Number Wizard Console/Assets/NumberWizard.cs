using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        int max = 1000;
        int min = 1;

        Debug.Log("Welcome to number wizard, yo");
        Debug.Log("Pick a number, don't tell me what it is...");
        Debug.Log("The highest number you can pick is: " + max);
        Debug.Log("The lowest number you can pick is: " + min);
        Debug.Log("Tell me if your number is higher or lower than 500");
        Debug.Log("Push Up = Higher, Push Down = Lower, Push Enter = Correct");
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("Up Arrow key was pressed.");
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("Down Arrow key was pressed.");
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("You hit enter.");
        }
    }
}
