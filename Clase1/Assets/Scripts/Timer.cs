using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[RequireComponent(typeof(AudioSource))]
public class Timer : MonoBehaviour {

	public Text TimeText;
	public float Tiempo;
	private int Minutos, segundos;
    public AudioClip levelout;
    private AudioSource Sound;
    public AudioClip fondo;


    // Use this for initialization
    void Start () {
        Sound = GetComponent<AudioSource>();
        Sound.clip = levelout;
        Sound.clip = fondo;

    }

	// Update is called once per frame
	void Update () {
        Sound.clip = fondo;
        Sound.Play();
        if (Tiempo>0) { 
            Tiempo -= Time.deltaTime;
            Minutos = (int)Tiempo / 60;
            segundos = (int)Tiempo - (Minutos * 60);
            if (segundos <= 9)
            {
                TimeText.text = Minutos.ToString() + ":0" + segundos.ToString();
            }
            else if (segundos == 0 && Minutos == 0)
            {
                GameOver();
                Sound.clip = levelout;
                Sound.Play();
                Minutos = 0;
                segundos = 0;
                TimeText.text = Minutos.ToString() + ":" + segundos.ToString();
            }
            else {
                TimeText.text = Minutos.ToString() + ":" + segundos.ToString();
            }
        }

	
	}

	void GameOver() {
		print ("GameOver");
	}
}
