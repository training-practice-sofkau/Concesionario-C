using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concesionario
{
    abstract class Coche
    {
        private int id;
        private string marca;
        private string modelo;
        private int km;
        private int precio;

        public Coche(int idCoche, string marcaCoche, string modeloCoche, int kmCoche, int precioCoche)
        {
			id = idCoche;
			marca = marcaCoche;
			modelo = modeloCoche;
			km = kmCoche;
			precio = precioCoche;
        }
        
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

		public string Marca
		{
			get { return marca; }
			set { marca = value; }
		}

		public string Modelo
		{
			get { return modelo; }
			set { modelo = value; }
		}

		public int Km
		{
			get { return km; }
			set { km = value; }
		}

		public virtual int Precio
		{
			get { return precio; }
			set { precio = value; }
		}

		public override string ToString()
		{
			return "El vehiculo " + id + " de marca " + marca + " modelo " +modelo+ " con un kilometraje de "+ km +" tiene un precio de "+precio;
		}

	}
}
