using UnityEngine;
using System.Collections;
using CnControls;

public class PlayerScript : MonoBehaviour {

	public Transform gato;
	public float test;
	private bool JumpControl = true;
	private bool JumpFlag = false;
	private int Dir;
	private Animator animator;


	void Start () {

		animator = this.GetComponent<Animator> ();
		animator.SetBool ("jumpback", true);
	}
	// Update is called once per frame
	void Update () {

		float moveInput = CnInputManager.GetAxis("Horizontal") * Time.deltaTime * 3;
		//float JumpInput = CnInputManager.GetButtonDown ("Jump");

		//Direction ();
		transform.position += new Vector3 (moveInput, 0, 0);
	
		if (CnInputManager.GetButtonDown ("Jump") && JumpFlag) {
			
			GetComponent<Rigidbody>().AddForce(new Vector3(0,400,0));
		} 

	
	}

	void OnCollisionEnter (Collision col)
	{
		if (col.gameObject.tag == "Piso") {
			JumpFlag = true;
			animator.SetBool ("Direction", false);
		}
	}

	void OnCollisionExit(Collision col) {
		if (col.gameObject.tag == "Piso") {
			JumpFlag = false;
			animator.SetBool ("Direction", true);
		}

	}

}
