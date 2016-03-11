using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[RequireComponent(typeof(AudioSource))]
public class puntaje : MonoBehaviour
{
	public bool loatrapo = false;
	private bool antes = false;

	public Text Score;
	public int Value = 0;

    public AudioClip golpe;
    private AudioSource Sound;


    void Start()
	{
        Sound = GetComponent<AudioSource>();
        Sound.clip = golpe;


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

			
		}
		if (col.gameObject.tag == "murcielago")
		{
			Value--;
            Sound.clip = golpe;
            Sound.Play();
            if (Value < 0) {
				Value = 0;
			}
            if (Value == 15) {
                print("winnnnn");
            }
		}
	}
}