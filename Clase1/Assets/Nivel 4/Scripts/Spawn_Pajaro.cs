using UnityEngine;
using System.Collections;

public class Spawn_Pajaro : MonoBehaviour {

	public GameObject Spawn_Prefab_Pajaro;
	public GameObject Gatox;
	private Gato ScriptGato;



	void Awake () {

		ScriptGato = GetComponent<Gato> ();

	}

	void Start () {
	
		Gatox = GameObject.Find ("Gato");
		ScriptGato = Gatox.GetComponent<Gato> ();
	}
		
	void Update () {

		if (GameObject.FindGameObjectWithTag ("Pajaro") == null &&  ScriptGato.Hidden ==  false) {
		
				Instantiate (Spawn_Prefab_Pajaro, new Vector3 (Random.Range(-9.5f, 9.5f),5.5f,5), Quaternion.identity);

		}

	}
		
}
