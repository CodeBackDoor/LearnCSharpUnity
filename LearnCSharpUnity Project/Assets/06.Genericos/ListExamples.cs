//                                  ┌∩┐(◣_◢)┌∩┐
//																				\\
// ListExamples.cs (00/00/0000)													\\
// Autor: Antonio Mateo (.\Moon Antonio) 	antoniomt.moon@gmail.com			\\
// Descripcion:																	\\
// Fecha Mod:		00/00/0000													\\
// Ultima Mod:																	\\
//******************************************************************************\\

#region Librerias
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
#endregion

namespace MoonAntonio
{
	public class ListExamples : MonoBehaviour 
	{
		public List<int> indices = new List<int>();

		void Start()
		{
			for (int i = 0; i < 10; ++i)
			{
				int index = UnityEngine.Random.Range(0, 10);
				Debug.Log("Agregada entrada: " + index);
				indices.Add(index);
			}

			if (indices.Contains(3))
			{
				Debug.Log("Eliminada entrada.");
				indices.Remove(3);
			}

			indices.Sort();
			Debug.Log("Entradas ordenadas ... Ahora:");

			for (int i = 0; i < indices.Count; ++i)
			{
				int index = indices[i];
				Debug.Log(string.Format("i: " + index));
			}
		}
	}
}