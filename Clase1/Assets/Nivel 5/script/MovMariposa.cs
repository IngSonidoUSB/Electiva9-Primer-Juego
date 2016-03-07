using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MovMariposa : MonoBehaviour {
    public float addxPos;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        //Mathf.Sin(2*Time.time);
        float fallSpeed = 3* Time.deltaTime;

       //addxPos =  (Mathf.Sin(((2*3.1416f)/0.5f)*(Time.deltaTime)));
            transform.position -= new Vector3(0, fallSpeed, 0);
         //transform.position+= new Vector3(addxPos, 0, 0);

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
