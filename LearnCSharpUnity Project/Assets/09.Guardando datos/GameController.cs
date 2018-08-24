//                                  ┌∩┐(◣_◢)┌∩┐
//																				\\
// GameController.cs (00/00/0000)												\\
// Autor: Antonio Mateo (.\Moon Antonio) 	antoniomt.moon@gmail.com			\\
// Descripcion:																	\\
// Fecha Mod:		00/00/0000													\\
// Ultima Mod:																	\\
//******************************************************************************\\

#region Librerias
using UnityEngine;
using UnityEngine.SceneManagement;
#endregion

namespace MoonAntonio
{
	public class GameController : MonoBehaviour 
	{
		void OnGUI()
		{
			GUI.Label(new Rect(10, 10, 200, 30), DataManager.difficulty.ToString());
			if (GUI.Button(new Rect(10, 50, 100, 30), "Salir"))
				SceneManager.LoadScene("Titulo");
		}
	}
}