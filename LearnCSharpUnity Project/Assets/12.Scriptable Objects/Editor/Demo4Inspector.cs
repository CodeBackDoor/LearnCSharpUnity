//                                  ┌∩┐(◣_◢)┌∩┐
//																				\\
// Demo4Inspector.cs (00/00/0000)												\\
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
	[CustomEditor(typeof(Demo4))]
	public class Demo4Inspector : Editor
	{
		public override void OnInspectorGUI()
		{
			DrawDefaultInspector();
			Demo4 myTarget = (Demo4)target;
			if (GUILayout.Button("Crear Data"))
			{
				var dataA = ScriptableObject.CreateInstance<Demo4NumberData>();
				dataA.name = "Demo4NumberData";
				dataA.number = UnityEngine.Random.Range(1, 100);
				var dataB = ScriptableObject.CreateInstance<Demo4BoolData>();
				dataB.name = "Demo4BoolData";
				dataB.toggle = UnityEngine.Random.value > 0.5;
				myTarget.dataArray = new Demo4Data[] { dataA, dataB };
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