using UnityEngine;
using System.Collections;

public class cntrlTrigersPreguntas : MonoBehaviour 
{
	public GameObject gPregunta;

	void Start ()
	{
		gPregunta.SetActive(false);
	}

	void OnCollisionEnter2D (Collision2D coli)
	{
		if (coli.gameObject.tag == "Player")
		{
			Debug.Log("Prota pass");
			gPregunta.SetActive(true);
		}
	}
}