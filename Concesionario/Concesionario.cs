using System;

namespace Concesionario
{
    public class Concesionario
    {
        public Coche[10] coches;

        public Concesionario()
        {
            coches = new Coche[10];
        }

        public void añadirCoche(Coche coche)
        {
            for (int i = 0; i < coches.Length; i++)
            {
                if (coches[i] == null)
                {
                    coches[i] = coche;
                    break;
                }
            }
        }

        public void editarCoche(int id, string marca, string modelo, int km, int precio)
        {
            for (int i = 0; i < coches.Length; i++)
            {
                if (coches[i].ID == id)
                {
                    coches[i].Marca = marca;
                    coches[i].Modelo = modelo;
                    coches[i].KM = km;
                    coches[i].Precio = precio;
                    break;
                }
            }
        }

        public listarCoches()
        {
            for (int i = 0; i < coches.Length; i++)
            {
                if (coches[i] != null)
                {
                    Console.WriteLine(coches[i].toString());
                }
            }
        }

        public void eliminarCoche(int id)
        {
            for (int i = 0; i < coches.Length; i++)
            {
                if (coches[i].ID == id)
                {
                    coches[i] = null;
                    break;
                }
            }
        }


    }
}
