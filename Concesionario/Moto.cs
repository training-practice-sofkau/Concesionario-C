using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concesionario
{
    /// <summary>
    /// Metodo representativo de un coche tipo motocicleta
    /// </summary>
    internal class Moto : Coche
    {

        /// <summary>
        /// Bandera si contiene o no sidecar
        /// </summary>
        private bool sidecar;

        /// <summary>
        /// Metodo constructor de un coche tipo motocicleta
        /// </summary>
        /// <param name="id">id unico de una cuatrimoto</param>
        /// <param name="marca">marca unica de una cuatrimoto</param>
        /// <param name="modelo">modelo unico de una cuatrimoto</param>
        /// <param name="km">kilometros que tiene una cuatrimoto</param>
        /// <param name="precio">precio en millones de una cuatrimoto</param>
        /// <param name="sidecar">Bandera encargada de alterar el precio del coche</param>
        public Moto(int id, string marca, string modelo, int km, int precio, bool sidecar) : base(id, marca, modelo, km, precio)
        {
            this.id = id;
            this.marca = marca;
            this.modelo = modelo;
            this.km = km;
            this.precio = precio;
            this.sidecar = sidecar;
        }

        /// <summary>
        /// Metodo encargado de modificar y optener el valor logico de un coche tipo motocicleta
        /// </summary>
        public bool Sidecar
        {

            get { return sidecar; }
            set { sidecar = value; }

        }

        /// <summary>
        /// Metodo encargado de obtener y modificar el precio segun sea el sidecar
        /// </summary>
        public override int Precio
        {

            get { if (sidecar == true) { return precio + 3500000; } return precio; }
            set { precio = value; }


        }

    }
}
