using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Puntaje : MonoBehaviour
{
    public bool loatrapo = false;
    

    public Text Score;
    private int Value = 0;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
		Score.text = "= " + Value.ToString();
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Mariposa")
        {
            Value++;
        }
    }
}