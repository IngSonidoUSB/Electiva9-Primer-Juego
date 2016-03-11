using UnityEngine;
using System.Collections;

public class birdfly : MonoBehaviour {
	public Transform BirdcatPrefab;
	private float birdtime = 16f;
	private float birdRate = 16f;
	public AudioClip pajarillo;
	private AudioSource Sound;
	// Use this for initialization

	void Start () {
		Sound = GetComponent<AudioSource>();
		Sound.clip = pajarillo;
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
		Instantiate (BirdcatPrefab, spawnPos, Quaternion.identity);
		Sound.Play ();
	}
}
