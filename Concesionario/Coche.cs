using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concesionario
{
    class Coche
    {
        private string _ID { get; set; }
        private string _Marca { get; set; }
        private string _Modelo { get; set; }
        private int _KM { get; set; }
        private double _Precio { get; set; }



        //Construcctor
        public Coche(string id, string marca, string modelo, int km, double precio)
        {
            this._ID = id ;
            this._Marca = marca;
            this._Modelo = modelo;
            this._KM = km;
            this._Precio = precio;
        }

        public Coche()
        {
        }

        //Getters And Setters
        public string ID { get => _ID; set => _ID = value; }
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
