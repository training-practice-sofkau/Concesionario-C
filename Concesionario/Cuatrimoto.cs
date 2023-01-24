using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concesionario
{
    internal class Cuatrimoto : Coche
    {
        //Atributo de Cuatrimoto
        Boolean _Transmision;

        //Constructor de clase padre
        public Cuatrimoto(int id, string marca, string modelo, int km, int precio, bool transmision) : base(id, marca, modelo, km, precio)
        {
            this.Transmision = transmision;
        }

        //Contructor del atributo
        public bool Transmision { get => _Transmision; set => _Transmision = value; }

        //Modificador del atributo precio
        public override double Precio {
            get
            {
                if(this._Transmision) {return base.Precio + 2000000; }
                
                else {return base.Precio;}
            } 
        }

        //Modificador del metodo To String
        public override string ToString()
        {
            if (this.Transmision) { return base.ToString() + " Tiene transmisión"; }
            
            else { return base.ToString() + " No tiene transmisión"; }
        }

    }
}
