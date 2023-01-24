using System.ComponentModel.Design;
using System.Globalization;

namespace Concesionario
{
	class Program
	{
		int contador = 0;
		public Program()
		{
			try
			{
				menu();
			}catch(Exception)
			{
				Console.WriteLine("Dato invalido");
			}
		}

		private void menu()
		{
			//Instancia de la clase Concesionario y variables utilizadas en el menu
			Concesionario concesionario = new Concesionario();
			int opcion;
			int id;
			string marca;
			string modelo;
			int km;
			int precio;
			int adicional;
			
			do
			{
				Console.WriteLine("--------------------  Bienvenido al Cocesionario ---------------------------");
				Console.WriteLine("Menu:    ");
				Console.WriteLine("1. Nuevo añadir nuevo coche.");
				Console.WriteLine("2. Editar un coche. ");
				Console.WriteLine("3. Consultar coches. ");
				Console.WriteLine("4. Eliminar Coche. ");
				Console.Write("----> ");

				opcion = Convert.ToInt32(Console.ReadLine());

				//Agrega un coche al arreglo de la clase concesionario validando que este dentro del tamaño del arreglo
				if (opcion == 1 && contador >= 0 && contador <= 10)
				{
					Console.WriteLine("1. Moto. ");
					Console.WriteLine("2. Cuatrimoto. ");
					Console.Write("----> ");
					opcion = Convert.ToInt32(Console.ReadLine());
					//crea un objeto de tipo Moto, verifica el precio y lo al macena en el array de la clase concesionario
					if (opcion == 1)
					{
						Console.WriteLine("ID de la moto: ");
						id = Convert.ToInt32(Console.ReadLine());
						Console.WriteLine("Marca de la moto: ");
						marca = Console.ReadLine();
						Console.WriteLine("Modelo de la moto: ");
						modelo = Console.ReadLine();
						Console.WriteLine("KM de la moto: ");
						km = Convert.ToInt32(Console.ReadLine());
						Console.WriteLine("Precio de la moto: ");
						precio = Convert.ToInt32(Console.ReadLine());

						Moto nuevaMoto = new Moto(id, marca, modelo, km, precio);

						Console.WriteLine("La moto tiene sidecar? ");
						Console.WriteLine("1. SI ");
						Console.WriteLine("2. NO ");
						adicional = Convert.ToInt32(Console.ReadLine());

						if (adicional == 1)
						{
							nuevaMoto.Sidecar = true;
							nuevaMoto.VerificarPrecio(nuevaMoto);
						}
						else
						{
							nuevaMoto.Sidecar = false;
						}

						concesionario.añadirCoche(nuevaMoto, contador);
						contador++;
					}
					//crea un objeto de tipo Cuatrimoto, verifica el precio y lo al macena en el array de la clase concesionario
					else if (opcion == 2)
					{
						Console.WriteLine("ID de la cuatrimoto: ");
						id = Convert.ToInt32(Console.ReadLine());
						Console.WriteLine("Marca de la cuatrimoto: ");
						marca = Console.ReadLine();
						Console.WriteLine("Modelo de la cuatrimoto: ");
						modelo = Console.ReadLine();
						Console.WriteLine("KM de la cuatrimoto: ");
						km = Convert.ToInt32(Console.ReadLine());
						Console.WriteLine("Precio de la cuatrimoto: ");
						precio = Convert.ToInt32(Console.ReadLine());

						Cuatrimoto nuevaCuatrimoto = new Cuatrimoto(id, marca, modelo, km, precio);

						Console.WriteLine("La moto tiene transmision? ");
						Console.WriteLine("1. SI ");
						Console.WriteLine("2. NO ");
						adicional = Convert.ToInt32(Console.ReadLine());

						if (adicional == 1)
						{
							nuevaCuatrimoto.Transmision = true;
							nuevaCuatrimoto.VerificarPrecio(nuevaCuatrimoto);
						}
						else
						{
							nuevaCuatrimoto.Transmision = false;
						}

						concesionario.añadirCoche(nuevaCuatrimoto, contador);
						contador++;
					}
				}//muestra la lista de coches y accede al metodo editar de la clase concesionario para editar un elemento del array
				else if (opcion == 2)
				{
					mostrarCoches(concesionario.listarCoches());
					Console.WriteLine("Digite el coche que desea editar. ");
					Console.WriteLine("-->");
					int editar = Convert.ToInt32(Console.ReadLine());
					concesionario.editarCoche(editar);
				}
				//Obtiene el array de coches de la clase concesionario y la muestra por consola
				else if (opcion == 3)
				{
					mostrarCoches(concesionario.listarCoches());
				}
				//muestra la lista de coches y accede al metodo eliminar de la clase concesionario para eliminar un elemento del array
				else if (opcion == 4)
				{
					mostrarCoches(concesionario.listarCoches());
					Console.WriteLine("Digite el coche que desea eliminar. ");
					Console.WriteLine("-->");
					int eliminar = Convert.ToInt32(Console.ReadLine());
					concesionario.eliminarCoche(eliminar);
					contador--;
				}
				else
				{
					Console.WriteLine("Opcion incorrecta. ");
				}

			} while (opcion > 0 && opcion < 5);
		}
		//funcion encargada de recorrer el arreglo e imprimirlo en consola
		public void mostrarCoches(Array list)
		{

			for (int i = 0; i < contador; i++)
			{
				Console.WriteLine(i+" "+list.GetValue(i).ToString());
			}
		}
		static void Main(string[] args)
		{

			Program programa= new Program();

			/*
			Concesionario c = new Concesionario();

			Moto moto1 = new Moto(01,"fix","95",12500,50000);
			Moto moto2 = new Moto(02,"roy","98",52325,60000);
			Moto moto3 = new Moto(03,"axu","99",4586,70000);

			moto1.Sidecar = true;
			moto1.VerificarPrecio(moto1);

			Cuatrimoto cuatri1 = new Cuatrimoto(04, "rol", "78", 0, 580000);
			Cuatrimoto cuatri2 = new Cuatrimoto(05, "tux", "89", 9549, 780000);
			Cuatrimoto cuatri3 = new Cuatrimoto(06, "jax", "88", 1002, 790000);

			cuatri1.Transmision = true;
			cuatri1.VerificarPrecio(cuatri1);


			c.añadirCoche(moto1, 0);
			c.añadirCoche(moto2, 1);
			c.añadirCoche(moto3, 2);
			c.añadirCoche(cuatri1, 3);
			c.añadirCoche(cuatri2, 4);
			c.añadirCoche(cuatri3, 5);

			c.editarCoche(1);

			c.eliminarCoche(0);

			for(int i=0; i < 6; i++)
			{
				Console.WriteLine(c.listarCoches().GetValue(i).ToString());
			}
			*/
		}
	}
}