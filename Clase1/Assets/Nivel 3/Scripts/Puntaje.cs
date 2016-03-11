using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Puntaje : MonoBehaviour
{
	public bool loatrapo = false;
	private bool antes = false;

	public Text Score;
	public int Value = 0;

	public AudioClip tigre;
	public AudioClip Cat;
	public AudioClip CatA;
	private AudioSource Sound;


	// Use this for initialization
	void Start()
	{
		Sound = GetComponent<AudioSource>();
		Sound.clip = tigre;


	}

	// Update is called once per frame
	void Update()
	{
		Score.text = Value.ToString();
	}
	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.tag == "butterfly")
		{
			Value++;

			if (Value >= 10) {
				Sound.PlayOneShot(tigre,1);
			} else {
				Sound.PlayOneShot (Cat,1);
			}
		}
		if (col.gameObject.tag == "BIRD")
		{
			Value--;
			Sound.PlayOneShot (CatA,1);
			if (Value < 0) {
				Value = 0;
			}
		}
	}
}