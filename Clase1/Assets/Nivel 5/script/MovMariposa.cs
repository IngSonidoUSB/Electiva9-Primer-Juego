using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MovMariposa : MonoBehaviour
{
    public float addxPos;
    public float CurveSpeed = 0.5f ;
    private float incre = 1f;
    private bool posicion=false;
    float fTime = 0;
    Vector3 vLastPos = Vector3.zero;
    float fallSpeed = 3 * Time.deltaTime;

    // Use this for initialization
    void Start()
    {

        posicion = true;

    }

    // Update is called once per frame
    void Update()
    {

        transform.position -= new Vector3(0, fallSpeed, 0);

        // incre = incre + 1f;
        //posicion = true;

        derecha();
        transform.position -= new Vector3(0,(0.1f*Time.deltaTime), 0);

    }


    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "pisodestruir")
        {
            //print ("Works");
            Destroy(this.gameObject);
        }
    }

    void derecha()
    {
        if (posicion == false)
        {

            vLastPos = transform.position;

            fTime += Time.deltaTime * CurveSpeed;

            Vector3 vSin = new Vector3(1f, 0, 0)*fTime;
            transform.position -= (vSin) * Time.deltaTime;
            posicion = true;

        }
        else if (posicion ==true) {
            vLastPos = transform.position;

            fTime += Time.deltaTime * CurveSpeed;
            Vector3 vSin = new Vector3(1f, 0, 0)*fTime;
            transform.position += (vSin) * Time.deltaTime;
            posicion = false;
        }

    }

}
