using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class cntrlPopUp : MonoBehaviour 
{
	public GameObject texto, resA, resB, resC, resD;


	void Start ()
	{
		Text _texto = texto.GetComponent<Text> () as Text;
		_texto.text = "¿Por donde tienes que ir de una acera a otra?";

		botonGest b = resA.GetComponent<botonGest> () as botonGest;
		b.config ("Por el paso de zebra", true);

		b = resB.GetComponent<botonGest> () as botonGest;
		b.config ("Por cualquier sitio", false);

		b = resC.GetComponent<botonGest> () as botonGest;
		b.config ("Por encima de los coches", false);

		b = resD.GetComponent<botonGest> () as botonGest;
		b.config ("Por DEBAJO de los coches!", false);
	}
}