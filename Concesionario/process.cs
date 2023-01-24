using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concesionario
{
    internal class process
    {


        public string brand;
        public string model;
        public int mileage;
        public int price;
        public string optionQuadBike;
        public string optionBike;



        public Coche addCoche(int newid)
        {
            try
            {
                Console.WriteLine("---------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("Cual es la marca?");
                brand = Console.ReadLine();
                Console.WriteLine("---------------------------------------------------------------------------------------------------------------");

                Console.WriteLine("Cual es el modelo");
                model = Console.ReadLine();
                Console.WriteLine("---------------------------------------------------------------------------------------------------------------");

                Console.WriteLine("Cuanto kilometraje tiene?");
                mileage = int.Parse(Console.ReadLine());
                Console.WriteLine("---------------------------------------------------------------------------------------------------------------");

                Console.WriteLine("Cual es su precio?");
                price = int.Parse(Console.ReadLine());
                Console.WriteLine("Coche almacenado");
                Console.WriteLine("---------------------------------------------------------------------------------------------------------------");

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Ingresa valores adecuados para que el programa funcione correctamente");


            }

            Coche objectCoche = new Coche(newid, brand, model, mileage, price);

            return objectCoche;


        }


        public Coche addQuadBike(int newid)
        {

            bool flag1 = false;
            try
            {
                Console.WriteLine("---------------------------------------------------------------------------------------------------------------");

                Console.WriteLine("Cual es la marca?");
                brand = Console.ReadLine();
                Console.WriteLine("---------------------------------------------------------------------------------------------------------------");

                Console.WriteLine("Cual es el modelo");
                model = Console.ReadLine();
                Console.WriteLine("---------------------------------------------------------------------------------------------------------------");

                Console.WriteLine("Cuanto kilometraje tiene?");
                mileage = int.Parse(Console.ReadLine());
                Console.WriteLine("---------------------------------------------------------------------------------------------------------------");

                Console.WriteLine("Cual es su precio?");
                price = int.Parse(Console.ReadLine());
                Console.WriteLine("---------------------------------------------------------------------------------------------------------------");

                Console.WriteLine("Tiene trasmision  automatica?");
                optionQuadBike = Console.ReadLine();
                Console.WriteLine("---------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("Cuatrimoto almacemada");
                Console.WriteLine("---------------------------------------------------------------------------------------------------------------");

            }
            catch (Exception)
            {
                Console.WriteLine("Por favor ingresa valores validos para el buen funcionamiento del programa");
            }

            if (optionQuadBike == "si" || optionQuadBike == "SI" || optionQuadBike == "sI" || optionQuadBike == "Si")
            {
                flag1 = true;
            }
            Coche objectCoche = new Cuatrimoto(newid, brand, model, mileage, price, flag1);
            return objectCoche;

        }

        public Coche addBike(int newid)
        {
            bool flag2 = false;
            try
            {
                Console.WriteLine("---------------------------------------------------------------------------------------------------------------");

                Console.WriteLine("Cual es la marca?");
                brand = Console.ReadLine();
                Console.WriteLine("---------------------------------------------------------------------------------------------------------------");

                Console.WriteLine("Cual es el modelo");
                model = Console.ReadLine();
                Console.WriteLine("---------------------------------------------------------------------------------------------------------------");

                Console.WriteLine("Cuanto kilometraje tiene?");
                mileage = int.Parse(Console.ReadLine());
                Console.WriteLine("---------------------------------------------------------------------------------------------------------------");

                Console.WriteLine("Cual es su precio?");
                price = int.Parse(Console.ReadLine());
                Console.WriteLine("---------------------------------------------------------------------------------------------------------------");

                Console.WriteLine("Tiene sidecar?");
                optionBike = Console.ReadLine();
                Console.WriteLine("---------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("Moto almacenada");
                Console.WriteLine("---------------------------------------------------------------------------------------------------------------");


            }
            catch (Exception)
            {
                Console.WriteLine("Por favor ingresa valores validos pa un buen funcionamiento del codigo");
            }

            if (optionBike == "si" || optionBike == "SI" || optionBike == "sI" || optionBike == "Si")
            {
                flag2 = true;
            }
            Coche objectCoche = new Moto(newid, brand, model, mileage, price, flag2);
            return objectCoche;
        }

    }

}
