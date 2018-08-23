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
		bool gameOver;
		int[,] wins = new int[,]
		{
			{0,1,2},
			{3,4,5},
			{6,7,8},
			{0,3,6},
			{1,4,7},
			{2,5,8},
			{0,4,8},
			{2,4,6}
		};

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

		void CheckGameState()
		{
			for (int i = 0; i < wins.GetLength(0); ++i)
			{
				int j = wins[i, 0];
				int k = wins[i, 1];
				int l = wins[i, 2];
				if (cells[j].text == cells[k].text &&
					cells[k].text == cells[l].text &&
					!string.IsNullOrEmpty(cells[j].text))
				{
					gameOver = true;
					Debug.Log(cells[j].text + " GANAS!");
					Invoke("NewGame", 3f);
					break;
				}
			}
		}
	}
}