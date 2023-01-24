using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concesionario
{

    /// <summary>
    /// Clase representativa de un coche tipo cuatrimoto
    /// </summary>
    internal class Cuatrimoto : Coche
    {

        private bool transmission;
        /// <summary>
        /// Metodo constructor de coche tipo cuatrimoto
        /// </summary>
        /// <param name="id">id unico de una cuatrimoto</param>
        /// <param name="marca">marca unica de una cuatrimoto</param>
        /// <param name="modelo">modelo unico de una cuatrimoto</param>
        /// <param name="km">kilometros que tiene una cuatrimoto</param>
        /// <param name="precio">precio en millones de una cuatrimoto</param>
        /// <param name="transmission">bandera encargada de alterar el precio</param>
        public Cuatrimoto(int id, string marca, string modelo, int km, int precio, bool transmission) : base(id, marca, modelo, km, precio)
        {

            this.id = id;
            this.marca = marca;
            this.modelo = modelo;
            this.km = km;
            this.precio = precio;
            this.transmission = transmission;

        }

        /// <summary>
        /// Metodo encargado de modificar y optener el valor logico de una cuatrimoto
        /// </summary>
        public bool Transmission
        {

            get { return transmission; }

            set { transmission = value; }
        }

        /// <summary>
        /// Metodo encargado de obtener y modificar el precio segun sea la transmicion
        /// </summary>
        public override int Precio
        {

            get { if (transmission == true) { return precio + 2000000; } return precio; }
            set { precio = value; }


        }


    }

}
