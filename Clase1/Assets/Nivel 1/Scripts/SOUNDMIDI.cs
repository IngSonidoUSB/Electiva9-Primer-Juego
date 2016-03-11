using UnityEngine;
using System.Collections;

public class SOUNDMIDI : MonoBehaviour {

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
		StartCoroutine ("Song");

	}

	// Update is called once per frame
	void Update () {
		
	}



	IEnumerator Song ()
	{

		while (true) {
			MidiOut.SendNoteOn (MidiChannel.Ch1, 45, velocity);
			yield return new WaitForSeconds (0.25f);
			MidiOut.SendNoteOn (MidiChannel.Ch1, 57, velocity);
			yield return new WaitForSeconds (0.25f);
			MidiOut.SendNoteOff (MidiChannel.Ch1, 45);
			MidiOut.SendNoteOff (MidiChannel.Ch1, 57);
			MidiOut.SendNoteOn (MidiChannel.Ch1, 59, velocity);
			MidiOut.SendNoteOn (MidiChannel.Ch1, 71, velocity);
			yield return new WaitForSeconds (0.25f);
			MidiOut.SendNoteOff (MidiChannel.Ch1, 59);
			MidiOut.SendNoteOff (MidiChannel.Ch1, 71);
			MidiOut.SendNoteOn (MidiChannel.Ch1, 64, velocity);
			MidiOut.SendNoteOn (MidiChannel.Ch1, 76, velocity);
			yield return new WaitForSeconds (0.25f);
			MidiOut.SendNoteOff (MidiChannel.Ch1, 59);
			MidiOut.SendNoteOff (MidiChannel.Ch1, 71);
			MidiOut.SendNoteOn (MidiChannel.Ch1, 76, velocity);
			yield return new WaitForSeconds (0.25f);
			MidiOut.SendNoteOn (MidiChannel.Ch1, 76, velocity);
			MidiOut.SendNoteOn (MidiChannel.Ch1, 76, velocity);
			yield return new WaitForSeconds (0.25f);
			MidiOut.SendNoteOff (MidiChannel.Ch1, 71);
			MidiOut.SendNoteOn (MidiChannel.Ch1, 76, velocity);
			yield return new WaitForSeconds (0.25f);
			MidiOut.SendNoteOff (MidiChannel.Ch1, 71);
		
		}
	}
}
