//                                  ┌∩┐(◣_◢)┌∩┐
//																				\\
// Selectable.cs (00/00/0000)													\\
// Autor: Antonio Mateo (.\Moon Antonio) 	antoniomt.moon@gmail.com			\\
// Descripcion:																	\\
// Fecha Mod:		00/00/0000													\\
// Ultima Mod:																	\\
//******************************************************************************\\

#region Librerias
using UnityEngine;
using System.Collections;
#endregion

namespace MoonAntonio
{
	public abstract class Selectable : MonoBehaviour
	{
		public bool isSelected { get; protected set; }
		public virtual void SetSelected(bool value)
		{
			if (isSelected == value)
				return;
			isSelected = value;
			if (isSelected)
				Select();
			else
				Deselect();
		}
		protected abstract void Select();
		protected abstract void Deselect();
	}
}