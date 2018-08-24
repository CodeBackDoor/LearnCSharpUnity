//                                  ┌∩┐(◣_◢)┌∩┐
//																				\\
// Corrutinas.cs (00/00/0000)													\\
// Autor: Antonio Mateo (.\Moon Antonio) 	antoniomt.moon@gmail.com			\\
// Descripcion:																	\\
// Fecha Mod:		00/00/0000													\\
// Ultima Mod:																	\\
//******************************************************************************\\

#region Librerias
using UnityEngine;
using System.Collections;
#endregion

namespace MoonAntonio
{
	public class Corrutinas : MonoBehaviour 
	{
		public Vector3[] waypoints;
		public float speed;

		void OnEnable()
		{
			StartCoroutine(DoStuff());
		}

		IEnumerator DoStuff()
		{
			for (int i = 0; i < waypoints.Length; ++i)
			{
				while (transform.position != waypoints[i])
				{
					yield return null;
					transform.position = Vector3.MoveTowards(transform.position, waypoints[i], speed * Time.deltaTime);
				}
			}
			Debug.Log("Completado!");
		}
	}
}