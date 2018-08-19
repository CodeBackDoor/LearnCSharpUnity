//                                  ┌∩┐(◣_◢)┌∩┐
//																				\\
// Demo.cs (00/00/0000)															\\
// Autor: Antonio Mateo (.\Moon Antonio) 	antoniomt.moon@gmail.com			\\
// Descripcion:																	\\
// Fecha Mod:		00/00/0000													\\
// Ultima Mod:																	\\
//******************************************************************************\\

#region Librerias
using UnityEngine;
#endregion

namespace MoonAntonio
{
	public class Demo : MonoBehaviour 
	{
		private void Start()
		{
			Debug.Log("Tiempo: " + Time.timeSinceLevelLoad);
		}

		private void Update()
		{
			Debug.Log("Tiempo: " + Time.timeSinceLevelLoad);
		}
	}
}