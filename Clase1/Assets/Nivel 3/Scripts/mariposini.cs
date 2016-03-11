using UnityEngine;
using System.Collections;

public class mariposini : MonoBehaviour {

	public Transform FlyPrefab;

	private float nextMariposaTime = 5f;
	private float spawnRate = 8f;


	// Update is called once per frame
	void Update () {
		if (nextMariposaTime < Time.time){
			SpawnMariposa ();
			nextMariposaTime = Time.time + spawnRate;

			//spawnRate *= 10f;
			//spawnRate = Mathf.Clamp (spawnRate, 1f, 2f);
		}
	}

	void SpawnMariposa()
	{
		float addxPos = Random.Range (-8f, 8f);
		Vector3 spawnPos = transform.position + new Vector3 (addxPos, 0, 0);
		Instantiate (FlyPrefab, spawnPos, Quaternion.identity);
	}

}

