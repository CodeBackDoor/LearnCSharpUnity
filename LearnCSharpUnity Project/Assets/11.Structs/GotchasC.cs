//                                  ┌∩┐(◣_◢)┌∩┐
//																				\\
// GotchasC.cs (00/00/0000)														\\
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
	public class Foo
	{
		public Vector3 pos;
	}

	public class GotchasC : MonoBehaviour 
	{
		void Start()
		{
			Foo myFoo = new Foo();
			myFoo.pos.Set(1, 2, 3);
			myFoo.pos.x = 4; // Sin error de compilación
			Debug.Log(myFoo.pos.ToString()); //Será (4.0, 2.0, 3.0) - ¡Como esperabas!
		}
	}
}