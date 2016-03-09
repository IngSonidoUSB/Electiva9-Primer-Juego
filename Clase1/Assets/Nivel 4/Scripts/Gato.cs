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

	public bool Hidden;
	public bool Pajaro_Leave = false;
	private bool Space_Down = false;


	Animator AnimGato;
	Rigidbody RB;

	// Use this for initialization
	void Start () {

		AnimGato = GetComponent<Animator> ();
		RB = GetComponent<Rigidbody> ();
		Hidden = false;
	
	}
	
	// Update is called once per frame
	void Update () {

		Vel_Y = RB.velocity.y;

		Move = CnInputManager.GetAxis ("Horizontal") * Time.deltaTime * Move_Speed;
		transform.position = transform.position + new Vector3 (Move, 0, 0);

		if ( (Move > 0 || CnInputManager.GetAxis("Horizontal")  > 0) &&  Input.GetKey (KeyCode.RightArrow) ) {
			transform.localEulerAngles = new Vector3 (0, 0, 0);
			AnimGato.SetBool ("isWalking", true);
		
		} else if ( (Move < 0 || CnInputManager.GetAxis("Horizontal") < 0) && Input.GetKey (KeyCode.LeftArrow)) {
			transform.localEulerAngles = new Vector3 (0, 180, 0);
			AnimGato.SetBool ("isWalking", true);
		
		} else if (!Input.anyKey) {
			AnimGato.SetBool ("isWalking", false);
		}

		if ( (Input.GetButton("Jump") || CnInputManager.GetButtonDown ("Jump") ) && Grounded == true && Space_Down == false) {
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

			Destroy (this.gameObject);
			Destroy(GameObject.FindGameObjectWithTag("Pajaro"));
		}
							
	}


	void OnTriggerEnter (Collider Trig) {
		if (Trig.transform.tag == "Mariposa") {
			Destroy (Trig.gameObject);
			Puntos = Puntos + 1;
		}
			
		if (Trig.transform.tag == "Pajaro") {
			if (Puntos != 0) {
				Puntos = Puntos - 1;
			}
			Destroy (Trig.gameObject);

		}

		if (Trig.tag == "Bush") {

			Hidden = true;
		}

		if (Trig.transform.tag == "Perro") {

			Destroy (this.gameObject);
			Destroy(GameObject.FindGameObjectWithTag("Pajaro"));

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
