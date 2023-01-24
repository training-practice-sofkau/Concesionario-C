using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concesionario
{
    internal class Moto : Coche
    {

        private string sidecar;
        public Moto(int id, string marca, string modelo, int km, int precio, string sidecar) : base(id, marca, modelo, km, precio)
        {
            this.sidecar = sidecar;
        }
    }
}
