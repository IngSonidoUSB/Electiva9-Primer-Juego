using UnityEngine;
using System.Collections;
using CnControls;


public class Gato : MonoBehaviour {

	float Move;
	float Move_Speed = 5;
	public float Jump = 350f;
	public bool Grounded;
	public float Vel_Y;
	public int Puntos;
	public int Vidas = 3;


	public bool Hidden;
	public bool Pajaro_Leave = false;
	private bool Space_Down = false;


	AudioSource audio;
	public AudioClip Moneda;
	public AudioClip Salto;
	public AudioClip Muerte;
	public AudioClip Mew;


	Animator AnimGato;
	Rigidbody RB;

	// Use this for initialization
	void Start () {

		audio = GetComponent<AudioSource>();
		AnimGato = GetComponent<Animator> ();
		RB = GetComponent<Rigidbody> ();
		Hidden = false;
	
	}
	
	// Update is called once per frame
	void Update () {

		Vel_Y = RB.velocity.y;

		Move = CnInputManager.GetAxis ("Horizontal") * Time.deltaTime * Move_Speed;
		transform.position = transform.position + new Vector3 (Move, 0, 0);

		if ( Move > 0 || (CnInputManager.GetButtonDown("Horizontal")) ) {
			transform.localEulerAngles = new Vector3 (0, 0, 0);
			AnimGato.SetBool ("isWalking", true);
		
		} else if ( Move < 0 || (CnInputManager.GetButtonDown("Horizontal")) ) {
			transform.localEulerAngles = new Vector3 (0, 180, 0);
			AnimGato.SetBool ("isWalking", true);
		
		} else if (!Input.anyKey) {
			AnimGato.SetBool ("isWalking", false);
		}

		if ( (Input.GetButton("Jump") || CnInputManager.GetButtonDown ("Jump") ) && Grounded == true && Space_Down == false) {
			audio.clip = Salto;
			audio.Play();
			AnimGato.SetBool ("Jump", true);
			RB.AddForce (0, Jump, 0);
			Space_Down = true;
		}

		if (Input.GetKey (KeyCode.Space) != true) {

			Space_Down = false;
		}

		if (RB.velocity.y < 0) {
			AnimGato.SetBool ("Jump", false);
			AnimGato.SetBool ("Falling", true);
		}

		if (Grounded == true) {
			AnimGato.SetBool ("Falling", false);
		}

		if (transform.position.y < -4.9f) {
			audio.clip = Muerte;
			audio.Play();
			transform.position = new Vector3 (-0.28f, 2.3f, 5);
			Destroy(GameObject.FindGameObjectWithTag("Pajaro"));
			if (Vidas != 0) {
				GameObject.Find ("Vida" + Vidas).SetActive(false);
				Vidas--;
			}

		}
							
	}


	void OnTriggerEnter (Collider Trig) {
		if (Trig.transform.tag == "Mariposa") {
			Destroy (Trig.gameObject);
			Puntos = Puntos + 1;
			audio.clip = Moneda;
			audio.Play ();
		}
			
		if (Trig.transform.tag == "Pajaro") {
			audio.clip = Mew;
			audio.Play();
			if (Puntos != 0) {
				Puntos = Puntos - 1;
			}
			Destroy (Trig.gameObject);

		}

		if (Trig.tag == "Bush") {

			Hidden = true;
		}

		if (Trig.transform.tag == "Perro") {
			audio.clip = Muerte;
			audio.Play();
			Destroy (GameObject.FindGameObjectWithTag ("Pajaro"));
			transform.position = new Vector3 (-0.28f, 2.3f, 5);
			if (Vidas != 0) {
				GameObject.Find ("Vida" + Vidas).SetActive(false);
				Vidas--;
			}
				

		} 

	}

	void OnTriggerExit (Collider Trig) {
	

		if (Trig.tag == "Bush") {

			Hidden = false;
		} 

	}



	void OnCollisionEnter (Collision col)
	{
		if (col.gameObject.tag == "Ground") {
			Grounded = true;
		}
	}

	void OnCollisionExit (Collision col) 
	{
		if (col.gameObject.tag == "Ground") {
			Grounded = false;
			if (Input.GetButtonDown("Jump")) { } 
		}

	}
}
