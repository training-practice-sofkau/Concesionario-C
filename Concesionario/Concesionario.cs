using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concesionario
{
    internal class Concesionario
    {
        List<Coche> listaCoche = new List<Coche> ();
        int Id;
        string Marca;
        string Modelo;
        int Km;
        double Precio;

        public void CrearCoche() {

            Console.WriteLine("---------------Crear Coche---------------");
            Console.WriteLine("\n");

            Console.WriteLine("Ingrese la ID");
            Id = int.Parse(Console.ReadLine());

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
                Console.WriteLine("No hay datos en la lista");
            }
            else { 
                Console.WriteLine("Total de registro de coches : " + listaCoche.Count);
                Console.WriteLine("-------Lista-------");
                
                foreach(Coche item in listaCoche){
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
    }
}
