using UnityEngine;
using System.Collections;

public class MariposaSpawner : MonoBehaviour {

	public Transform MariposaPrefab;
	public Transform coinPrefab;
	public float nextMariposaTime = 20f;
	public float nextCoinTime = 10f;
	private float spawnRateMariposa = 3f;
	private float spawnCoinRate = 1.5f;


	// Update is called once per frame
	void Update () {
		if (nextMariposaTime < Time.time){
			SpawnMariposa ();
			nextMariposaTime = Time.time + spawnRateMariposa;
			
			spawnRateMariposa *= 10f;
			spawnRateMariposa = Mathf.Clamp (spawnRateMariposa, 1f, 2f);
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
		Vector3 spawnPos = transform.position + new Vector3 (addxPos, 5, 0);
		Instantiate (MariposaPrefab, spawnPos, Quaternion.identity);
	}
	void SpawnCoin()
	{
		float addxPos = Random.Range (-10f, 10f);
		Vector3 spawnPos = transform.position + new Vector3 (addxPos, 5, 0);
		Instantiate (coinPrefab, spawnPos, Quaternion.identity);
	}

}
