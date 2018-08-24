//                                  ┌∩┐(◣_◢)┌∩┐
//																				\\
// CorrutinaNativa.cs (00/00/0000)												\\
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
	public class CorrutinaNativa : MonoBehaviour 
	{
		IEnumerator trend;

		void Start()
		{
			trend = TrendLine();
		}

		void Update()
		{
			if (trend.MoveNext())
				Debug.Log((int)trend.Current);
		}

		IEnumerator TrendLine()
		{
			int value = 0;
			while (true)
			{
				value += UnityEngine.Random.Range(-1, 2);
				yield return value;
				if (Mathf.Abs(value) >= 10)
					yield break;
			}
		}
	}
}