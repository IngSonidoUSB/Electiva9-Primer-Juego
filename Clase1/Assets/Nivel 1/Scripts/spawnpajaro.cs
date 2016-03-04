using UnityEngine;
using System.Collections;

public class spawnpajaro : MonoBehaviour {
	public Transform BirdPrefab;
	private float birdtime = 8f;
	private float birdRate = 16f;
	// Use this for initialization

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (birdtime < Time.time){
			SpawnBird();
			birdtime = Time.time + birdRate;

			//spawnRate *= 10f;
			//spawnRate = Mathf.Clamp (spawnRate, 1f, 2f);
		}
	}

	void SpawnBird()
	{
		float addyPos = Random.Range (-5f, 4f);
		Vector3 spawnPos = transform.position + new Vector3 (0, addyPos, 0);
		Instantiate (BirdPrefab, spawnPos, Quaternion.identity);
	}
}
