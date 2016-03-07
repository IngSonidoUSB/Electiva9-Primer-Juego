using UnityEngine;
using System.Collections;

public class vidas : MonoBehaviour
{
    public int VIDAS = 3;
    public bool SeEstrello = false;
    private bool anterior=false;
    // Use this for initialization

    void Start()
    {
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

            }

            if (VIDAS == 1)
            {
                Destroy(GameObject.FindWithTag("vida2"));
            }
            if (VIDAS == 0)
            {
                Destroy(GameObject.FindWithTag("vida1"));
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



