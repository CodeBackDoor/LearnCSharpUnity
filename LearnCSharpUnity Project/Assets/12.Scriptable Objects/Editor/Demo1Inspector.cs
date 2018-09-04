//                                  ┌∩┐(◣_◢)┌∩┐
//																				\\
// Demo1Inspector.cs (00/00/0000)												\\
// Autor: Antonio Mateo (.\Moon Antonio) 	antoniomt.moon@gmail.com			\\
// Descripcion:																	\\
// Fecha Mod:		00/00/0000													\\
// Ultima Mod:																	\\
//******************************************************************************\\

#region Librerias
using UnityEngine;
using UnityEditor;
#endregion

namespace MoonAntonio
{
	[CustomEditor(typeof(Demo1))]
	public class Demo1Inspector : Editor
	{
		public override void OnInspectorGUI()
		{
			DrawDefaultInspector();
			Demo1 myTarget = (Demo1)target;
			if (GUILayout.Button("Crear Data"))
			{
				myTarget.dataA = new Demo1Data();
				myTarget.dataB = myTarget.dataA;
			}
		}
	}
}