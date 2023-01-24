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
            }
        }

        public void EditarCoche(Coche coche)
        {
            foreach(Coche aux in _cocheList)
            {
                if(aux.ID== coche.ID)
                {
                    _cocheList.Remove(aux);
                }
            }
        }

        public void ListarCoches()
        {
            foreach(Coche coche in _cocheList)
            {
                Console.WriteLine(coche);
            }
        }

        public void EliminarCoche(Coche coche)
        {

        }

    }
}
