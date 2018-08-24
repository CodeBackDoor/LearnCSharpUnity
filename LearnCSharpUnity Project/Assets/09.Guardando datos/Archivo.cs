//                                  ┌∩┐(◣_◢)┌∩┐
//																				\\
// Archivo.cs (00/00/0000)														\\
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
using System.IO;
#endregion

namespace MoonAntonio
{
	public class Archivo : MonoBehaviour 
	{
		[SerializeField] GameObject[] prefabs;
		Dictionary<string, GameObject> mapping = new Dictionary<string, GameObject>();
		List<Monster> monsters = new List<Monster>();

		void Start()
		{
			for (int i = 0; i < prefabs.Length; ++i)
				mapping.Add(prefabs[i].name, prefabs[i]);
			Load();
		}

		void OnGUI()
		{
			if (GUI.Button(new Rect(10, 10, 100, 30), "Agregar"))
				AddRandom();

			if (GUI.Button(new Rect(10, 50, 100, 30), "Guardar"))
				Save();

			if (GUI.Button(new Rect(10, 90, 100, 30), "Cargar"))
				Load();
		}

		void Randomize(Monster monster)
		{
			monster.HP = UnityEngine.Random.Range(10, 100);
			float x = UnityEngine.Random.Range(-10f, 10f);
			float y = UnityEngine.Random.Range(-10f, 10f);
			float z = UnityEngine.Random.Range(-10f, 10f);
			monster.transform.localPosition = new Vector3(x, y, z);
		}

		void AddRandom()
		{
			GameObject prefab = prefabs[UnityEngine.Random.Range(0, prefabs.Length)];
			Monster monster = Add(prefab);
			Randomize(monster);
		}

		Monster Add(GameObject prefab)
		{
			GameObject instance = Instantiate(prefab) as GameObject;
			Monster monster = instance.GetComponent<Monster>();
			monster.name = prefab.name;
			monsters.Add(monster);
			return monster;
		}

		void Save()
		{
			var monsterData = new List<Dictionary<string, object>>(monsters.Count);
			for (int i = 0; i < monsters.Count; ++i)
				monsterData.Add(monsters[i].Save());

			string json = Json.Serialize(monsterData);
			string filePath = Application.persistentDataPath + "/Monsters.txt";
			File.WriteAllText(filePath, json);
		}

		void Load()
		{
			Clear();
			string filePath = Application.persistentDataPath + "/Monsters.txt";
			if (File.Exists(filePath))
			{
				string json = File.ReadAllText(filePath);
				var monsterData = Json.Deserialize(json) as List<object>;
				for (int i = 0; i < monsterData.Count; ++i)
				{
					Dictionary<string, object> data = monsterData[i] as Dictionary<string, object>;
					string prefab = (string)(data["Prefab"]);
					Monster monster = Add(mapping[prefab]);
					monster.Load(data);
				}
			}
		}

		void Clear()
		{
			for (int i = monsters.Count - 1; i >= 0; --i)
				Destroy(monsters[i].gameObject);
			monsters.Clear();
		}
	}
}