//                                  ┌∩┐(◣_◢)┌∩┐
//																				\\
// Motor.cs (00/00/0000)														\\
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
	public class Motor : MonoBehaviour 
	{
		public float vel;

		void Update()
		{
			float velFrameLimitada = vel * Time.deltaTime;
			Vector3 rotacion = new Vector3(0, velFrameLimitada, 0);
			transform.Rotate(rotacion);
		}
	}
}