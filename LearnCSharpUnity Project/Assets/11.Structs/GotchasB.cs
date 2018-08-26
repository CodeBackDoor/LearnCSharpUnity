//                                  ┌∩┐(◣_◢)┌∩┐
//																				\\
// GotchasB.cs (00/00/0000)														\\
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
	public class GotchasB : MonoBehaviour 
	{
		void Start()
		{
			List<Vector3> coords = new List<Vector3>();
			coords.Add(new Vector3(0, 0, 0));
			coords[0].Set(1, 2, 3);
			//coords[0].x = 4; // error CS1612 (consulte el ejemplo anterior y comente esta línea para compilar)
			Debug.Log(coords[0].ToString());  // Será (0.0, 0.0, 0.0) - ¡No es lo que esperaba!
		}
	}
}