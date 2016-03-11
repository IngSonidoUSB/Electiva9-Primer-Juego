using UnityEngine;
using System.Collections;

public class music : MonoBehaviour {
	AudioSource audio;

	// Use this for initialization
	void Start () {
		AudioSource audio = GetComponent<AudioSource>();
		audio.Play ();
	}
	

}
