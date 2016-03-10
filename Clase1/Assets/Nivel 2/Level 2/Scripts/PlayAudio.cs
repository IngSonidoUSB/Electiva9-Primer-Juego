using UnityEngine;
using System.Collections;



[RequireComponent(typeof(AudioSource))]
public class PlayAudio : MonoBehaviour {

	public AudioClip Cat;
    public AudioClip Cat1;
    private AudioSource Sound;

	// Use this for initialization
	void Start () {

		Sound = GetComponent<AudioSource>();
		Sound.clip = Cat;

		
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "Mariposa") {
			
			Sound.Play ();

        if (col.gameObject.tag == "Coin") 

                Sound.Play();
            }
	}
}
