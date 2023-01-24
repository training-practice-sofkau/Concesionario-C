using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concesionario
{
    internal class Moto : Coche
    {
        private bool _Sidecar;
        //Constructor de clase padre
        public Moto(int id, string marca, string modelo, int km, int precio, bool sidecar) : base(id, marca, modelo, km, precio)
        {
            this.Sidecar = sidecar;
        }

        //Contructor del atributo
        public bool Sidecar { get => _Sidecar; set => _Sidecar = value; }

        //Modificador del atributo precio
        public override double Precio
        {
            get
            {
                if (this._Sidecar) { return base.Precio + 3500000; }

                else { return base.Precio; }
            }
        }

        //Modificador del metodo To String
        public override string ToString()
        {
            if (this.Sidecar) { return base.ToString() + " Tiene sidecar"; }

            else { return base.ToString() + " No tiene sidecar"; }
        }
    }
}
