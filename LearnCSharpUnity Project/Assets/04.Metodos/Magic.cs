//                                  ┌∩┐(◣_◢)┌∩┐
//																				\\
// Magic.cs (00/00/0000)														\\
// Autor: Antonio Mateo (.\Moon Antonio) 	antoniomt.moon@gmail.com			\\
// Descripcion:																	\\
// Fecha Mod:		00/00/0000													\\
// Ultima Mod:																	\\
//******************************************************************************\\

#region Librerias
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
#endregion

namespace MoonAntonio
{
	public class Magic : MonoBehaviour 
	{
		public string[] respuestas;
		[SerializeField] Text _label;

		public void Pregunta()
		{
			int index = UnityEngine.Random.Range(0, respuestas.Length);
			_label.text = respuestas[index];
		}
	}
}