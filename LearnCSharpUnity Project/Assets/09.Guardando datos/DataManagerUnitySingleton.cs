//                                  ┌∩┐(◣_◢)┌∩┐
//																				\\
// DataManagerUnitySingleton.cs (00/00/0000)									\\
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
	public class DataManagerUnitySingleton : MonoBehaviour 
	{
		public static DataManagerUnitySingleton instance
		{
			get
			{
				if (_instance == null)
				{
					GameObject obj = new GameObject("Data Manager Unity Singleton");
					_instance = obj.AddComponent<DataManagerUnitySingleton>();
					DontDestroyOnLoad(obj);
				}
				return _instance;
			}
		}
		static DataManagerUnitySingleton _instance;
		public Difficulties difficulty;
	}
}