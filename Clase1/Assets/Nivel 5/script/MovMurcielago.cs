using UnityEngine;
using System.Collections;

public class MovMurcielago : MonoBehaviour {

    private int Dir;
    // Use this for initialization
    void Start () {
        Dir = -1;
        transform.localScale = new Vector3(Dir,1, 1);
    }
	
	// Update is called once per frame
	void Update () {

        float fallSpeed = 2 * Time.deltaTime;
        transform.position += new Vector3(fallSpeed, 0, 0);


    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Mariposa")
        {
            //print ("Works");
            Destroy(col.gameObject);
        }
    }

}
