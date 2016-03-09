using UnityEngine;
using System.Collections;

public class Follow_Bird : MonoBehaviour {

	public Transform target_1;
	public Transform target_2;
	public GameObject Off_Screen;
	public GameObject Gatox;
	public int speed = 5;
	public Vector3 Variable_Neisa;

	private Gato ScriptGato;

	void Awake () {
	
		ScriptGato = GetComponent<Gato> ();

	}

	void Start () {
	
		Gatox = GameObject.FindGameObjectWithTag ("Gato");
		Off_Screen = GameObject.Find ("Off_Pajaro");

		ScriptGato = Gatox.GetComponent<Gato> ();

		target_1 = Gatox.transform;
		target_2 = Off_Screen.transform;

	}

	// Update is called once per frame
	void Update () {

			float step = speed * Time.deltaTime;

			if (ScriptGato.Hidden == false && (GameObject.FindGameObjectWithTag ("Gato") != null)) {

				Variable_Neisa = Vector3.MoveTowards (transform.position, target_1.position, step) - this.transform.position;

				transform.position = Vector3.MoveTowards (transform.position, target_1.position, step);

				if (Variable_Neisa.x > 0) {
					transform.localEulerAngles = new Vector3 (0, 180, (-180 * (Mathf.Atan (Variable_Neisa.y / Variable_Neisa.x))) / 3.14f);
				} else {
					transform.localEulerAngles = new Vector3 (0, 0, (180 * (Mathf.Atan (Variable_Neisa.y / Variable_Neisa.x))) / 3.14f);
				}
		
			} else if (ScriptGato.Hidden == true && (GameObject.FindGameObjectWithTag ("Gato") != null)) {

				Variable_Neisa = Vector3.MoveTowards (transform.position, target_2.position, step) - this.transform.position;
		
				transform.position = Vector3.MoveTowards (transform.position, target_2.position, step * 1.2f);

				if (Variable_Neisa.x > 0) {
					transform.localEulerAngles = new Vector3 (0, 180, (-180 * (Mathf.Atan (Variable_Neisa.y / Variable_Neisa.x))) / 3.14f);
				} else {
					transform.localEulerAngles = new Vector3 (0, 0, (180 * (Mathf.Atan (Variable_Neisa.y / Variable_Neisa.x))) / 3.14f);
				}

			}

		if (transform.position.y > 6 || (GameObject.FindGameObjectWithTag ("Gato") == null)) {

			Destroy (this.gameObject);
		}
	}
}
