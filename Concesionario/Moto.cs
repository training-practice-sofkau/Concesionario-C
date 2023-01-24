using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concesionario
{
    internal class Moto : Coche
    {
        public Moto(int id, string marca, string modelo, int km, int precio) : base(id, marca, modelo, km, precio)
        {
        }
    }
}
