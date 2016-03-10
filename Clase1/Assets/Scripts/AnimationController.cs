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

	
		Jump ();
	}



	void Jump () {
		if (CnInputManager.GetButtonDown ("Jump")) {
			
			StartCoroutine ("JumpStop");
		} 
	}

	IEnumerator JumpStop (){
		animator.SetInteger ("Jump", 2);
		yield return new WaitForSeconds (1);
		animator.SetInteger ("Jump", 0);
	}
}
