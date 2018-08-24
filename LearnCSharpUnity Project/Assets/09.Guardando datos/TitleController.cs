//                                  ┌∩┐(◣_◢)┌∩┐
//																				\\
// TitleController.cs (00/00/0000)												\\
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
	public class TitleController : MonoBehaviour 
	{
		void OnGUI()
		{
			int yPos = 10;
			GUI.Label(new Rect(10, yPos, 200, 30), "Elegir dificultad");
			for (int i = 0; i < (int)Difficulties.Count; ++i)
			{
				yPos += 40;
				Difficulties type = (Difficulties)i;
				if (DataManager.difficulty == type)
					GUI.Label(new Rect(10, yPos, 200, 30), type.ToString());
				else if (GUI.Button(new Rect(10, yPos, 100, 30), type.ToString()))
					DataManager.difficulty = type;
			}
			yPos += 40;
			if (GUI.Button(new Rect(10, yPos, 100, 30), "Play"))
				SceneManager.LoadScene("Juego");
		}
	}
}