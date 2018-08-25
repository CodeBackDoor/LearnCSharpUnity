//                                  ┌∩┐(◣_◢)┌∩┐
//																				\\
// EnumsFlagsInspector.cs (00/00/0000)											\\
// Autor: Antonio Mateo (.\Moon Antonio) 	antoniomt.moon@gmail.com			\\
// Descripcion:																	\\
// Fecha Mod:		00/00/0000													\\
// Ultima Mod:																	\\
//******************************************************************************\\

#region Librerias
using UnityEngine;
using UnityEditor;
using System.Collections;
#endregion

namespace MoonAntonio
{
	[CustomEditor(typeof(EnumsFlags))]
	public class EnumsFlagsInspector : Editor
	{
		public override void OnInspectorGUI()
		{
			EnumsFlags e = (EnumsFlags)target;
			e.color = (Colors)EditorGUILayout.EnumFlagsField("Colors", e.color);
		}
	}
}