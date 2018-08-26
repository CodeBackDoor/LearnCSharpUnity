//                                  ┌∩┐(◣_◢)┌∩┐
//																				\\
// GotchasA.cs (00/00/0000)														\\
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
	public class GotchasA : MonoBehaviour 
	{
		public Vector3 v1;
		public Vector3 v2 { get; private set; }

		void Start()
		{
			v1.Set(1, 2, 3);
			v1.x = 4;
			v2.Set(1, 2, 3);      // ** (Nota 2)
			//v2.x = 4;           // * (Nota 1)

			Debug.Log(v1.ToString());
			Debug.Log(v2.ToString());
		}
	}
}