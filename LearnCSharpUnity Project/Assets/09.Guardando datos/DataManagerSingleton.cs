//                                  ┌∩┐(◣_◢)┌∩┐
//																				\\
// DataManagerSingleton.cs (00/00/0000)											\\
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
	public class DataManagerSingleton 
	{
		public static readonly DataManagerSingleton instance = new DataManagerSingleton();
		private DataManagerSingleton() { }
		public Difficulties difficulty;
	}
}