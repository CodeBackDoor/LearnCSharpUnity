//                                  ┌∩┐(◣_◢)┌∩┐
//																				\\
// Monster.cs (00/00/0000)														\\
// Autor: Antonio Mateo (.\Moon Antonio) 	antoniomt.moon@gmail.com			\\
// Descripcion:																	\\
// Fecha Mod:		00/00/0000													\\
// Ultima Mod:																	\\
//******************************************************************************\\

#region Librerias
using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
#endregion

namespace MoonAntonio
{
	public class Monster : MonoBehaviour 
	{
		public int HP;

		public virtual Dictionary<string, object> Save()
		{
			Dictionary<string, object> data = new Dictionary<string, object>();
			data.Add("HP", HP);
			data.Add("X", transform.localPosition.x);
			data.Add("Y", transform.localPosition.y);
			data.Add("Z", transform.localPosition.z);
			data.Add("Prefab", gameObject.name);
			return data;
		}

		public virtual void Load(Dictionary<string, object> data)
		{
			HP = Convert.ToInt32(data["HP"]);
			float x = Convert.ToSingle(data["X"]);
			float y = Convert.ToSingle(data["Y"]);
			float z = Convert.ToSingle(data["Z"]);
			transform.localPosition = new Vector3(x, y, z);
		}
	}
}