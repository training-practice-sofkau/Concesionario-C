using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concesionario
{
    class Program
    {
        private static void Main(string[] args)
        {
            int cantidad;
            int option;
            int opcion;
            int _ID;
            string _Marca;
            string _Modelo;
            int _KM;
            int _Precio;
            string transmission;
            string realidad;
            bool sidecar;

            //Se da la limitacion de acuerdo al gusto del usuario
            Console.WriteLine("Ingrese la capacidad del deposito: ");
            cantidad = int.Parse(Console.ReadLine());
            Consesionario consesionario = new(cantidad);

            //Da a escoger que va a ingresar en el deposito
            do {
                Console.WriteLine("0. Ninguna ");
                Console.WriteLine("1. Añadir Coche");
                Console.WriteLine("2. Editar Coche");
                Console.WriteLine("3. Listar Coches");
                Console.WriteLine("4. Eliminar Coche");
                opcion = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese 1. Cuatrimoto, 2. Moto");
                option = int.Parse(Console.ReadLine());
                int i = +1;
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Ingrese el ID");
                        _ID = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese la Marca");
                        _Marca = Console.ReadLine();
                        Console.WriteLine("Ingrese el Modelo");
                        _Modelo = Console.ReadLine();
                        Console.WriteLine("Ingrese el Kilometraje");
                        _KM = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el Precio");
                        _Precio = int.Parse(Console.ReadLine());
                        if (option == 1)
                        {
                            Console.WriteLine("Ingrese el Trasmision");
                            transmission = Console.ReadLine();
                            Cuatrimoto cuatrimoto = new(_ID, _Marca, _Modelo, _KM, _Precio, transmission);
                            consesionario.AddV(i, cuatrimoto);
                        }
                        else
                        {
                            Console.WriteLine("¿Tiene SideCar? Si, No: ");
                            realidad = Console.ReadLine();
                            if (realidad == "Si")
                            {
                                sidecar = true;
                                Moto moto = new(_ID, _Marca, _Modelo, _KM, _Precio, sidecar);
                                consesionario.AddV(i, moto);
                            }
                            else
                            {
                                sidecar = false;
                                Moto moto = new(_ID, _Marca, _Modelo, _KM, _Precio, sidecar);
                                consesionario.AddV(i, moto);
                            }
                        }
                        break;
                    case 2:
                        Console.WriteLine("Ingrese el ID");
                        _ID = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese la Marca");
                        _Marca = Console.ReadLine();
                        Console.WriteLine("Ingrese el Modelo");
                        _Modelo = Console.ReadLine();
                        Console.WriteLine("Ingrese el Kilometraje");
                        _KM = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el Precio");
                        _Precio = int.Parse(Console.ReadLine());
                        Console.WriteLine("¿Modificara 1. Cuatrimoto, 2. Moto?:");
                        int optionE = int.Parse(Console.ReadLine());
                        if (optionE == 1)
                        {
                            Console.WriteLine("Ingrese el Trasmision");
                            transmission = Console.ReadLine();
                            Cuatrimoto cuatrimoto = new(_ID, _Marca, _Modelo, _KM, _Precio, transmission);
                            consesionario.EditV(cuatrimoto);
                        }
                        else
                        {
                            Console.WriteLine("¿Tiene SideCar? Si, No: ");
                            realidad = Console.ReadLine();
                            if (realidad == "Si")
                            {
                                sidecar = true;
                                Moto moto = new(_ID, _Marca, _Modelo, _KM, _Precio, sidecar);
                                consesionario.EditV(moto);
                            }
                            else
                            {
                                sidecar = false;
                                Moto moto = new(_ID, _Marca, _Modelo, _KM, _Precio, sidecar);
                                consesionario.EditV(moto);
                            }
                        }
                        break; 
                    case 3:
                        consesionario.List();
                        break; 
                    case 4:
                        Console.WriteLine("Ingrese el ID");
                        _ID = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese la Marca");
                        _Marca = Console.ReadLine();
                        Console.WriteLine("Ingrese el Modelo");
                        _Modelo = Console.ReadLine();
                        Console.WriteLine("Ingrese el Kilometraje");
                        _KM = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el Precio");
                        _Precio = int.Parse(Console.ReadLine());
                        Console.WriteLine("¿Modificara 1. Cuatrimoto, 2. Moto?:");
                        int optionD = int.Parse(Console.ReadLine());
                        if (optionD == 1)
                        {
                            Console.WriteLine("Ingrese el Trasmision");
                            transmission = Console.ReadLine();
                            Cuatrimoto cuatrimoto = new(_ID, _Marca, _Modelo, _KM, _Precio, transmission);
                            consesionario.Delete(cuatrimoto);
                        }
                        else
                        {
                            Console.WriteLine("¿Tiene SideCar? Si, No: ");
                            realidad = Console.ReadLine();
                            if (realidad == "Si")
                            {
                                sidecar = true;
                                Moto moto = new(_ID, _Marca, _Modelo, _KM, _Precio, sidecar);
                                consesionario.Delete(moto);
                            }
                            else
                            {
                                sidecar = false;
                                Moto moto = new(_ID, _Marca, _Modelo, _KM, _Precio, sidecar);
                                consesionario.Delete(moto);
                            }
                        }
                        break;
                    default: 
                        Console.WriteLine("Dato incorrecto");
                        break;
                }
            } while(opcion > 0 && opcion < 5);
        }
    }
}