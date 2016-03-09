using UnityEngine;
using System.Collections;

public class Spawner_Gato : MonoBehaviour {

	public GameObject Spawn_Prefab_Gatox;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (GameObject.FindGameObjectWithTag ("Gato") == null) {

			Instantiate (Spawn_Prefab_Gatox, new Vector3 (-0.28f,2.3f,5), Quaternion.identity);

		}
	
	}
}
