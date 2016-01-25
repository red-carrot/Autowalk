using UnityEngine;
using System.Collections;

public class cntrlProta : MonoBehaviour 
{	
	void Update () 
	{
		Animator anim = GetComponent<Animator> () as Animator; /*definimos el nombre de la variable animator
		                                                        y despues le asignamos el componente de animator
		                                                        buscandolo, y luego, por si no fuera animator
		                                                        le decimos expresamente que es un animator*/
		int direc; /*definimos la variable int y la nombramos como direc*/
		bool caminando = false;
		float _x, _y;/*creamos un par de floats y los nombramos para saber cuanto se van a desplazar en cada 
					 direccion, despues le daremos los valores, o algo */

		_x = Input.GetAxis ("Horizontal"); /*asignamos a _x el valor del eje horizontal*/
		_y = Input.GetAxis ("Vertical"); /*y ahora le asignamos a _y el valor del eje vertical*/

		direc = anim.GetInteger ("direc");/*recogemos el valor direc de nuestro animator*/

		if (_x > 0) /*y aqui le decimos que si _x es mayor que 0 tiene que ir a la puta derecha*/
		{
			direc = 2; /*derecha se corresponde con el valor 2*/
			caminando=true; /*cambiamos caminando a true para que cambie el valor en "andando" a true
							y asi puto ande de una jodida vez*/
		} 
		else if (_x < 0) /*sino, si _x es menor que 0, tonces coje pa su puta izquierda*/
		{
			direc = 3; /*izquierda se correcponde con 3 (se mira en el int que he hecho antes para las animaciones*/
			caminando=true;
		}

		if (_y > 0) /*aqui es un copypaste de _x, pero adaptando los valores al eje vertical*/
		{
			direc = 1;/*1 es arriba*/
			caminando=true;
		} 
		else if (_y < 0) 
		{
			direc = 0; /*y 0 abajo*/
			caminando=true;
		}

		anim.SetInteger ("direc", direc); /*aqui devolvemos el valor de direc al animator*/
		anim.SetBool ("andando", caminando); /*y aqui lo mismo con andando*/

		transform.Translate (new Vector3 (_x*8,_y*6, 0)*Time.deltaTime);
	}
}