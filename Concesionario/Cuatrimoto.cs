using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concesionario
{
    class Cuatrimoto : Coche
    {
        private string transmision;

        public string GetTransmision()
        {
            return transmision;
        }

        public void SetTransmision(string value)
        {
            transmision = value;
        }

        public Cuatrimoto(int id, string marca, string modelo, int km, int precio, string transmision) : base(id, marca, modelo, km, precio)
        {
            SetTransmision(transmision);
            if (GetTransmision() == "Automatica")
            {
                base.SetPrecio(precio + 2000000);
            }
        }
    }
}
