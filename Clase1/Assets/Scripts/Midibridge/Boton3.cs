using UnityEngine;
using System.Collections;

public class Boton3 : MonoBehaviour {

	public MidiChannel channel = MidiChannel.Ch1;
	public int noteNumber = 48;
	public float velocity = 0.7f;
	public float delay = 2.0f;
	public float length = 0.1f;
	public float interval = 1.0f;
	public bool sendnote = false;
	// Use this for initialization
	void Start () {
		MidiBridge.instance.Warmup ();
		//StartCoroutine (Song ());
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetMouseButtonDown (0) && sendnote==true){
			renderer.material.color = Color.green;
			StartCoroutine ("Song");
		}
		if (Input.GetMouseButtonUp (0) && sendnote==true){
			renderer.material.color = Color.white;
			//StopAllCoroutines();
			StopCoroutine ("Song");
		}
		
	}
	
	void OnMouseEnter() {
		
		sendnote = true;
	}
	
	void OnMouseExit() {
		
		sendnote = false;
	}

	IEnumerator Song ()
	{

		while (true) {
			MidiOut.SendNoteOn (channel, 45, velocity);
			MidiOut.SendNoteOn (channel, 57, velocity);
			yield return new WaitForSeconds (0.25f);
			//MidiOut.SendNoteOff (channel, 45);
			//MidiOut.SendNoteOff (channel, 57);
			MidiOut.SendNoteOn (channel, 59, velocity);
			MidiOut.SendNoteOn (channel, 71, velocity);
			yield return new WaitForSeconds (0.25f);
			MidiOut.SendNoteOff (channel, 59);
			MidiOut.SendNoteOff (channel, 71);
			MidiOut.SendNoteOn (channel, 64, velocity);
			MidiOut.SendNoteOn (channel, 76, velocity);
			yield return new WaitForSeconds (0.25f);
			MidiOut.SendNoteOff (channel, 64);
			MidiOut.SendNoteOff (channel, 76);
			MidiOut.SendNoteOn (channel, 48, velocity);
			yield return new WaitForSeconds (0.25f);
			MidiOut.SendNoteOff (channel, 48);
			MidiOut.SendNoteOn (channel, 59, velocity);
			yield return new WaitForSeconds (0.25f);
			MidiOut.SendNoteOff (channel, 59);
			MidiOut.SendNoteOn (channel, 64, velocity);
			yield return new WaitForSeconds (0.25f);
			MidiOut.SendNoteOff (channel, 64);
			MidiOut.SendNoteOn (channel, 45, velocity);
			yield return new WaitForSeconds (0.25f);
			MidiOut.SendNoteOff (channel, 45);
			MidiOut.SendNoteOn (channel, 59, velocity);
			yield return new WaitForSeconds (0.25f);
			MidiOut.SendNoteOff (channel, 59);
			MidiOut.SendNoteOn (channel, 64, velocity);
			yield return new WaitForSeconds (0.25f);
			MidiOut.SendNoteOff (channel, 64);
			
			MidiOut.SendNoteOn (channel, 40, velocity);
			yield return new WaitForSeconds (0.375f);
			MidiOut.SendNoteOff (channel, 40);
			MidiOut.SendNoteOn (channel, 64, velocity);
			yield return new WaitForSeconds (0.375f);
			MidiOut.SendNoteOff (channel, 64);
			MidiOut.SendNoteOn (channel, 52, velocity);
			yield return new WaitForSeconds (0.375f);
			MidiOut.SendNoteOff (channel, 52);
			MidiOut.SendNoteOn (channel, 55, velocity);
			yield return new WaitForSeconds (0.375f);
			MidiOut.SendNoteOff (channel, 55);
			MidiOut.SendNoteOn (channel, 59, velocity);
			yield return new WaitForSeconds (0.75f);
			MidiOut.SendNoteOff (channel, 50);
			
		}
	}
}
