//                                  ┌∩┐(◣_◢)┌∩┐
//																				\\
// Polimorfismo.cs (00/00/0000)													\\
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
	public class Polimorfismo : MonoBehaviour 
	{
		void Start()
		{
			List<System.Object> myList = new List<System.Object>();
			myList.Add("Hola Mundo!");
			myList.Add(42);
			myList.Add(Camera.main);
			for (int i = 0; i < myList.Count; ++i)
				Debug.Log(i + ": " + myList[i].ToString());
		}
	}
}