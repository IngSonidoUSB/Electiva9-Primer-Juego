using UnityEngine;
using System.Collections;

public class GameMaster : MonoBehaviour {

	public GameObject gato;
	public GameObject mariposa;
	public GameObject modena;
	public GameObject enemigo;
	private PuntajeNivel2 puntosJugador;

	// Use this for initialization
	void Start () {
		puntosJugador = gato.GetComponent<PuntajeNivel2>();
	}
	
	// Update is called once per frame
	void Update () {
		puntosJugador = gato.GetComponent<PuntajeNivel2>();
		if (puntosJugador.getValue()>=500) {
			Application.LoadLevel("nivel 3 chente");
		}
		if (gato.GetComponent<PlayerScript>().getVidasGato()<=0) {
			Application.LoadLevel(0);
		}
	}
}
