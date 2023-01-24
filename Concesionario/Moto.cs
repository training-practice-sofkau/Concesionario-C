using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concesionario
{
    internal class Moto : Coche
    {

        private Boolean sidecar;
        public Moto(int id, string marca, string modelo, int km, int precio, Boolean sidecar) : base(id, marca, modelo, km, precio)
        {
            this.sidecar = sidecar;
        }

        public bool Sidecar { get => sidecar; set => sidecar = value; }


        public override int Precio
        {
            get
            {
                return sidecar ? Precio + 3500000 : Precio;

            }

        }

        
    }
}
