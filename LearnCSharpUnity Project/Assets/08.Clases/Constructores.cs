//                                  ┌∩┐(◣_◢)┌∩┐
//																				\\
// Constructores.cs (00/00/0000)												\\
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
	public class Point
	{
		public int x;
		public int y;

		public Point()
		{
			Debug.Log("¡Estoy vivo! ... pero estoy a cero.");
		}

		public Point(int x, int y)
		{
			this.x = x;
			this.y = y;
			Debug.Log("Whoooa, debo ser valioso!");
		}

		~Point()
		{
			Debug.Log("Me estoy derritiendo, FUNDICIÓN !!!");
		}
	}

	public class Constructores : MonoBehaviour 
	{
		public void Start()
		{
			Point p1 = new Point();
			Point p2 = new Point(2, 5);
		}
	}
}