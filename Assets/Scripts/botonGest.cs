using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class botonGest : MonoBehaviour 
{
	public GameObject texto;
	private bool correcta;

	GameObject DatosGlobales;
	cntrlDatosGlobales cDG;

	public void config (string _texto, bool correct)
	{
		Text t = texto.GetComponent<Text> () as Text;
		t.text = _texto;
		correcta = correct;
	}

	void Start ()
	{
		DatosGlobales = GameObject.Find("DatosGlobales");
		cDG = DatosGlobales.GetComponent<cntrlDatosGlobales>();
	}
}
