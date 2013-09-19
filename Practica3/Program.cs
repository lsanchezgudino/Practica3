/*
 * Created by SharpDevelop.
 * User: Luly
 * Date: 19/09/2013
 * Time: 04:34 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Practica3
{
	class Persona
	{
		public string nombre;
		public string correo;
		public int edad;
		
		public static void Main(string[] args)
		{
			Persona p=new Persona();
			Console.WriteLine("Ingresa tu nombre");
			p.nombre = Console.ReadLine();
			Console.WriteLine("Ingresa tu edad");
			p.edad = int.Parse(Console.ReadLine());
			Console.WriteLine("Ingresa tu correo");
			p.correo = Console.ReadLine();
			Console.Clear();
			Console.WriteLine("tu nombre es: "+p.nombre);
			Console.WriteLine(" tu edad es: "+p.edad);
			Console.WriteLine("tu correo es: "+p.correo);
	

			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}