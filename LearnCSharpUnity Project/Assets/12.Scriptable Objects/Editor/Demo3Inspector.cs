//                                  ┌∩┐(◣_◢)┌∩┐
//																				\\
// Demo3Inspector.cs (00/00/0000)												\\
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
	[CustomEditor(typeof(Demo3))]
	public class Demo3Inspector : Editor
	{
		public override void OnInspectorGUI()
		{
			DrawDefaultInspector();
			Demo3 myTarget = (Demo3)target;
			if (GUILayout.Button("Crear Data"))
			{
				myTarget.dataA = ScriptableObject.CreateInstance<Demo3Data>();
				myTarget.dataB = myTarget.dataA;
			}
		}
	}
}