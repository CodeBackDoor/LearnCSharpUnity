//                                  ┌∩┐(◣_◢)┌∩┐
//																				\\
// TicTacToe.cs (00/00/0000)													\\
// Autor: Antonio Mateo (.\Moon Antonio) 	antoniomt.moon@gmail.com			\\
// Descripcion:																	\\
// Fecha Mod:		00/00/0000													\\
// Ultima Mod:																	\\
//******************************************************************************\\

#region Librerias
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
#endregion

namespace MoonAntonio
{
	public class TicTacToe : MonoBehaviour 
	{
		[SerializeField] Text[] cells;
		string marca;

		void Start()
		{
			NewGame();
		}

		public void NewGame()
		{
			for (int n = 0; n < cells.Length; n++)
			{
				cells[n].text = "";
			}

			marca = "X";
		}

		public void SelectCell(int index)
		{
			if (!string.IsNullOrEmpty(cells[index].text)) return;

			cells[index].text = marca;
			marca = (marca == "X") ? "O" : "X";
		}
	}
}