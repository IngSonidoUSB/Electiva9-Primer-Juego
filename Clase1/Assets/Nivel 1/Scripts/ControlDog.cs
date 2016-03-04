using UnityEngine;
using System.Collections;

public class ControlDog : MonoBehaviour {
	public float vel=-3f;
	//AudioSource Audio;
	public AudioClip ladrar;
	Rigidbody2D doggy;
	//Animator Animh;

	 

	// Use this for initialization
	void Start () {
		doggy=(Rigidbody2D)GetComponent<Rigidbody2D>();
		//Animh=GetComponent<Animator>();
		//Audio = GetComponent<AudioSource> ();

	}
	// Update is called once per frame
	void FixedUpdate () {
		Vector2 v = new Vector2 (vel, 0);
		doggy.velocity = v;

	}

	void OnTriggerEnter2D(Collider2D other) {


		if(other.gameObject.name.Equals ("limitdog1") || other.gameObject.name.Equals ("limitdog2")){
			Flip ();
		}
	}


	void Flip(){
		vel = vel * (-1);
		var s = transform.localScale;
		s.x = s.x * (-1);
		transform.localScale = s;

	}






}






