﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Mariposamov : MonoBehaviour {

	public Text Score; 
	private int Puntaje = 0;

	// Update is called once per frame
	void Update () {

		float fallSpeed = 5 * Time.deltaTime;
		float seno =0.05f*Mathf.Sin(2*Time.time);
		transform.position -= new Vector3 (seno, fallSpeed, 0);
		//Score.text = Puntaje.ToString ();

	}

	void OnTriggerEnter2D(Collider2D other) 
	{
		if( other.gameObject.name.Equals ("piso")){
			Destroy (this.gameObject);
		}

	}


}
