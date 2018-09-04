//                                  ┌∩┐(◣_◢)┌∩┐
//																				\\
// Demo4NumberData.cs (00/00/0000)												\\
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
	public class Demo4NumberData : Demo4Data
	{
		public int number;
		public override string ToString()
		{
			return string.Format("[{0}, {1}]", name, number);
		}
	}
}