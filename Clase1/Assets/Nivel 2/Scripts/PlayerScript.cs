using UnityEngine;
using System.Collections;
using CnControls;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour {

	//public transform gato;
	public float test;
	private Vector3 posInicial;
	private int vidasGato = 3;
	public Text vidasGatoText;
	private bool JumpControl = true;
	private bool JumpFlag = false;
	private int Dir;
	private float transX;
	private float transZ;
	private Animator animator;
	private Rigidbody rb;




	void Start () {
		
		animator = this.GetComponent<Animator> ();
		rb = GetComponent<Rigidbody> ();
		transX = transform.localScale.x;
		transZ = transform.localScale.z;
		posInicial = new Vector3(transform.localPosition.x,transform.localPosition.y,transform.localPosition.z);

	}
	// Update is called once per frame
	void Update () {

		float moveInput = CnInputManager.GetAxis("Horizontal") * Time.deltaTime * 3;

		Direction ();
		Jump ();
		vidasGatoText.text=vidasGato.ToString();

		transform.position += new Vector3 (moveInput, 0, 0);

		if (CnInputManager.GetButtonDown ("Jump") && JumpFlag) {
			
			GetComponent<Rigidbody>().AddForce(new Vector3(0,400,0));

		} 


	
	}

	void OnCollisionEnter (Collision col)
	{
		if (col.gameObject.tag == "Piso") {
			JumpFlag = true;
		} else if (col.gameObject.tag == "fuego" || col.gameObject.tag == "enemy") {
			if (vidasGato >= 1) {
				if (vidasGato == 1) {
					vidasGato--;
					vidasGatoText.text = vidasGato.ToString ();
					//Application.Quit();
					//Destroy (this.gameObject);
				}
				vidasGato--;
				transform.localPosition = posInicial;
			} else{
				//Application.Quit();
				//Destroy (this.gameObject);
			}
		}
	}

	void OnCollisionExit(Collision col) {
		if (col.gameObject.tag == "Piso") {
			JumpFlag = false;
			if (!CnInputManager.GetButtonDown ("Jump")) {


			} 
		}

	}

	void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "Mariposa") {
			//print ("Works");
			Destroy (col.gameObject);
		}
	}
	void Direction () {
		if (CnInputManager.GetAxis("Horizontal") > 0)
		{
			Dir = 1;
			transform.localScale =new Vector3(Dir*transX, transX, transZ);

		}
		if (CnInputManager.GetAxis("Horizontal") < 0){
			Dir = -1;
			transform.localScale =new Vector3(Dir*transX, transX, transZ);
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
	 public int getVidasGato(){
		return vidasGato;
	}

	/*IEnumerator Respawn(float spawnDelay)
	{
		yield return new WaitForSeconds(spawnDelay);
		Instantiate (gato, posInicial.position, posInicial.rotation);
	}*/


}
