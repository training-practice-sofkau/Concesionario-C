using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concesionario
{
    class Concesionario
    {
        private int limiteCoches;
        private Coche[] cochesArray;
        public int LimiteCoches { get => limiteCoches; set => limiteCoches = value; }

        public void AñadirCoche(int bahia, Coche coche)
        {
            if (bahia < limiteCoches)
            {
                cochesArray[bahia] = coche;
                Console.WriteLine("Coche almacenado en la bahia: " + bahia + "\n");
            }
            else
            {
                Console.WriteLine("\nConcesionario lleno.\n");
            }
        }

        public void EditarCoche(Coche cocheEditar)
        {
            for (int i = 0; i < cochesArray.Length; i++)
            {
                if (cochesArray[i] != null && cochesArray[i].GetID() == cocheEditar.GetID())
                {
                    cochesArray[i].SetID(cocheEditar.GetID());
                    cochesArray[i].SetMarca(cocheEditar.GetMarca());
                    cochesArray[i].SetModelo(cocheEditar.GetModelo());
                    cochesArray[i].SetKM(cocheEditar.GetKM());
                    cochesArray[i].SetPrecio(cocheEditar.GetPrecio());
                }
            }
        }

        public void ListarCoches()
        {
            Console.WriteLine("\n---------------- LISTADO DE COCHES ------------------");
            foreach (var coche in cochesArray)
            {
                Console.WriteLine(coche.ToString() + "\n");
            }
        }

        public void EliminarCoche(Coche cocheEliminar)
        {
            for (int i = 0; i < cochesArray.Length; i++)
            {
                if (cochesArray[i] != null && cochesArray[i].GetID() == cocheEliminar.GetID())
                {
                    cochesArray = cochesArray.Where(elemento => elemento != cocheEliminar).ToArray();
                }
            }
        }

        public Concesionario(int limiteCoches)
        {
            LimiteCoches = limiteCoches;
            cochesArray = new Coche[limiteCoches];
        }
    }
}
