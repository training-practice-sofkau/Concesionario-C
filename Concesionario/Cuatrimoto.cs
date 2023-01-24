using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concesionario
{
    public class Cuatrimoto : Coche
    {

        private bool _transmisionAutomatica;

        public bool TransmisionAutomatica
        {
            get { return _transmisionAutomatica; }
            set { _transmisionAutomatica = value; }
        }

        public Cuatrimoto(int id, string marca, string modelo, int km, int precio, bool transmisionAutomatica) : base(id, marca, modelo, km, precio)
        {
            TransmisionAutomatica = transmisionAutomatica;

            if (TransmisionAutomatica)
            {
                Precio = base.Precio + 2000000;
            }
            else
            {
                Precio = base.Precio;
            }
        }


        public string toString()
        {
            return base.toString() + " Transmision Automatica: " + TransmisionAutomatica;
        }
    }
}
