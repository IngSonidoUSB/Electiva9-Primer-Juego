using UnityEngine;
using System.Collections;

public class DestroyScaleOut : MonoBehaviour {

	// Use this for initialization
	void OnTriggerEnter(Collider col){
		if (col.gameObject.tag == "Coin") {
			Destroy(col.gameObject);
		}
		if (col.gameObject.tag == "Mariposa") {
			Destroy(col.gameObject);
		}
	}
}
