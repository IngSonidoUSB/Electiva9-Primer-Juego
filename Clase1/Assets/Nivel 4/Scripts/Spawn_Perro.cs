using UnityEngine;
using System.Collections;

public class Spawn_Perro : MonoBehaviour {

	public GameObject Spawn_Perrox;
	float Spawn_Time = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Time.time - Spawn_Time >= 6) {
			Spawn_Time = Time.time;
		
			Instantiate (Spawn_Perrox, new Vector3 (0, 0, 0), Quaternion.identity);
		}
	
	}
}
