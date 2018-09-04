//                                  ┌∩┐(◣_◢)┌∩┐
//																				\\
// Demo2Data.cs (00/00/0000)													\\
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
	[System.Serializable]
	public class Demo2Data
	{
		public string name;
		public override string ToString()
		{
			return string.Format("[{0}]", name);
		}
	}

	[System.Serializable]
	public class Demo2NumberData : Demo2Data
	{
		public int number;
		public override string ToString()
		{
			return string.Format("[{0}, {1}]", name, number);
		}
	}

	[System.Serializable]
	public class Demo2BoolData : Demo2Data
	{
		public bool toggle;
		public override string ToString()
		{
			return string.Format("[{0}, {1}]", name, toggle);
		}
	}
}