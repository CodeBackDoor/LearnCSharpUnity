//                                  ┌∩┐(◣_◢)┌∩┐
//																				\\
// PlayerPrefs.cs (00/00/0000)													\\
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
	public class PlayerPrefsExample : MonoBehaviour 
	{
		private void Start()
		{
			// Almacenar un valor entero
			PlayerPrefs.SetInt("Difficulty", 0);
			// Recupere un valor entero (si existe, o use un valor predeterminado de '0' de lo contrario)
			DataManagerUnitySingleton.instance.difficulty = (Difficulties)PlayerPrefs.GetInt("Difficulty", 0);
		}
	}
}