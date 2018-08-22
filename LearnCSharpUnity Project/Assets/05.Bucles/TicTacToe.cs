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

		void Start()
		{
			NewGame();
		}

		public void NewGame()
		{
			cells[0].text = "";
			cells[1].text = "";
			cells[2].text = "";
			cells[3].text = "";
			cells[4].text = "";
			cells[5].text = "";
			cells[6].text = "";
			cells[7].text = "";
			cells[8].text = "";
			cells[9].text = "";
		}
	}
}