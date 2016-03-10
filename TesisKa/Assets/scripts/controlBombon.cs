using UnityEngine;
using System.Collections;


public class controlBombon : MonoBehaviour {

	public Transform gato;
	public float test;
	private bool JumpControl = true;
	private bool JumpFlag = false;
	private int Dir;
	private int dir;
	private Animator animator;


	void Start () {

		animator = this.GetComponent<Animator> ();
		animator.SetBool ("jumpback", true);
	}
	// Update is called once per frame
	void Update () {

		float moveInput = Input.GetAxis("Horizontal") * Time.deltaTime * 3;
		//float JumpInput = CnInputManager.GetButtonDown ("Jump");

		//Direction ();
		if (moveInput < 0) {
			dir = dir * -1;
		}
		transform.localScale += new Vector3 (dir, 0, 0);
		transform.position += new Vector3 (moveInput, 0, 0);

		if (Input.GetButtonDown ("Jump") && JumpFlag) {

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
		}
		animator.SetBool ("Direction", true);
	}

}
