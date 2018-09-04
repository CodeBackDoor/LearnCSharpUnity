//                                  ┌∩┐(◣_◢)┌∩┐
//																				\\
// Demo2Inspector.cs (00/00/0000)												\\
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
	[CustomEditor(typeof(Demo2))]
	public class Demo2Inspector : Editor
	{
		public override void OnInspectorGUI()
		{
			DrawDefaultInspector();
			Demo2 myTarget = (Demo2)target;
			if (GUILayout.Button("Crear Data"))
			{
				var dataA = new Demo2NumberData();
				dataA.name = "Demo2NumberData";
				dataA.number = UnityEngine.Random.Range(1, 100);
				var dataB = new Demo2BoolData();
				dataB.name = "Demo2BoolData";
				dataB.toggle = UnityEngine.Random.value > 0.5;
				myTarget.dataArray = new Demo2Data[] { dataA, dataB };
			}
			if (GUILayout.Button("Log"))
			{
				foreach (var data in myTarget.dataArray)
				{
					Debug.Log(data.ToString());
				}
			}
		}
	}
}