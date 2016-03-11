using UnityEngine;
using System.Collections;

public class alhunter : MonoBehaviour {

	public Transform HunterPrefab;

	public float nextPerroTime = 5f;
	private float spawnRate = 1f;
	public AudioClip hunter;
	private AudioSource Sound;

	// Use this for initialization
	void Start()
	{
		Sound = GetComponent<AudioSource>();
		Sound.clip = hunter;

	}

	// Update is called once per frame
	void Update()
	{
		if (nextPerroTime < Time.time)
		{
			Spawnperro();
			nextPerroTime = Time.time + spawnRate;

			spawnRate *= 5;
			spawnRate = Mathf.Clamp(spawnRate, 5f, 9f);
		}
	}


	void Spawnperro()
	{

		Vector3 spawnPos = transform.position + new Vector3(0, 0, 0);
		Instantiate(HunterPrefab, spawnPos, Quaternion.identity);
		Sound.Play ();
	}


}

