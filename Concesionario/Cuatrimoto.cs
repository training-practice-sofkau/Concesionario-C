using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concesionario
{
    internal class Cuatrimoto : Coche
    {

        private Boolean trasmision;


        public Cuatrimoto(int id, string marca, string modelo, int km, int precio, Boolean trasmision) : base(id, marca, modelo, km, precio)
        {
            this.trasmision = trasmision;
        }

        public Boolean Trasmision { get => trasmision; set => trasmision = value; }

        public override int Precio
        {
            get
            {
                if (this.trasmision == trasmision)
                    Console.WriteLine("El precio se mantiene");

                return Precio + 200000;
            }
        }
    }
}
