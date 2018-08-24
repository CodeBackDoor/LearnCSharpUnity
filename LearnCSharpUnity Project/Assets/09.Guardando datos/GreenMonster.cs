//                                  ┌∩┐(◣_◢)┌∩┐
//																				\\
// GreenMonster.cs (00/00/0000)													\\
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
	public class GreenMonster : Monster 
	{
		public int earth;

		void Awake()
		{
			earth = UnityEngine.Random.Range(10, 100);
		}

		public override Dictionary<string, object> Save()
		{
			Dictionary<string, object> data = base.Save();
			data.Add("Earth", earth);
			return data;
		}

		public override void Load(Dictionary<string, object> data)
		{
			base.Load(data);
			earth = Convert.ToInt32(data["Earth"]);
		}
	}
}