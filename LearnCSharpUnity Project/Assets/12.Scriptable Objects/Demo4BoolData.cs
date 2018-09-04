//                                  ┌∩┐(◣_◢)┌∩┐
//																				\\
// Demo4BoolData.cs (00/00/0000)												\\
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
	public class Demo4BoolData : Demo4Data
	{
		public bool toggle;
		public override string ToString()
		{
			return string.Format("[{0}, {1}]", name, toggle);
		}
	}
}