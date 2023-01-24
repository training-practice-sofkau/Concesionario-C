using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concesionario
{
    internal class Concesionario
    {
        List<Coche> listaCoche = new List<Coche> ();
        string Id;
        string Marca;
        string Modelo;
        int Km;
        double Precio;

        public void CrearCoche() {

            Console.WriteLine("---------------Crear Coche---------------");
            Console.WriteLine("\n");

            Console.WriteLine("Ingrese la ID");
            Id = Console.ReadLine();

            Console.WriteLine("Ingrese la marca del Coche");
            Marca = Console.ReadLine();

            Console.WriteLine("Ingrese el modelo del Coche");
            Modelo = Console.ReadLine();

            Console.WriteLine("Ingrese el kilometraje del Coche");
            Km = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el precio Coche");
            Precio = double.Parse(Console.ReadLine());

            listaCoche.Add(new Coche(Id,Marca,Modelo,Km,Precio));

            Console.Write("\n");
            Console.Write("Datos Guardados");
        }

        private bool listaVacia() {

            if (listaCoche.Count == 0)
            {
                return true;
            }
            else { return false; }
        }

        public void lista() {
            if (listaVacia() == true)
            {
                Console.WriteLine("No hay coches registrados");
            }
            else { 
                Console.WriteLine("Total de registro de coches : " + listaCoche.Count);
                Console.WriteLine("-------Lista-------");
                
                foreach(Coche item in listaCoche.ToList()){
                    Imprimir(item);
                }
            }
            Console.WriteLine("\n");
        }

        private void Imprimir(Coche coche) {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("| Id : {0} | Marca : {1} | Modelo : {2} | Km : {3} | Precio : {4}",
                                coche.ID, coche.Marca, coche.Modelo, coche.KM, coche.Precio);
        }

        public void Eliminar() {

            string buscar;
            

            if (listaVacia() == true)
            {
                Console.WriteLine("No hay coches registrados");
            }
            else {
                Console.WriteLine("Ingrese el ID del coche para elimar: ");
                buscar = Console.ReadLine();
                foreach (var item in listaCoche.ToList())
                {
                    if (buscar == item.ID)
                    {
                     Console.WriteLine("---------------------------------");
                     Console.WriteLine("| Id : {0} | Marca : {1} | Modelo : {2} | Km : {3} | Precio : {4}",
                                            item.ID, item.Marca, item.Modelo, item.KM, item.Precio);
                    listaCoche.Remove(item);
                    Console.WriteLine("El coche ha sido eliminado");
                    }
                    else{
                        Console.WriteLine("Este coche no existe");
                    }
                }
            }
        }

        public void modificar() { 

            if (listaVacia() == true)
            {
                Console.WriteLine("No hay coches registrados");
            }
            else{
                Coche coche = new Coche();
                string buscar;
                Console.WriteLine("Ingrese La ID del coche para modificar : ");
                buscar = Console.ReadLine();
                foreach (Coche item in listaCoche.ToList())
                {
                    if (buscar == item.ID)
                    {
                    Console.WriteLine("| Id : {0} | Marca : {1} | Modelo : {2} | Km : {3} | Precio : {4}",
                                         item.ID, item.Marca, item.Modelo, item.KM, item.Precio);
                    Console.WriteLine("---------------------------------\n\n");
                        Console.WriteLine("Ingrese ID del coche : ");
                        coche.ID = Console.ReadLine();
                        item.ID = coche.ID;
                        Console.WriteLine("Ingrese la Marca del coche : ");
                        coche.Marca = Console.ReadLine();
                        item.Marca = coche.Marca;
                        Console.WriteLine("Ingrese el Modelo del coche : ");
                        coche.Modelo = Console.ReadLine();
                        item.Modelo = coche.Modelo;
                        Console.WriteLine("Ingrese los Km del coche : ");
                        coche.KM = int.Parse(Console.ReadLine());
                        item.KM = coche.KM;
                        Console.WriteLine("Ingrese el precio del coche : ");
                        coche.Precio = int.Parse(Console.ReadLine());
                        item.Precio = coche.Precio;
                        Console.WriteLine("\n");
                        Console.WriteLine("Los atos han sido modificados");

                    }    
                }


            }
        }

        public void buscar() {
            if (listaVacia() == true)
            {
                Console.WriteLine("No hay coches registrados");
            }
            else
            {
                string buscar;
                Console.WriteLine("Ingrese la ID del coche para buscar : ");
                buscar = Console.ReadLine();

                foreach (Coche item in listaCoche.ToList())
                {
                    if (buscar == item.ID)
                    {
                        Console.WriteLine("| Id : {0} | Marca : {1} | Modelo : {2} | Km : {3} | Precio : {4}",
                                         item.ID, item.Marca, item.Modelo, item.KM, item.Precio);
                    }
                    else
                    {
                        Console.WriteLine("No se encontró el coche");
                    }
                }
            }
        }

    }
}
