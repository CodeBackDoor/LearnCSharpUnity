//                                  ┌∩┐(◣_◢)┌∩┐
//																				\\
// DictionaryExamples.cs (00/00/0000)											\\
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
	public class DictionaryExamples : MonoBehaviour 
	{
		public Dictionary<string, int> stats = new Dictionary<string, int>();

		void Start()
		{
			stats.Add("HP", 10);
			stats.Add("MP", 3);
			stats.Remove("MP");
			if (stats.ContainsKey("HP")) Debug.Log(string.Format("Tienes {0} puntos de golpe restantes", stats["HP"]));
		}
	}
}