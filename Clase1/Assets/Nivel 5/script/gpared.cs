﻿using UnityEngine;
using System.Collections;

public class gpared : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "murcielago" || col.gameObject.tag == "mariposa")
        {
            //print ("Works");
            Destroy(col.gameObject);
        }
    }

  
}
