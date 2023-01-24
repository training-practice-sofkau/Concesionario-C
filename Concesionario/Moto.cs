using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concesionario
{
    public class Moto : Coche
    {
        private bool _sidecar;

        public bool Sidecar
        {
            get { return _sidecar; }
            set { _sidecar = value; }
        }

        public Moto(int id, string marca, string modelo, int km, int precio, bool sidecar) : base(id, marca, modelo, km, precio)
        {
            Sidecar = sidecar;

            if (Sidecar)
            {
                Precio = base.Precio + 3500000;
            }
            else
            {
                Precio = base.Precio;
            }
        }


        public string toString()
        {
            return base.toString() + " Sidecar: " + Sidecar;
        }


    }
}
