using UnityEngine;
using System.Collections;

public class cntrlDatosGlobales : MonoBehaviour 
{
	public string sNombre;
	public int iPantallaActual;
	public int iPuntos;

	void Start () 
	{
		DontDestroyOnLoad (this);
		sNombre = ("");
		iPuntos = 0; 
	}

}
