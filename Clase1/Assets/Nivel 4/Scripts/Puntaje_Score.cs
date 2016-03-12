using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Puntaje_Score : MonoBehaviour
{
	public Text Score;
	public int Value = 0;


	// Use this for initialization
	void Start()
	{
		
	}

	// Update is called once per frame
	void Update()
	{
//		Score =  ("score");
			
		Score.text = Value.ToString();
	}
	void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "Mariposa")
		{
			Value++;

		}
		if (col.gameObject.tag == "Pajaro")
		{
			Value--;
			if (Value < 0) {
				Value = 0;
			}
		}
	}
}