﻿//                                  ┌∩┐(◣_◢)┌∩┐
//																				\\
// EnumsFlags.cs.cs (00/00/0000)												\\
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
	[System.Flags]
	public enum Colors
	{
		None = 0,
		Red = 1 << 0,
		Green = 1 << 1,
		Blue = 1 << 2,
	}

	public class EnumsFlags : MonoBehaviour 
	{
		public Colors color;
	}
}