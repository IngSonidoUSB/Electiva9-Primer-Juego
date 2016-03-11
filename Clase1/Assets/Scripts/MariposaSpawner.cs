using UnityEngine;
using System.Collections;

public class MariposaSpawner : MonoBehaviour {

	public Transform MariposaPrefab;
	public Transform coinPrefab;
	public float nextMariposaTime = 10f;
	private float spawnRate = 1.5f;
	public float nextCoinTime = 20f;
	private float spawnCoinRate = 3f;


	// Update is called once per frame
	void Update () {
		if (nextMariposaTime < Time.time){
			SpawnMariposa ();
			nextMariposaTime = Time.time + spawnRate;
			
			spawnRate *= 10f;
			spawnRate = Mathf.Clamp (spawnRate, 1f, 2f);
		}
		if (nextCoinTime < Time.time){
			SpawnCoin ();
			nextCoinTime = Time.time + spawnCoinRate;
			spawnCoinRate *= 10f;
			spawnCoinRate = Mathf.Clamp (spawnCoinRate, 1f, 2f);
		}
	}

	void SpawnMariposa()
	{
		float addxPos = Random.Range (-10f, 10f);
		Vector3 spawnPos = transform.position + new Vector3 (addxPos, 5.5f, 0);
		Instantiate (MariposaPrefab, spawnPos, Quaternion.identity);
	}
	void SpawnCoin()
	{
		float addxPos = Random.Range (-10f, 10f);
		Vector3 spawnPos = transform.position + new Vector3 (addxPos, 5.5f, 0);
		Instantiate (coinPrefab, spawnPos, Quaternion.identity);
	}

}
