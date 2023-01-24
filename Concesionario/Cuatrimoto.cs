using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concesionario
{
	internal class Cuatrimoto : Coche
	{
		private bool transmision = false;
		public Cuatrimoto(int idCoche, string marcaCoche, string modeloCoche, int kmCoche, int precioCoche) : base(idCoche, marcaCoche, modeloCoche, kmCoche, precioCoche)
		{
		}

		public bool Transmision
		{
			get { return transmision; }
			set { transmision = value; }
		}

		public override int Precio
		{
			get { return base.Precio; } set { base.Precio = value; }
		}

		public void VerificarPrecio(Cuatrimoto cuatri)
		{
			if (transmision)
			{
				cuatri.Precio += 2000000;
			}
		}
	}
}
