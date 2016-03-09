using UnityEngine;
using System.Collections;

public class Spawn_Pajaro : MonoBehaviour {

	public GameObject Spawn_Prefab_Pajaro;

	void Update () {

		if (GameObject.FindGameObjectWithTag ("Pajaro") == null) {
		
			Instantiate (Spawn_Prefab_Pajaro, new Vector3 (3, 7, 5), Quaternion.identity);

		}

	}
		

}
