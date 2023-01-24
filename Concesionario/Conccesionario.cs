using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concesionario
{
    internal class Conccesionario
    {

        private Coche[] coches;
        private int limite;
        private int numeroCoches;

        public Conccesionario(int limite)
        {

            this.coches = new Coche[limite];
            this.limite = limite;
            numeroCoches = 0;

        }

        public int Limite { get => limite; set => limite = value; }

        public void añadirCoche(Coche c)
        {
            if (c != null && numeroCoches < coches.Length)
            {
                coches[numeroCoches] = c;
                numeroCoches++;
            }

        }

        public void listarCoches()
        {
            for (int i = 0; i < numeroCoches; i++)
            {
                Console.WriteLine(coches[i].ID + coches[i].Marca + coches[i].Modelo + coches[i].KM + coches[i].Precio);
            }

        }

        public void editarCoche(Coche c)
        {
            {
                for (int i = 0; i < coches.Length; i++)
                {
                    if (coches[i] != null && coches[i].ID == c.ID)
                    {
                        coches[i].Modelo = c.Modelo;
                        coches[i].Marca = c.Marca;
                        coches[i].KM = c.KM;
                        coches[i].Precio = c.Precio;
                    }
                }
            }

        }

        public void eliminarCoche(Coche c)
        {
            if (c != null && numeroCoches != 0)
            {

                int posicion = -1;
                for (int i = 0; i < numeroCoches; i++)
                {
                    if (c.ID == coches[i].ID)
                    {
                        posicion = i;
                    }
                }

                if (posicion == -1)
                {
                    Console.WriteLine("No existe el coche");
                }
                else
                {
                    coches[posicion] = null;

                    for (int i = posicion; i < numeroCoches; i++)
                    {
                        coches[i] = coches[i + 1];

                    }

                    numeroCoches--;

                }

            }
        }

    }
}


