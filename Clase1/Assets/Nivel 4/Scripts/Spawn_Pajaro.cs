using UnityEngine;
using System.Collections;

public class Spawn_Pajaro : MonoBehaviour {

	public GameObject Spawn_Prefab_Pajaro;
	public GameObject Gatox;
	private Gato ScriptGato;
	AudioSource audioP;
	float LastTime;
	float ActualTime;
	bool first = true;



	void Awake () {

		ScriptGato = GetComponent<Gato> ();

	}

	void Start () {
		audioP = GetComponent<AudioSource>();
		Gatox = GameObject.Find ("Gato");
		ScriptGato = Gatox.GetComponent<Gato> ();
		ActualTime = 0;
		LastTime = 0;
	}
		
	void Update () {

		ActualTime = Time.time;
		if (GameObject.FindGameObjectWithTag ("Pajaro") == null &&  ScriptGato.Hidden ==  false) {

			if (first) {
				LastTime = ActualTime;
				first = false;
			}

			if (LastTime+2 <= ActualTime) {
				audioP.Play ();
				Instantiate (Spawn_Prefab_Pajaro, new Vector3 (Random.Range (-9.5f, 9.5f), 5.5f, 5), Quaternion.identity);
				LastTime = ActualTime;
				first = true;
			}

		}
	}
		
		
}
