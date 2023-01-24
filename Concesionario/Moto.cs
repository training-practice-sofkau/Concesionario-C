using System;

namespace Concesionario
{
    public class Moto : Coche
    {
        private bool _sidecar;

        public bool Sidecar
        {
            get { return _sidecar; }
            set { _sidecar = value; }
        }

        public Moto(int id, string marca, string modelo, int km, int precio, bool sidecar)
        {
            Sidecar = sidecar;
        }

        public override Precio()
        {
            if (Sidecar)
            {
                return base.Precio() + 3500000;
            }
            else
            {
                return base.Precio();
            }
        }

        public override string toString()
        {
            return base.toString() + " Sidecar: " + Sidecar;
        }


    }
}
