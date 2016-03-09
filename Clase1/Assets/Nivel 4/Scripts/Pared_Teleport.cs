using UnityEngine;
using System.Collections;

public class Pared_Teleport : MonoBehaviour {

	public Transform destinoTrigger;

	void OnTriggerEnter (Collider Trig) {
		if (Trig.transform.name == "Gato") {
			Vector3 NewPos = destinoTrigger.position;
			NewPos.y = Trig.transform.position.y;
			Trig.transform.position = NewPos;
		}
	}
}