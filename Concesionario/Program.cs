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
            // se instancia el concesionario con cinco bahias
            Concesionario concesionario = new(5);

            //instanciamos los coches para almacenar en el concesionario
            Cuatrimoto cuatrimoto1 = new(1, "Yamaha", "Tora", 0, 10000000, "Mecanica");
            Cuatrimoto cuatrimoto2 = new(2, "Yamaha", "Nexuz", 0, 10000000, "Mecanica");
            Cuatrimoto cuatrimoto3 = new(3, "Yamaha", "Nexuz v2.0", 0, 10000000, "Automatica");
            Moto moto1 = new(4, "Akt", "NKD", 500, 4500000, false);
            Moto moto2 = new(5, "Akt", "CR4", 20000, 5000000, true);
            Moto moto3 = new(6, "Akt", "CR4", 20000, 5000000, true);

            //agregamos los coches al concesionario
            concesionario.AñadirCoche(0, cuatrimoto1);
            concesionario.AñadirCoche(1, cuatrimoto2);
            concesionario.AñadirCoche(2, cuatrimoto3);
            concesionario.AñadirCoche(3, moto1);
            concesionario.AñadirCoche(4, moto2);
            concesionario.AñadirCoche(5, moto3); // no almacena ya que superaria el limite de coches del consecionario
            concesionario.ListarCoches();

            //objetos para modificar
            Cuatrimoto cuatrimoto3Editar = new(3, "Yamaha", "Nexuz", 0, 10000000, "Mecanica");
            Moto moto2Editar = new(5, "Akt", "CR4", 20000, 5000000, false);


            concesionario.EditarCoche(cuatrimoto3Editar); //edicion del coche
            concesionario.EditarCoche(moto2Editar); //edicion del coche
            concesionario.ListarCoches();

            concesionario.EliminarCoche(cuatrimoto2); //eliminacion del coche
            concesionario.EliminarCoche(moto1); //eliminacion del coche
            concesionario.ListarCoches();

            Console.ReadKey();
        }
    }
}
