using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concesionario
{
    internal class Consesionario
    {
        private int limitCar;
        private Coche[] vehiculeArray;

        public int LimitCar
        {
            get { return limitCar;  }
            set { limitCar = value; }
        }

        //Añadimos los vehiculos en este metodo
        public void AddV(int deposit, Coche coche)
        {
            if (deposit < limitCar)
            {
                vehiculeArray[deposit] = coche;
                Console.WriteLine("Coche guardado"+deposit);
            }
            else
            {
                Console.WriteLine("Deposito lleno");
            }
        }
        //Editamos los vehiculos en este metodo
        public void EditV(Coche EditV)
        {
            for (int i = 0; i < vehiculeArray.length; i++)
            {
                if (vehiculeArray[i] != null && vehiculeArray[i].ID == EditV.ID)
                {
                    vehiculeArray[i].ID = EditV.ID;
                    vehiculeArray[i].Marca = EditV.Marca;
                    vehiculeArray[i].Modelo = EditV.Modelo;
                    vehiculeArray[i].KM = EditV.KM;
                    vehiculeArray[i].Precio = EditV.Precio;
                }
            }
        }

        public Consesionario(int limitCar) { 
            limitCar = limitCar;
            vehiculeArray = new Coche[limitCar];
        }
    }
}
