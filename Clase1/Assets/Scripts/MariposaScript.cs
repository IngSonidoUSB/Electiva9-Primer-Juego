using UnityEngine;
using System.Collections;

public class MariposaScript : MonoBehaviour {


	
	// Update is called once per frame
	void Update () {

		float fallSpeed = 5 * Time.deltaTime;
		transform.position -= new Vector3 (0, fallSpeed, 0);
	
	}
}
