﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MovMariposa : MonoBehaviour {

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        float fallSpeed = 10 * Time.deltaTime;
        transform.position -= new Vector3(0, fallSpeed, 0);

    }
}
