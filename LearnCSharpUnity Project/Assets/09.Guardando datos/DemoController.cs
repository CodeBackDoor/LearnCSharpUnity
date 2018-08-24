//                                  ┌∩┐(◣_◢)┌∩┐
//																				\\
// DemoController.cs (00/00/0000)												\\
// Autor: Antonio Mateo (.\Moon Antonio) 	antoniomt.moon@gmail.com			\\
// Descripcion:																	\\
// Fecha Mod:		00/00/0000													\\
// Ultima Mod:																	\\
//******************************************************************************\\

#region Librerias
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using MiniJSON;
#endregion

namespace MoonAntonio
{
	public class DemoController : MonoBehaviour 
	{
		public Monster monster;

		void Start()
		{
			Load();
		}

		void OnGUI()
		{
			if (GUI.Button(new Rect(10, 10, 100, 30), "Random"))
				Randomize();
			if (GUI.Button(new Rect(10, 50, 100, 30), "Guardar"))
				Save();

			if (GUI.Button(new Rect(10, 90, 100, 30), "Cargar"))
				Load();
		}

		void Randomize()
		{
			monster.HP = UnityEngine.Random.Range(10, 100);
			float x = UnityEngine.Random.Range(-10f, 10f);
			float y = UnityEngine.Random.Range(-10f, 10f);
			float z = UnityEngine.Random.Range(-10f, 10f);
			monster.transform.localPosition = new Vector3(x, y, z);
		}

		void Save()
		{
			string json = Json.Serialize(monster.Save());
			Debug.Log(json);
			PlayerPrefs.SetString("Monster", json);
		}

		void Load()
		{
			string json = PlayerPrefs.GetString("Monster", string.Empty);
			if (!string.IsNullOrEmpty(json))
			{
				var dict = Json.Deserialize(json) as Dictionary<string, object>;
				monster.Load(dict);
			}
		}
	}
}