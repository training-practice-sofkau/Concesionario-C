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
            for (int i = 0; i < vehiculeArray.Length; i++)
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

        //Enlistamiento de todos los vehiculos
        public void List()
        {
            Console.WriteLine("Vehiculos: ");
            foreach (var coche in vehiculeArray)
            {
                Console.WriteLine(coche.ToString() + "\n");
            }
        }
        //eliminacion de vehiculos
        public void Delete(Coche deleteV)
        {
            for (int i = 0; i < vehiculeArray.Length; i++)
            {
                if (vehiculeArray[i] != null && vehiculeArray[i].ID == deleteV.ID)
                {
                    vehiculeArray = vehiculeArray.Where(e => e != deleteV).ToArray();
                }
            }
        }
        public Consesionario(int limitCar) { 
            limitCar = limitCar;
            vehiculeArray = new Coche[limitCar];
        }
    }
}
