using UnityEngine;
using System.Collections;

using UnityEngine.UI;

public class cntrlEntradaDatos : MonoBehaviour 
{
	InputField ipfCampoTexto;
	GameObject DGlobales;
	cntrlDatosGlobales DG;
	
	void Start () 
	{
		DGlobales = GameObject.Find ("DatosGlobales");
		DG=DGlobales.GetComponent<cntrlDatosGlobales> ();
	}
	void Update () 
	{
		
	}
	public void datosIntroducidos ()
	{
		ipfCampoTexto = gameObject.GetComponent<InputField> ();
		Debug.Log (ipfCampoTexto.text);
		DG.sNombre = ipfCampoTexto.text;
	}
}