using UnityEngine;
using System.Collections;

public class Mariposa_Fall : MonoBehaviour {

	float Fall_Speed = 1.5f;
	public float Amplitud = 0.1f;
	public float Freq = 16;
	private float Spawn_Time;

	// Update is called once per frame
	void Update () {

		if (Time.time - Spawn_Time >= 1.5) {
		Spawn_Time = Time.time;
		Freq = Random.Range (1, 16);
		}

		transform.position = transform.position - new Vector3 (Amplitud*Mathf.Sin(Time.time*Freq), Fall_Speed * Time.deltaTime, 0);

		if (transform.position.y < -4.9f) {

			Destroy (this.gameObject);
		}

	}

}
