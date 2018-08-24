//                                  ┌∩┐(◣_◢)┌∩┐
//																				\\
// UnityCorrutinas.cs (00/00/0000)												\\
// Autor: Antonio Mateo (.\Moon Antonio) 	antoniomt.moon@gmail.com			\\
// Descripcion:																	\\
// Fecha Mod:		00/00/0000													\\
// Ultima Mod:																	\\
//******************************************************************************\\

#region Librerias
using System.Collections;
using UnityEngine;
#endregion

namespace MoonAntonio
{
	public class UnityCorrutinas : MonoBehaviour 
	{
		void OnEnable()
		{
			StartCoroutine("DoStuff");
		}

		void OnDisable()
		{
			StopCoroutine("DoStuff");
		}

		IEnumerator DoStuff()
		{
			int value = 0;
			while (true)
			{
				yield return new WaitForSeconds(1);
				value++;
				Debug.Log("Valor:" + value);
			}
		}
	}
}