using UnityEngine;
using System.Collections;
using CnControls;

public class AnimationController : MonoBehaviour {


	private Animator animator;
	private int Dir;
	// Use this for initialization
	void Start () {
		
		animator = this.GetComponent<Animator> ();
	}

	// Update is called once per frame
	void Update () {

		Direction ();
	}


	void Direction () {
		if (CnInputManager.GetAxis("Horizontal") > 0)
			{
			Dir = -1;
			//animator.SetBool ("Direction", true);
			transform.localScale =new Vector3(Dir*0.7f, 0.7f, 1);
			//print ("wroks");
		}
		if (CnInputManager.GetAxis("Horizontal") < 0){
			Dir = 1;
			transform.localScale =new Vector3(Dir*0.7f, 0.7f, 1);
		}
	}
}
