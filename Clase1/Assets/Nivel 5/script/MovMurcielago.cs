using UnityEngine;
using System.Collections;

public class MovMurcielago : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		float fallSpeed = 4 * Time.deltaTime;
		transform.position += new Vector3(fallSpeed, 0, 0);

	}
	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.tag == "pared R")
		{
			Destroy(GameObject.FindWithTag("murcielago"));
		}
	}

	void OnCollisionExit(Collision col)
	{
		if (col.gameObject.tag == "pared R")
		{
					}

	}
	void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "Mariposa")
		{
			//print ("Works");
			Destroy(col.gameObject);
		}
}
}