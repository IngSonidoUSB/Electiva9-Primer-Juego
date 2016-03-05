using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Pajaromov : MonoBehaviour {

	public Text Score; 

	private int ba=1;
	private float vely = 0;


	// Update is called once per frame
	void Update () {
		if (ba==1){
		vely = Random.Range (-5f, 3f) * Time.deltaTime;
			ba = 0;
		}
		float velx = 4 * Time.deltaTime;

		transform.position -= new Vector3 (velx, vely, 0);
		//Score.text = Puntaje.ToString ();


	}
	void OnTriggerEnter2D(Collider2D other) 
	{
		if( other.gameObject.name.Equals ("top")||other.gameObject.name.Equals ("izquierda")||other.gameObject.name.Equals ("derecha")||other.gameObject.name.Equals ("bot")){
			Destroy (this.gameObject);
		}

	}


}
