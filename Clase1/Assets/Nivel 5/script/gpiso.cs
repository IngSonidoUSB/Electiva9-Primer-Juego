﻿using UnityEngine;
using System.Collections;

public class gpiso : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Mariposa")
        {
            //print ("Works");
            Destroy(col.gameObject);
        }
    }
}
