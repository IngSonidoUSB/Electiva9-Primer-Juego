using UnityEngine;
using System.Collections;

public class AlrMurcielago : MonoBehaviour {

	public Transform MurcielagoPrefab;

	public float nextMurcielagoTime = 10f;
	private float spawnRate = 1.5f;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (nextMurcielagoTime < Time.time)
		{
			SpawnMurcielago();
			nextMurcielagoTime = Time.time + spawnRate;

			spawnRate *= 5f;
			spawnRate = Mathf.Clamp(spawnRate, 1f, 2f);
		}
	}


	void SpawnMurcielago()
	{
		float addxPos = Random.Range(-2f, 2f);
		Vector3 spawnPos = transform.position + new Vector3(addxPos, 0, 0);
		Instantiate(MurcielagoPrefab, spawnPos, Quaternion.identity);
	}


}

