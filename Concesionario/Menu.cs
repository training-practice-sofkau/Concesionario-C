using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concesionario
{
    internal class Menu
    {
        string opcionMenu = "";
        public void Iniciar(){ 
            
            do{
                cabezera();
            }while(opcionMenu !="0");
        }

        private void cabezera() {
            Console.WriteLine("-------Menu principal--------");
            Console.WriteLine("\n");
            Console.WriteLine("1. Crear coche     ||     3. Eliminar coche");
            Console.WriteLine("2. Listar coche    ||     4. Modificar coche");
            Console.WriteLine("0. Salir           ||     5. Bucar coche");
            Console.WriteLine("\n");
            Console.WriteLine("Seleccione una opccion");
            opcionMenu = Console.ReadLine();
            seleccionMenu(opcionMenu);
            
        }
        private void seleccionMenu(String seleccion) {
            if (seleccion == "0") 
                return;
            
            switch(seleccion)
            {
                default:
                    break;
            }
        }

        private void retornarMenu() {
            string seleccion;
            Console.WriteLine("Presione r para retornar al menu principal");
            seleccion = Console.ReadLine();
            seleccionMenu(seleccion);
        }
    }
}
