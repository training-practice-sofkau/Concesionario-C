using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concesionario
{
    abstract class Coche
    {
        private int ID;
        private string Marca;
        private string Modelo;
        private int KM;
        private int Precio;

        public int GetID()
        {
            return ID;
        }

        public void SetID(int value)
        {
            ID = value;
        }

        public string GetMarca()
        {
            return Marca;
        }

        public void SetMarca(string value)
        {
            Marca = value;
        }

        public string GetModelo()
        {
            return Modelo;
        }

        public void SetModelo(string value)
        {
            Modelo = value;
        }

        public int GetKM()
        {
            return KM;
        }

        public void SetKM(int value)
        {
            KM = value;
        }

        public int GetPrecio()
        {
            return Precio;
        }

        public void SetPrecio(int value)
        {
            Precio = value;
        }

        public Coche(int id, string marca, string modelo, int km, int precio)
        {
            SetID(id);
            SetMarca(marca);
            SetModelo(modelo);
            SetKM(km);
            SetPrecio(precio);
        }

        public override string ToString()
        {
            return "ID: " + GetID() + "\nMarca: " + GetMarca() + "\nModelo: " + GetModelo() + "\nKM: " + GetKM()
                + "\nPrecio: " + GetPrecio();
        }
    }
}
