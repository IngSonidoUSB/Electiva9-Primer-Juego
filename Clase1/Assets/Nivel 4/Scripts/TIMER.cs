using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using CnControls;

public class TIMER : MonoBehaviour {

	public Text TimeText;
	public float Tiempo;
	private int Minutos, segundos;
	bool Last= true;
	bool LastGame = true;
	bool LastWin = true;
	AudioSource Audio;
	public static bool GameOv = false ;
	public AudioClip GameO;
	public AudioClip TimeF;
	public AudioClip GameWin;
	public GameObject Cam;
	public GameObject Cat;
	public GameObject SpGog;
	public GameObject SpBird;
	public GameObject SpMap;
	public GameObject Vida1;
	public GameObject Vida2;
	public GameObject Vida3;
	public GameObject Winn;
	AudioSource ACam;
	private Gato ScriptGato;
	public GameObject Game;
	public float InTime;
	private Puntaje_Score ScriptPuntos;
	public int Points = 15;


	void Start () {
		ScriptPuntos = Cat.GetComponent<Puntaje_Score> ();
		Audio = GetComponent<AudioSource>();
		ACam = Cam.GetComponent<AudioSource> ();
		ScriptGato = Cat.GetComponent <Gato>();

		InTime = Tiempo;

	}

	// Update is called once per frame
	void Update () {

		Tiempo -= Time.deltaTime;
		Minutos = (int)Tiempo / 60;
		segundos = (int)Tiempo - (Minutos * 60);
		if (segundos <= 9) {
			TimeText.text = Minutos.ToString () + ":0" + segundos.ToString ();	
		} else {
			TimeText.text = Minutos.ToString () + ":" + segundos.ToString ();
		}
		if (Tiempo <= 0 || ScriptGato.Vidas==0) {
			GameOv = true; 
			Tiempo = 0;
		}

		if ((Tiempo <= 13 && Last) && LastWin) {
			Audio.clip = TimeF;
			Audio.Play ();
			Last = false; 
		}

		if (ScriptPuntos.Value == Points && LastWin){
			Tiempo = 0;
			ACam.Stop ();
			Audio.clip = GameWin;
			Audio.Play ();
			Winn.SetActive (true);
			LastWin = false; 
			SpGog.SetActive (false);
			SpBird.SetActive (false);
			SpMap.SetActive (false);
			Cat.SetActive (false);
		}


		if (GameOv && LastGame && LastWin) {
			ACam.Stop ();
			Audio.clip = GameO;
			Audio.Play ();
			LastGame = false; 
			Game.SetActive (true);
			SpGog.SetActive (false);
			SpBird.SetActive (false);
			SpMap.SetActive (false);
			Cat.SetActive (false);
			if (ScriptGato.Vidas==1){
				Vida1.SetActive (false);
			}
			if (ScriptGato.Vidas == 2) {
				Vida1.SetActive (false);
				Vida2.SetActive (false);
			}
			if (ScriptGato.Vidas == 3) {
				Vida1.SetActive (false);
				Vida2.SetActive (false);
				Vida3.SetActive (false);
			}
		}

		if (GameOv && CnInputManager.GetButtonDown ("Jump") && LastWin) {
			ACam.Play ();
			Audio.clip = GameO;
			Audio.Stop ();
			LastGame = true; 
			Last = true; 
			Game.SetActive (false);
			SpGog.SetActive (true);
			SpBird.SetActive (true);
			SpMap.SetActive (true);
			Cat.SetActive (true);
			Tiempo = InTime;
			GameOv = false;
			Vida1.SetActive (true);
			Vida2.SetActive (true);
			Vida3.SetActive (true);
			ScriptGato.Vidas = 3;
			ScriptPuntos.Value = 0;
			Cat.transform.position = new Vector3 (-0.28f, 2.3f, 5);
		}


	}

	void GameOver() {
		print ("GameOver");
	}
}
