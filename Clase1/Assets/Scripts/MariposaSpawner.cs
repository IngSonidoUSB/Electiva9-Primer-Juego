using UnityEngine;
using System.Collections;

public class MariposaSpawner : MonoBehaviour {

	public Transform MariposaPrefab;

	public float nextMariposaTime = 10f;
	private float spawnRate = 1.5f;


	// Update is called once per frame
	void Update () {
		if (nextMariposaTime < Time.time){
			SpawnMariposa ();
		nextMariposaTime = Time.time + spawnRate;

		spawnRate *= 10f;
		spawnRate = Mathf.Clamp (spawnRate, 1f, 2f);
	}
	}

	void SpawnMariposa()
	{
		float addxPos = Random.Range (-10f, 10f);
		Vector3 spawnPos = transform.position + new Vector3 (addxPos, 0, 0);
		Instantiate (MariposaPrefab, spawnPos, Quaternion.identity);
	}

}
