using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concesionario
{
    class Coche
    {
        public int ID { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int KM { get; set; }
        public int Precio { get; set; }

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
            return $"ID: {ID} \n Marca: {Marca} \n Modelo: {Modelo} \n Km: {KM} \n Precio: {Precio}";
        }

    }
}
