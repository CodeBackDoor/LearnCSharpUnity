//                                  ┌∩┐(◣_◢)┌∩┐
//																				\\
// Humano.cs (00/00/0000)														\\
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
	public class Humano : MonoBehaviour 
	{
		public string nombre = string.Empty;
		public int edad = 25;
		private string _peliculaFavorita;

		public string PeliculaFavorita
		{
			get
			{
				return _peliculaFavorita;
			}
			private set
			{
				_peliculaFavorita = value;
			}
		}	

		private void Start()
		{
			name = nombre;
			Debug.Log("Hola, mi nombre es " + name);
		}
	}
}