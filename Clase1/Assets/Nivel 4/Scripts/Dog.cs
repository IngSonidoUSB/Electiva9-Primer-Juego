using UnityEngine;
using System.Collections;

public class Dog : MonoBehaviour {

	public GameObject[] DogPos;
	public float[] DogMax;
	public float[] DogMin;
	public float Vel;
	public float Posy;
	int pp;
	bool pmax;

	void Start () {
		Vel = 5;
		pp = Random.Range(1,3);
		pmax = true;
		Vector3 NewPos = DogPos[pp-1].transform.position;
		NewPos.y = Posy;
		transform.position = NewPos;

	}

	// Update is called once per frame
	void Update () {

		if (transform.position.x < DogMax [0] && pp <= 1 && pmax == true) {
			transform.position = transform.position + new Vector3 (Time.deltaTime * Vel, 0, 0);
			transform.localEulerAngles = new Vector3 (0, 180, 0);
		} else if (pp == 1) {
			transform.position = transform.position + new Vector3 (Time.deltaTime * -Vel, 0, 0);
			transform.localEulerAngles = new Vector3 (0, 0, 0);
			pmax = false;
			if(transform.position.x < DogMin [0]) {
				Destroy (gameObject);
			}
		}



		if (transform.position.x > DogMax [1] && pp >= 2 && pmax == true) {
			transform.position = transform.position + new Vector3 (-Time.deltaTime * Vel, 0, 0);
			transform.localEulerAngles = new Vector3 (0, 0, 0);
		} else if ( pp == 2) {
			transform.position = transform.position + new Vector3 (Time.deltaTime * Vel, 0, 0);
			pmax = false;
			transform.localEulerAngles = new Vector3 (0, 180, 0);
			if(transform.position.x > DogMin [1]) {
				Destroy (gameObject);
			}
		}
			

	}
		
}
