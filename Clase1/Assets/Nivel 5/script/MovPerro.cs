using UnityEngine;
using System.Collections;

public class MovPerro : MonoBehaviour {
    private int Dir;
    // Use this for initialization
    void Start () {
        Dir = -1;
        transform.localScale = new Vector3(Dir*2f, 2f, 2f);
    }
	
	// Update is called once per frame
	void Update () {

        float fallSpeed = 2 * Time.deltaTime;
        transform.position -= new Vector3(fallSpeed, 0, 0);

    }
}
