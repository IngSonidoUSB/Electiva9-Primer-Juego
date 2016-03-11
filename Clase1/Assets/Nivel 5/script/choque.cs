using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class choque : MonoBehaviour {

    // Use this for initialization
    public AudioClip ventana;
    private AudioSource Sound;
    public bool colisiono=false;
    
    void Start () {
        Sound = GetComponent<AudioSource>();
        Sound.clip = ventana;
    }
	
	// Update is called once per frame
	void Update () {
        
    }


    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "gato")

        {
            colisiono = true;
            Sound.clip = ventana;
            Sound.Play();
        }
    }
}
