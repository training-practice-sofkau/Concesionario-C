using System;

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

        public Cuatrimoto(int id, string marca, string modelo, int km, int precio, bool transmisionAutomatica)
        {
            TransmisionAutomatica = transmisionAutomatica;
        }


        public override Precio()
        {
            if (TransmisionAutomatica)
            {
                return base.Precio() + 2000000;
            }
            else
            {
                return base.Precio();
            }
        }

        public override string toString()
        {
            return base.toString() + " Transmision Automatica: " + TransmisionAutomatica;
        }
    }
}
