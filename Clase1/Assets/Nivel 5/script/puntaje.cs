using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class puntaje : MonoBehaviour
{
	public bool loatrapo = false;
	private bool antes = false;

	public Text Score;
	public int Value = 0;

	
	void Start()
	{
		


	}

	
	void Update()
	{
		Score.text = Value.ToString();
	}
	void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "Mariposa")
		{
			Value++;

			//if (Value >= 10) {
				//Sound.PlayOneShot(tigre,1);
		//	} else {
				//Sound.PlayOneShot (Cat,1);
		//	}
		}
		if (col.gameObject.tag == "murcielago")
		{
			Value--;
			//Sound.PlayOneShot (CatA,1);
			if (Value < 0) {
				Value = 0;
			}
		}
	}
}