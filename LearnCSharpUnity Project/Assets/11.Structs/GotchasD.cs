//                                  ┌∩┐(◣_◢)┌∩┐
//																				\\
// GotchasD.cs (00/00/0000)													\\
// Autor: Antonio Mateo (.\Moon Antonio) 	antoniomt.moon@gmail.com								        \\
// Descripcion:																	\\
// Fecha Mod:		00/00/0000													\\
// Ultima Mod:																	\\
//******************************************************************************\\

#region Librerias
using UnityEngine;
#endregion

namespace MoonAntonio
{
	public class Moo
	{
		public Vector3 pos { get { return _pos; } set { _pos = value; } }
		private Vector3 _pos;
	}

	public class GotchasD : MonoBehaviour 
	{
		void Start()
		{
			Moo myMoo = new Moo();
			myMoo.pos.Set(1, 2, 3);
			// myMoo.pos.x = 4; // error CS1612 (consulte el ejemplo anterior y comente esta línea para compilar)
			Debug.Log(myMoo.pos.ToString()); // // Será (0.0, 0.0, 0.0) - ¡No es lo que esperaba!
		}
	}
}