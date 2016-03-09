using UnityEngine;
using System.Collections;

public class Follow_Bird : MonoBehaviour {

	public Transform target_1;
	public Transform target_2;
	public GameObject Off_Screen;
	public GameObject Gatox;
	public int speed = 5;

	private Gato ScriptGato;
	public Gato Puntaje;
	public int x;

	void Awake () {
	
		ScriptGato = GetComponent<Gato> ();

	}

	void Start () {
	
		Gatox = GameObject.Find ("Gato");
		Off_Screen = GameObject.Find ("Cosa");

		ScriptGato = Gatox.GetComponent<Gato> ();

		target_1 = Gatox.transform;
		target_2 = Off_Screen.transform;

	}

	// Update is called once per frame
	void Update () {
		
		float step = speed * Time.deltaTime;

		if (ScriptGato.Hidden == false) {

			transform.position = Vector3.MoveTowards (transform.position, target_1.position, step);
		
		} else if (ScriptGato.Hidden == true) {
		
			transform.position = Vector3.MoveTowards (transform.position, target_2.position, step);
		}
			


	}
}
