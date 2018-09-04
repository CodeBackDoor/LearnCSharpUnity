//                                  ┌∩┐(◣_◢)┌∩┐
//																				\\
// Demo4Data.cs (00/00/0000)													\\
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
	public class Demo4Data : ScriptableObject
	{
		public override string ToString()
		{
			return string.Format("[{0}]", name);
		}
	}
}