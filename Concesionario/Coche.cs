using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concesionario
{
    class Coche
    {
        private int _id;
        private string _marca;
        private string _modelo;
        private int _km;
        private int _precio;

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Marca
        {
            get { return _marca; }
            set { _marca = value; }
        }

        public string Modelo
        {
            get { return _modelo; }
            set { _modelo = value; }
        }

        public int KM
        {
            get { return _km; }
            set { _km = value; }
        }

        public int Precio
        {
            get { return _precio; }
            set { _precio = value; }
        }


        public Coche(int id, string marca, string modelo, int km, int precio)
        {
            ID = id;
            Marca = marca;
            Modelo = modelo;
            KM = km;
            Precio = precio;
        }

        public toString()
        {
            return "ID: " + ID + " Marca: " + Marca + " Modelo: " + Modelo + " KM: " + KM + " Precio: " + Precio;
        }
    }
}
