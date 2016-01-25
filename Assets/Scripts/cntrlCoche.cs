using UnityEngine;
using System.Collections;

public class cntrlCoche : MonoBehaviour 
{
	void OnCollisionEnter (Collision coli)
	{
		if (coli.gameObject.CompareTag("Player"))
		{
			Debug.Log ("PERDOOON");
		}
	}
}