using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
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
        private int _Precio;
        public int ID { 
            get { return _ID; } 
            set { _ID = value; } 
        }
        public string Marca { 
            get { return _Marca; }
            set { Marca = value; } 
        }
        public string Modelo { 
            get { return _Modelo; } 
            set { Modelo = value; } 
        }
        public int KM { 
            get { return _KM; } 
            set { KM = value; } 
        }
        public int Precio { 
            get { return _Precio;  } 
            set { _Precio = value; }
        }
        public Coche(int id, string marca, string modelo, int km, int precio)
        {
            ID = id;
            Marca = marca;
            Modelo = modelo;
            KM = km;
            Precio = precio;
        }
        public override string ToString()
        {
            return "ID: " + _ID + " Marca: " + _Marca + " Modelo: " + _Modelo +" Kilometraje: " + _KM + " Precio: "+ _Precio;
        }
    }
}
