using UnityEngine;
using System.Collections;
using CnControls;

public class catcontrol : MonoBehaviour {

	public Transform gato;
	public float test;

	private bool JumpFlag = false;
	private int Dir;
	private Animator animator;



	public AudioClip Cat;
	private AudioSource Sound;



	void Start () {

		animator = this.GetComponent<Animator> ();


		Sound = GetComponent<AudioSource>();
		Sound.clip = Cat;

	}
	// Update is called once per frame
	void Update () {

		float moveInput = CnInputManager.GetAxis("Horizontal") * Time.deltaTime * 5;

		Direction ();
		Jump ();

		transform.position += new Vector3 (moveInput, 0, 0);

		if (CnInputManager.GetButtonDown ("Jump") && JumpFlag) {

			GetComponent<Rigidbody2D>().AddForce(new Vector3(0,700,0));



		} 



	}

	void OnCollisionEnter2D (Collision2D col)
	{
		if (col.gameObject.tag == "Piso") {
			JumpFlag = true;
		}
	}

	void OnCollisionExit2D(Collision2D col) {
		if (col.gameObject.tag == "Piso") {
			JumpFlag = false;
			if (!CnInputManager.GetButtonDown ("Jump")) {


			} 
		}

	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.tag == "Mariposa") {
			//print ("Works");
			Destroy (col.gameObject);
			Sound.Play ();
		}





				



	}
	void Direction () {
		if (CnInputManager.GetAxis("Horizontal") > 0)
		{
			Dir = 1;
			transform.localScale =new Vector3(Dir*1f, 1f, 1);

		}
		if (CnInputManager.GetAxis("Horizontal") < 0){
			Dir = -1;
			transform.localScale =new Vector3(Dir*1f, 1f, 1);
		}
	}

	void Jump () {
		if (CnInputManager.GetButtonDown ("Jump")) {

			StartCoroutine ("JumpStop");
		} 
	}

	IEnumerator JumpStop (){
		animator.SetInteger ("Jump", 2);
		yield return new WaitForSeconds (1);
		animator.SetInteger ("Jump", 0);
	}

	IEnumerator FallStop (){
		animator.SetInteger ("Jump", 1);
		yield return new WaitForSeconds (0.5f);
		animator.SetInteger ("Jump", 0);
	}


		
		

}
