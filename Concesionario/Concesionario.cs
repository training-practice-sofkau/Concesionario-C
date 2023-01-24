using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concesionario
{
	internal class Concesionario
	{
		private Coche[] coches = new Coche[10];

		public void añadirCoche(Coche c, int indicador)
		{
			coches[indicador] = c;
		}

		public void editarCoche(int indicador)
		{
			Console.WriteLine("ID del coche: ");
			coches[indicador].Id = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Marca del coche: ");
			coches[indicador].Marca = Console.ReadLine();
			Console.WriteLine("Modelo del coche: ");
			coches[indicador].Modelo = Console.ReadLine();
			Console.WriteLine("KM del coche: ");
			coches[indicador].Km = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Precio del coche: ");
			coches[indicador].Precio = Convert.ToInt32(Console.ReadLine());
		}

		public Array listarCoches()
		{
			return coches;
		}

		public void eliminarCoche(int indicador)
		{
			coches = coches.Where((source, index) => index != indicador).ToArray();
			Console.WriteLine("Coche eliminado. ");
		}

	}
}
