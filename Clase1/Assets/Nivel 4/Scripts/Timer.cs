using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using CnControls;

public class Timer : MonoBehaviour {

	public Text TimeText;
	public float Tiempo;
	private int Minutos, segundos;

	// Use this for initialization
	void Start () {
		

	}

	// Update is called once per frame
	void Update () {

		/*if (CnInputManager.GetButtonDown ("Pause")) {

			Time.timeScale =0;

		} */
		 
		Tiempo -= Time.deltaTime;
		Minutos = (int)Tiempo / 60;
		segundos = (int)Tiempo - (Minutos * 60);
		if (segundos <= 9) {
			TimeText.text = "= " + Minutos.ToString () + ":0" + segundos.ToString ();	
		} else {
			TimeText.text = "= " +  Minutos.ToString () + ":" + segundos.ToString ();
		}
		if (Tiempo <= 0) {
			GameOver ();
		}

	
	}

	void GameOver() {
		print ("GameOver");
	}
}
