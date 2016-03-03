using UnityEngine;
using System.Collections;

public class MovPerro : MonoBehaviour {
	//public float Velocidad;
	//private Rigidbody rb;

	// Use this for initialization
	//void Start () {
		//rb = GetComponent<Rigidbody> ();
	//}
	
	// Update is called once per frame
	//void Update () {
	
		//float MoverHorizontal = Input.GetAxis ("Horizontal");
		//float MoverVertical = Input.GetAxis ("Vertical");

		//Vector3 movimiento = new Vector3 (MoverHorizontal, 0.0f, MoverVertical);
		// /<summary>
		/// /
		/// </summary>GetComponent<Rigidbody>().AddForce(new Vector3(0,400,0));//
	//}
//}
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		float fallSpeed = 2 * Time.deltaTime;
		transform.position -= new Vector3(fallSpeed, 0, 0);

	}
	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.tag == "pared L")
		{
			Destroy(GameObject.FindWithTag("perro"));
		}
	}

	void OnCollisionExit(Collision col)
	{
		if (col.gameObject.tag == "pared L")
		{
		}

	}

}