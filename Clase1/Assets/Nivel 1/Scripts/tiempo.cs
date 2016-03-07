using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class tiempo : MonoBehaviour {

	public Text TimeText;
	private float Tiempo=120f;
	private int Minutos, segundos;

	// Use this for initialization
	void Start () {


	}

	// Update is called once per frame
	void Update () {

		Tiempo -= Time.deltaTime;
		Minutos = (int)Tiempo / 60;
		segundos = (int)Tiempo - (Minutos * 60);
		if (segundos <= 9) {
			TimeText.text = Minutos.ToString () + ":0" + segundos.ToString ();	
		} else {
			TimeText.text = Minutos.ToString () + ":" + segundos.ToString ();
		}
		if (Tiempo <= 0) {
			GameOver ();
		}


	}

	void GameOver() {
		print ("GameOver");
	}
}
