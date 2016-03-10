using UnityEngine;
using System.Collections;

public class GameMaster : MonoBehaviour {

	public GameObject gato;
	public GameObject mariposa;
	public GameObject modena;
	public GameObject enemigo;
	private Puntaje puntosJugador;

	// Use this for initialization
	void Start () {
		puntosJugador = gato.GetComponent<Puntaje>();
	}
	
	// Update is called once per frame
	void Update () {
		puntosJugador = gato.GetComponent<Puntaje>();
		if (puntosJugador.getValue()>=500) {
			Application.LoadLevel("nivel3");
		}
		if (gato.GetComponent<PlayerScript>().getVidasGato()<=0) {
			Application.LoadLevel(0);
		}
	}
}
