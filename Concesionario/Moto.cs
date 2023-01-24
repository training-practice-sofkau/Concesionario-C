using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concesionario
{
	internal class Moto : Coche
	{
		private bool sidecar;
		public Moto(int idCoche, string marcaCoche, string modeloCoche, int kmCoche, int precioCoche) : base(idCoche, marcaCoche, modeloCoche, kmCoche, precioCoche)
		{
		}

		public bool Sidecar
		{
			get { return sidecar; }
			set { sidecar = value; }
		}

		public override int Precio
		{
			get { return base.Precio; }
			set { base.Precio = value; }
		}

		public void VerificarPrecio(Moto moto)
		{
			if (sidecar)
			{
				moto.Precio += 3500000;
			}
		}
	}
}
