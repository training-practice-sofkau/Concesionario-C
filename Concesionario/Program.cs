using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concesionario
{
    class Program
    {
        public Program()
        {
            Coche coche = new Coche(1, "Ford", "Fiesta", 10000, 10000000);
            Moto moto = new Moto(2, "Yamaha", "R1", 1000, 5000000, true);
            Cuatrimoto cuatrimoto = new Cuatrimoto(3, "Yamaha", "Raptor", 1000, 5000000, true);

            Console.WriteLine(coche.toString());
            Console.WriteLine(moto.toString());
            Console.WriteLine(cuatrimoto.toString());

            Concesionario concesionario = new Concesionario();

            concesionario.añadirCoche(coche);
            concesionario.añadirCoche(moto);
            concesionario.añadirCoche(cuatrimoto);

            Console.WriteLine();
            Console.WriteLine("Listado de coches");
            concesionario.listarCoches();

            Console.WriteLine();
            Console.WriteLine("Editando coche");
            concesionario.editarCoche(1, "Ford", "Focus", 20000, 20000000);
            concesionario.listarCoches();

            Console.WriteLine();
            Console.WriteLine("Editando Moto");
            concesionario.editarMoto(2, "Yamaha", "R1", 2000, 6000000, false);

            Console.WriteLine();
            Console.WriteLine("Editando Cuatrimoto");
            concesionario.editarCuatrimoto(3, "Yamaha", "Raptor", 2000, 6000000, false);

            Console.WriteLine();
            Console.WriteLine("Eliminando coche");
            concesionario.eliminarCoche(1);

            Console.WriteLine();
            Console.WriteLine("Listado de coches");
            concesionario.listarCoches();

            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            Program program = new Program();
        }
    }

}

