using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class score : MonoBehaviour
{
	public bool loatrapo = false;
	private bool antes = false;

	public Text Score;
	private int Value = 0;

	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		Score.text = Value.ToString();
	}
	void OnCollisionEnter2D(Collider2D col)
	{
		if (col.gameObject.tag == "Mariposa")
		{
			Value++;
		}
		if (col.gameObject.tag == "pajaro")
		{
			Value--;
			if (Value < 0) {
				Value = 0;
			}
		}
	}
}