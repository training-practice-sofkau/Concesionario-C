using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concesionario
{
    internal class Cuatrimoto : Coche
    {
        private bool _transmision;
        public Cuatrimoto(int id, string marca, string modelo, int km, int precio, bool transmision) : base(id, marca, modelo, km, precio)
        {
            _transmision = transmision;

            if(transmision)
            {
                base.Precio = precio + 2000000;
            }
        }
    }
}
