using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Puntaje : MonoBehaviour
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

        if (Value >= 0)
        {
            Value = Value;
        }
        else if (Value<0) {
            Value = 0;
        }

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
        }
    }


}