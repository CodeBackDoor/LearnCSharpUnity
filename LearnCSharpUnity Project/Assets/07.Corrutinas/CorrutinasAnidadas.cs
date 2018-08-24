//                                  ┌∩┐(◣_◢)┌∩┐
//																				\\
// CorrutinasAnidadas.cs (00/00/0000)											\\
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
	public class CorrutinasAnidadas : MonoBehaviour 
	{
		Vector3 m1 = new Vector3(-1, 0, 0);
		Vector3 m2 = new Vector3(1, 0, 0);
		Vector3 s1 = new Vector3(1, 1, 1);
		Vector3 s2 = new Vector3(0.5f, 0.5f, 0.5f);

		void Start()
		{
			StartCoroutine(DoStuff());
		}

		IEnumerator DoStuff()
		{
			while (true)
			{
				switch (UnityEngine.Random.Range(0, 2))
				{
					case 0:
						yield return StartCoroutine(Move());
						break;
					case 1:
						yield return StartCoroutine(Scale());
						break;
				}
			}
		}

		IEnumerator Move()
		{
			Vector3 target = transform.position == m1 ? m2 : m1;
			while (transform.position != target)
			{
				yield return null;
				transform.position = Vector3.MoveTowards(transform.position, target, Time.deltaTime);
			}
		}

		IEnumerator Scale()
		{
			Vector3 target = transform.localScale == s1 ? s2 : s1;
			while (transform.localScale != target)
			{
				yield return null;
				transform.localScale = Vector3.MoveTowards(transform.localScale, target, Time.deltaTime);
			}
		}
	}
}