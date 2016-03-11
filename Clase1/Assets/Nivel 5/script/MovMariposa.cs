using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MovMariposa : MonoBehaviour
{
    public float addxPos;
    float fallSpeed = 2 * Time.deltaTime;

    // Use this for initialization
    void Start()
    {



    }

    // Update is called once per frame
    void Update()
    {

        addxPos = 0.05f*Mathf.Sin((16* (0.3f*Time.time)));

        transform.position =transform.position - new Vector3(addxPos, fallSpeed, 0);
        
    }


    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "pisodestruir")
        {
            //print ("Works");
            Destroy(this.gameObject);
        }
    }

  
}
