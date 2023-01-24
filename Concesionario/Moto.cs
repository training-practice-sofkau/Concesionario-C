using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concesionario
{
    internal class Moto : Coche
    {
        private bool sidecar;
        public bool Sidecar
        {
            get { return sidecar; }
            set { sidecar = value; }
        }
        public Moto(int id, string marca, string modelo, int km, int precio, bool sidecar) : base(id, marca, modelo, km, precio)
        {
            this.sidecar = sidecar;
            if (sidecar == true)
            {
                //Aumenta el precio por tener sidecar
                base.Precio = (precio += 3500000);
                Console.WriteLine("Here 2 moto");
            }
        }
    }
}
