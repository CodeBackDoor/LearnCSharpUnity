//                                  ┌∩┐(◣_◢)┌∩┐
//																				\\
// MetodosMain.cs (00/00/0000)													\\
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
	public class MetodosMain : MonoBehaviour 
	{
		public string test;
		public int value1;
		public int value2;

		void Start()
		{
			MetodoQueRealizaAlgo();

			if (IsRegistrado(test))
			{
				Debug.Log("Registrado.");
			}
			else
			{
				Debug.Log("No Registrado.");
			}

			int value = Multiplicar(value1, value2);
			Debug.Log("Resultado: " + value);
		}

		private void MetodoQueRealizaAlgo()
		{
			Debug.Log("Hola Mundo!");
		}

		public bool IsRegistrado(string myID)
		{
			return string.Equals(myID, "Moon");
		}

		private int Multiplicar(int a, int b)
		{
			return a * b;
		}
	}
}