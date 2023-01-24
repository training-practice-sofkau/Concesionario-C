using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concesionario
{
    internal class Concesionario
    {
        private List<Coche> _cocheList;
        private int _limiteCoches;

        public Concesionario(int limiteCoches)
        {
            _cocheList = new List<Coche>();
            LimiteCoches = limiteCoches;
        }

        public int LimiteCoches { get => _limiteCoches; set => _limiteCoches = value; }


        public void AgregarCoche(Coche coche)
        {
            if(_cocheList.Count < _limiteCoches)
            {
                _cocheList.Add(coche);
                Console.WriteLine("El coche fue agregado con éxito");
            }
        }

        public bool buscarCoche(int id)
        {
            foreach(Coche coche in _cocheList)
            {
                if(coche.ID == id) return true;
            }
            Console.WriteLine("El coche no existe en el concesionario");
            return false;
        }

        public void EditarCoche(Coche coche)
        {
            foreach(Coche aux in _cocheList)
            {
                if(aux.ID== coche.ID)
                {
                    aux.Marca = coche.Marca;
                    aux.Modelo= coche.Modelo;
                    aux.KM= coche.KM;
                    aux.Precio= coche.Precio;

                    Console.WriteLine($"El coche con ID {coche.ID} fue modificado con éxito");
                }
            }
        }

        public void ListarCoches()
        {
            foreach(Coche coche in _cocheList)
            {
                Console.WriteLine("-----------------------");
                Console.WriteLine(coche);
                Console.WriteLine("-----------------------");
            }
        }

        public void EliminarCoche(int idCoche)
        {
            foreach(Coche coche in _cocheList)
            {
                if(coche.ID == idCoche)
                {
                    _cocheList.Remove(coche);
                    Console.WriteLine($"El coche con ID: {idCoche} fue eliminado con exito");
                    return;
                }
            }
            Console.WriteLine($"El coche con ID: {idCoche} no fue encontrado en el concesionario");
        }

    }
}
