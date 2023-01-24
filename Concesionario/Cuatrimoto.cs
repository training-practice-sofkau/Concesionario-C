using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concesionario
{
    internal class Cuatrimoto : Coche
    {
        private string transmission;
        public string Transmission
        {
            get { return transmission; }
            set { transmission = value; }
        }
        
        public Cuatrimoto(int id, string marca, string modelo, int km, int precio, string transmission) : base(id, marca, modelo, km, precio)
        {
            this.transmission = transmission;
            if (transmission == "Automatico")
            {
                //Aumenta el precio por ser automatico
                base.Precio = (precio += 2000000);
                //Console.WriteLine("Here 1 cuatrimoto");
            }
        }
    }
}
