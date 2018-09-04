//                                  ┌∩┐(◣_◢)┌∩┐
//																				\\
// ScriptableTets.cs (00/00/0000)												\\
// Autor: Antonio Mateo (.\Moon Antonio) 	antoniomt.moon@gmail.com			\\
// Descripcion:																	\\
// Fecha Mod:		00/00/0000													\\
// Ultima Mod:																	\\
//******************************************************************************\\

#region Librerias
using UnityEngine;
#endregion

namespace MoonAntonio
{
	[CreateAssetMenu(fileName = "ScriptableTets", menuName = "Scriptable Objects/ScriptableTets", order = 1)]
	public class ScriptableTets : ScriptableObject
	{
		public int value;

		void Awake()
		{
			Debug.Log("Awake ScriptableTets " + name);
		}

		void OnDestroy()
		{
			Debug.Log("Destroy ScriptableTets " + name);
		}

		void OnEnable()
		{
			Debug.Log("OnEnable ScriptableTets " + name);
		}

		void OnDisable()
		{
			Debug.Log("OnDisable ScriptableTets " + name);
		}
	}
}