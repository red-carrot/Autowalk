using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class cntrlUI : MonoBehaviour 
{
	public Text tUi;
	GameObject DatosGlobales;
	cntrlDatosGlobales cDG;

	void Start ()
	{
		DatosGlobales = GameObject.Find ("DatosGlobales");
		cDG = DatosGlobales.GetComponent<cntrlDatosGlobales>();
	}

	void Update ()
	{
		tUi.text = (cDG.sNombre + " x " +  cDG.iPuntos);
	}
}