using UnityEngine;
using System.Collections;

public class fondo_c : MonoBehaviour
{

    public MidiChannel channel = MidiChannel.Ch1;
    public int noteNumber = 48;
    public float velocity = 0.7f;
    public float delay = 2.0f;
    public float length = 0.1f;
    public float interval = 1.0f;
    public bool sendnote = false;


    // Use this for initialization
    void Start()
    {
        MidiBridge.instance.Warmup();

        sendnote = true;
        StartCoroutine("Song");
   
    }

    // Update is called once per frame
    void Update()
    {


    }

 
    IEnumerator Song()
    {

        while (true)
        {


            MidiOut.SendNoteOn(channel, 45, velocity);
            MidiOut.SendNoteOn(channel, 65, velocity);
            MidiOut.SendNoteOn(channel, 32, velocity);
            yield return new WaitForSeconds(0.55f);
            MidiOut.SendNoteOff(channel, 45);
             MidiOut.SendNoteOff (channel, 65);
            MidiOut.SendNoteOff(channel, 32);
            MidiOut.SendNoteOn(channel, 45, velocity);
            MidiOut.SendNoteOn(channel, 75, velocity);
            yield return new WaitForSeconds(0.55f);
            MidiOut.SendNoteOff(channel, 45);
            MidiOut.SendNoteOff(channel, 75);
            MidiOut.SendNoteOn(channel, 52, velocity);
            MidiOut.SendNoteOn(channel, 60, velocity);
            yield return new WaitForSeconds(0.55f);
            MidiOut.SendNoteOff(channel, 52);
            MidiOut.SendNoteOff(channel, 60);
            MidiOut.SendNoteOn(channel, 60, velocity);
            yield return new WaitForSeconds(0.65f);
            MidiOut.SendNoteOff(channel, 60);
            MidiOut.SendNoteOn(channel, 52, velocity);
            MidiOut.SendNoteOn(channel, 62, velocity);
            yield return new WaitForSeconds(0.65f);
            MidiOut.SendNoteOff(channel, 52);
            MidiOut.SendNoteOff(channel, 62);
            MidiOut.SendNoteOn(channel, 53, velocity);
            MidiOut.SendNoteOn(channel, 32, velocity);
            yield return new WaitForSeconds(0.65f);
            MidiOut.SendNoteOff(channel, 53);
            MidiOut.SendNoteOff(channel, 32);
            MidiOut.SendNoteOn(channel, 52, velocity);
            MidiOut.SendNoteOn(channel, 60, velocity);
            yield return new WaitForSeconds(0.65f);
            MidiOut.SendNoteOff(channel, 52);
            MidiOut.SendNoteOff(channel, 60);
            MidiOut.SendNoteOn(channel, 45, velocity);
            yield return new WaitForSeconds(0.55f);
            MidiOut.SendNoteOff(channel, 45);
            MidiOut.SendNoteOn(channel, 52, velocity);
            yield return new WaitForSeconds(0.55f);
            MidiOut.SendNoteOff(channel, 52);

            MidiOut.SendNoteOn(channel, 53, velocity);
            MidiOut.SendNoteOn(channel, 32, velocity);
            yield return new WaitForSeconds(0.375f);
            MidiOut.SendNoteOff(channel, 53);
            MidiOut.SendNoteOff(channel, 32);
            MidiOut.SendNoteOn(channel, 52, velocity);
            yield return new WaitForSeconds(0.375f);
            MidiOut.SendNoteOff(channel, 52);
            MidiOut.SendNoteOn(channel, 60, velocity);
            yield return new WaitForSeconds(0.475f);
            MidiOut.SendNoteOff(channel, 60);
            MidiOut.SendNoteOn(channel, 52, velocity);
            yield return new WaitForSeconds(0.575f);
            MidiOut.SendNoteOff(channel, 52);
            MidiOut.SendNoteOn(channel, 53, velocity);
            MidiOut.SendNoteOn(channel, 32, velocity);
            yield return new WaitForSeconds(0.75f);
            MidiOut.SendNoteOff(channel, 53);
            MidiOut.SendNoteOff(channel, 32);

            MidiOut.SendNoteOn(channel, 44, velocity);
            // MidiOut.SendNoteOn(channel, 45, velocity);
            yield return new WaitForSeconds(0.55f);
            MidiOut.SendNoteOff(channel, 44);
            // MidiOut.SendNoteOff (channel, 45);
            MidiOut.SendNoteOn(channel, 47, velocity);
            //  MidiOut.SendNoteOn(channel, 53, velocity);
            yield return new WaitForSeconds(0.55f);
            MidiOut.SendNoteOff(channel, 47);
            //  MidiOut.SendNoteOff(channel, 53);
            MidiOut.SendNoteOn(channel, 51, velocity);
            // MidiOut.SendNoteOn(channel, 60, velocity);
            yield return new WaitForSeconds(0.55f);
            MidiOut.SendNoteOff(channel, 51);
            //  MidiOut.SendNoteOff(channel, 60);
            MidiOut.SendNoteOn(channel, 47, velocity);
            yield return new WaitForSeconds(0.65f);
            MidiOut.SendNoteOff(channel, 47);
            MidiOut.SendNoteOn(channel,56, velocity);
            yield return new WaitForSeconds(0.65f);
            MidiOut.SendNoteOff(channel, 56);
            MidiOut.SendNoteOn(channel, 47, velocity);
            yield return new WaitForSeconds(0.25f);
            MidiOut.SendNoteOff(channel, 47);
            MidiOut.SendNoteOn(channel, 51, velocity);
            yield return new WaitForSeconds(0.45f);
            MidiOut.SendNoteOff(channel, 51);
            MidiOut.SendNoteOn(channel, 47, velocity);
            yield return new WaitForSeconds(0.35f);
            MidiOut.SendNoteOff(channel, 47);
            MidiOut.SendNoteOn(channel, 44, velocity);
            yield return new WaitForSeconds(0.25f);
            MidiOut.SendNoteOff(channel, 44);

            MidiOut.SendNoteOn(channel, 47, velocity);
            MidiOut.SendNoteOn(channel, 32, velocity);
            yield return new WaitForSeconds(0.375f);
            MidiOut.SendNoteOff(channel, 47);
            MidiOut.SendNoteOff(channel, 32);
            MidiOut.SendNoteOn(channel, 51, velocity);
            yield return new WaitForSeconds(0.375f);
            MidiOut.SendNoteOff(channel, 51);
            MidiOut.SendNoteOn(channel, 47, velocity);
            yield return new WaitForSeconds(0.475f);
            MidiOut.SendNoteOff(channel, 47);
            MidiOut.SendNoteOn(channel, 56, velocity);
            yield return new WaitForSeconds(0.575f);
            MidiOut.SendNoteOff(channel, 56);
            MidiOut.SendNoteOn(channel, 47, velocity);
            yield return new WaitForSeconds(0.75f);
            MidiOut.SendNoteOff(channel, 47);

            MidiOut.SendNoteOn(channel, 51, velocity);
            // MidiOut.SendNoteOn(channel, 45, velocity);
            yield return new WaitForSeconds(0.55f);
            MidiOut.SendNoteOff(channel, 51);
            // MidiOut.SendNoteOff (channel, 45);
            MidiOut.SendNoteOn(channel, 47, velocity);
            //  MidiOut.SendNoteOn(channel, 53, velocity);
            yield return new WaitForSeconds(0.55f);
            MidiOut.SendNoteOff(channel, 47);
            //  MidiOut.SendNoteOff(channel, 53);
            MidiOut.SendNoteOn(channel, 45, velocity);
            MidiOut.SendNoteOn(channel, 65, velocity);
            MidiOut.SendNoteOn(channel, 32, velocity);
            // MidiOut.SendNoteOn(channel, 60, velocity);
            yield return new WaitForSeconds(0.45f);
            MidiOut.SendNoteOff(channel, 45);
            MidiOut.SendNoteOff(channel, 55);
            MidiOut.SendNoteOff(channel, 32);
            //  MidiOut.SendNoteOff(channel, 60);
            MidiOut.SendNoteOn(channel, 53, velocity);
            yield return new WaitForSeconds(0.45f);
            MidiOut.SendNoteOff(channel, 53);
            MidiOut.SendNoteOn(channel, 52, velocity);
            yield return new WaitForSeconds(0.35f);
            MidiOut.SendNoteOff(channel, 52);
            MidiOut.SendNoteOn(channel, 60, velocity);
            yield return new WaitForSeconds(0.35f);
            MidiOut.SendNoteOff(channel, 60);
            MidiOut.SendNoteOn(channel, 52, velocity);
            yield return new WaitForSeconds(0.25f);
            MidiOut.SendNoteOff(channel, 52);
            MidiOut.SendNoteOn(channel, 53, velocity);
            MidiOut.SendNoteOn(channel, 32, velocity);
            yield return new WaitForSeconds(0.25f);
            MidiOut.SendNoteOff(channel,53);
            MidiOut.SendNoteOff(channel, 32);
            MidiOut.SendNoteOn(channel, 52, velocity);
            yield return new WaitForSeconds(0.25f);
            MidiOut.SendNoteOff(channel, 52);

            MidiOut.SendNoteOn(channel, 45, velocity);
            MidiOut.SendNoteOn(channel, 65, velocity);
            MidiOut.SendNoteOn(channel, 32, velocity);
            yield return new WaitForSeconds(0.375f);
            MidiOut.SendNoteOff(channel, 45);
            MidiOut.SendNoteOff(channel, 65);
            MidiOut.SendNoteOn(channel, 52, velocity);
            yield return new WaitForSeconds(0.375f);
            MidiOut.SendNoteOff(channel, 52);
            MidiOut.SendNoteOn(channel, 53, velocity);
            yield return new WaitForSeconds(0.475f);
            MidiOut.SendNoteOff(channel, 53);
            MidiOut.SendNoteOn(channel, 52, velocity);
            yield return new WaitForSeconds(0.575f);
            MidiOut.SendNoteOff(channel, 52);
            MidiOut.SendNoteOn(channel, 60, velocity);
            yield return new WaitForSeconds(0.75f);
            MidiOut.SendNoteOff(channel, 60);

            MidiOut.SendNoteOn(channel, 45, velocity);
            MidiOut.SendNoteOn(channel, 65, velocity);
            MidiOut.SendNoteOn(channel, 32, velocity);
            yield return new WaitForSeconds(0.35f);
            MidiOut.SendNoteOff(channel, 45);
            MidiOut.SendNoteOff(channel, 65);
            MidiOut.SendNoteOff(channel, 32);
            MidiOut.SendNoteOn(channel, 45, velocity);
            MidiOut.SendNoteOn(channel, 75, velocity);
            yield return new WaitForSeconds(0.35f);
            MidiOut.SendNoteOff(channel, 45);
            MidiOut.SendNoteOff(channel, 75);
            MidiOut.SendNoteOn(channel, 52, velocity);
            MidiOut.SendNoteOn(channel, 60, velocity);
            yield return new WaitForSeconds(0.35f);
            MidiOut.SendNoteOff(channel, 52);
            MidiOut.SendNoteOff(channel, 60);
            MidiOut.SendNoteOn(channel, 60, velocity);
            yield return new WaitForSeconds(0.55f);
            MidiOut.SendNoteOff(channel, 60);
            MidiOut.SendNoteOn(channel, 52, velocity);
            MidiOut.SendNoteOn(channel, 62, velocity);
            yield return new WaitForSeconds(0.55f);
            MidiOut.SendNoteOff(channel, 52);
            MidiOut.SendNoteOff(channel, 62);
            MidiOut.SendNoteOn(channel, 53, velocity);
            MidiOut.SendNoteOn(channel, 32, velocity);
            yield return new WaitForSeconds(0.55f);
            MidiOut.SendNoteOff(channel, 53);
            MidiOut.SendNoteOff(channel, 32);
            MidiOut.SendNoteOn(channel, 52, velocity);
            MidiOut.SendNoteOn(channel, 60, velocity);
            yield return new WaitForSeconds(0.55f);
            MidiOut.SendNoteOff(channel, 52);
            MidiOut.SendNoteOff(channel, 60);
            MidiOut.SendNoteOn(channel, 45, velocity);
            yield return new WaitForSeconds(0.35f);
            MidiOut.SendNoteOff(channel, 45);
            MidiOut.SendNoteOn(channel, 52, velocity);
            yield return new WaitForSeconds(0.35f);
            MidiOut.SendNoteOff(channel, 52);

            MidiOut.SendNoteOn(channel, 53, velocity);
            MidiOut.SendNoteOn(channel, 32, velocity);
            yield return new WaitForSeconds(0.275f);
            MidiOut.SendNoteOff(channel, 53);
            MidiOut.SendNoteOff(channel, 32);
            MidiOut.SendNoteOn(channel, 52, velocity);
            yield return new WaitForSeconds(0.275f);
            MidiOut.SendNoteOff(channel, 52);
            MidiOut.SendNoteOn(channel, 60, velocity);
            yield return new WaitForSeconds(0.375f);
            MidiOut.SendNoteOff(channel, 60);
            MidiOut.SendNoteOn(channel, 52, velocity);
            yield return new WaitForSeconds(0.475f);
            MidiOut.SendNoteOff(channel, 52);
            MidiOut.SendNoteOn(channel, 53, velocity);
            MidiOut.SendNoteOn(channel, 32, velocity);
            yield return new WaitForSeconds(0.65f);
            MidiOut.SendNoteOff(channel, 53);
            MidiOut.SendNoteOff(channel, 32);


        }
    }

}