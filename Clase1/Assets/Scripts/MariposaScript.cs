using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MariposaScript : MonoBehaviour {

	public Text Score; 
	private int Puntaje = 0;
	
	// Update is called once per frame
	void Update () {

		float fallSpeed = 5 * Time.deltaTime;
		transform.position -= new Vector3 (0, fallSpeed, 0);
		//Score.text = Puntaje.ToString ();
	
	}

	/*void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "PisoCheck") {
			//print ("Works");
			Destroy (this.gameObject);


		}
	}*/


}
