using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour {

	public GameObject Spawn_Prefab;
	float Spawn_Time = 0;

	void Update () {

		if (Time.time - Spawn_Time >= 1.5) {
			Spawn_Time = Time.time;

			Instantiate (Spawn_Prefab , new Vector3(Random.Range(-9.4f,9.4f),5,1), Quaternion.identity);
		}

	}

}