using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Concesionario
{
    class Moto : Coche
    {
        private bool sidecar;
        public bool GetSidecar()
        {
            return sidecar;
        }

        public void SetSidecar(bool value)
        {
            sidecar = value;
        }

        public Moto(int id, string marca, string modelo, int km, int precio, bool sidecar) : base(id, marca, modelo, km, precio)
        {
            SetSidecar(sidecar);
            if (GetSidecar())
            {
                base.SetPrecio(precio + 3500000);
            }
        }
    }
}
