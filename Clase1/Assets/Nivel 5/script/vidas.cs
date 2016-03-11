using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[RequireComponent(typeof(AudioSource))]
public class vidas : MonoBehaviour
{
    public int VIDAS = 3;
    public bool SeEstrello = false;
    private bool anterior=false;
    public AudioClip levelout;
    public AudioClip vidaout;
    private AudioSource Sound;
    public Text GameOver;
    
    
    // Use this for initialization

    void Start()
    {
        Sound = GetComponent<AudioSource>();
        Sound.clip = levelout;
        Sound.clip = vidaout;
    }

    void Update()
    {
        

        if (SeEstrello == true && anterior==false)
        {
            
            VIDAS--;

            anterior = true;

            //SeEstrello = false;
            
            if (VIDAS == 2)
            {
                Destroy(GameObject.FindWithTag("vida3"));
                Sound.clip = vidaout;
                Sound.Play();

            }

            if (VIDAS == 1)
            {
                Destroy(GameObject.FindWithTag("vida2"));
                Sound.clip = vidaout;
                Sound.Play();
            }
            if (VIDAS == 0)
            {
                Destroy(GameObject.FindWithTag("vida1"));
                Sound.clip = levelout;
                Sound.Play();

                GameOver.text = "GAME OVER";
            }
        }
    }

    void OnTriggerEnter(Collider col)
    {

        if (col.gameObject.tag == "perro" )
        {
            print("works");
            SeEstrello = true;
            anterior = false;

        }
    }

  /* void OnCollisionExit(Collision col)
    {
        if (col.gameObject.tag == "perro")
        {
            SeEstrello = false;
            anterior = false;
        }
    }*/
   

        

}   



