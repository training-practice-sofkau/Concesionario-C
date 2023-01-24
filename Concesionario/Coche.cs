using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Concesionario
{
     abstract class Coche
    {
        private int iD;
        private string marca;
        private string modelo;
        private int km;
        private int precio;

        public Coche(int id, string marca, string modelo, int km, int precio)
        {
            this.ID = id;
            this.Marca = marca;
            this.Modelo = modelo;
            this.km = km;
            this.Precio = precio;
        }

        public int ID { get => iD; set => iD = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public int KM { get => km; set => km = value; }
        public virtual int Precio { get => precio; set => precio = value; }

        public override string? ToString()
        {
            return "Id : " + ID + "Marca :" + Marca + "Modelo :" + Modelo + "KM : " + km + "precio : " + Precio;
        }

       
    }
}
