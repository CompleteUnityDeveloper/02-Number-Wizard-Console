using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {

	// Use this for initialization
	void Start () {
        int max = 1000;
        int min = 1;

        Debug.Log("Welcome to number wizard, yo");
        Debug.Log("Pick an number, don't tell me what it is...");
        Debug.Log("The highest number you can pick is: " + max);
        Debug.Log("The lowest number you can pick is: " + min);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
