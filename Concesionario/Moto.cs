using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concesionario
{
    internal class Moto : Coche
    {
        private bool _sidecar;
        public Moto(int id, string marca, string modelo, int km, int precio, bool sidecar) : base(id, marca, modelo, km, precio)
        {
            _sidecar = sidecar;
            if(sidecar)
            {
                base.Precio= precio + 3500000;
            }
        }
    }
}
