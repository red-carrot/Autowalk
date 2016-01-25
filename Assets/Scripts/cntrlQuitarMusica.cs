using UnityEngine;
using System.Collections;

public class cntrlQuitarMusica : MonoBehaviour 
{
	GameObject musicaOff;

	void Start ()
	{
		musicaOff = GameObject.Find ("ControlMusicaPrincipio");
		musicaOff.SetActive(false);
	}
}
