using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concesionario
{
    /// <summary>
    /// Clase representativa de un coche
    /// </summary>
    class Coche
    {
        protected int id;
        protected string marca;
        protected string modelo;
        protected int km;
        protected int precio;


        /// <summary>
        /// Metodo encargado de modificar y optener el id del coche
        /// </summary>
        public int ID
        {

            get { return id; }
            set { id = value; }
        }


        /// <summary>
        /// Metodo encargado de modificar y optener la marca del coche
        /// </summary>
        public string Marca
        {

            get { return marca; }
            set { marca = value; }


        }

        /// <summary>
        /// Metodo encargado de modificar y optener el modelo del coche
        /// </summary>
        public string Modelo
        {

            get { return modelo; }
            set { modelo = value; }

        }


        /// <summary>
        /// Metodo encargado de modificar y optener el kilometraje del coche
        /// </summary>
        public int Km
        {

            get { return km; }
            set { km = value; }

        }

        /// <summary>
        /// Metodo encargado de modificar y optener el precio del coche
        /// </summary>
        public virtual int Precio
        {
            get { return precio; }
            set { precio = value; }

        }

        /// <summary>
        /// Metodo constructor de coche
        /// </summary>
        /// <param name="id">id unico del coche</param>
        /// <param name="marca">marca unica del coche</param>
        /// <param name="modelo">modelo unico del coche</param>
        /// <param name="km">kilometraje unico del coche</param>
        /// <param name="precio">precio del coche en millones</param>
        public Coche(int id, string marca, string modelo, int km, int precio)
        {
            ID = id;
            Marca = marca;
            Modelo = modelo;
            Km = km;
            Precio = precio;
        }

        /// <summary>
        /// Metodo encargado de mostrar en pantalla los atributos  de 1 coche
        /// </summary>
        /// <returns></returns>
        public string ToString()
        {
            return $"El coche con el  Id: {ID}, de Marca: {Marca}, Modelo {Modelo}, con kilometraje: {Km} y un excelente precio: ${Precio}";
        }

    }
}
