using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concesionario
{
    class Coche
    {
        private int _ID;
        private string _Marca;
        private string _Modelo;
        private int _KM;
        private double _Precio;


        //Construcctor
        public Coche(int id, string marca, string modelo, int km, int precio)
        {
            this._ID = id;
            this._Marca = marca;
            this._Modelo = modelo;
            this._KM = km;
            this._Precio = precio;
        }

        //Getters And Setters
        public int ID { get => _ID; set => _ID = value; }
        public string Marca { get => _Marca; set => _Marca = value; }
        public string Modelo { get => _Modelo; set => _Modelo = value; }
        public int KM { get => _KM; set => _KM = value; }
        public virtual double Precio { get => _Precio; set => _Precio = value; }
        //Metodo To String
        public override string ToString()
        {
            return "Marca: " + Marca + " Modelo: " + Modelo + " Kilometros: " + KM + " Precio: " + Precio;
        }

    }
}
