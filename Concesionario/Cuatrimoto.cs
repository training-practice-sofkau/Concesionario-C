using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Concesionario
{
    internal class Cuatrimoto : Coche
    {

        private Boolean trasmisionAutomatica;


        public Cuatrimoto(int id, string marca, string modelo, int km, int precio, Boolean trasmisionAutomatica) : base(id, marca, modelo, km, precio)
        {
            this.trasmisionAutomatica = trasmisionAutomatica;
        }

        public bool TrasmisionAutomatica { get => trasmisionAutomatica; set => trasmisionAutomatica = value; }


        public override int Precio
        {
            get
            {
                return trasmisionAutomatica ? Precio + 2000000 : Precio;

            }                      
                
        }
      
    } 
}            




