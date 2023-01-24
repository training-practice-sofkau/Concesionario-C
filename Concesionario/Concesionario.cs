using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concesionario
{
    public class Concesionario
    {
        public Coche[] coches;

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

        public void editarMoto(int id, string marca, string modelo, int km, int precio, bool sidecar)
        {
            for (int i = 0; i < coches.Length; i++)
            {
                if (coches[i].ID == id)
                {
                    coches[i].Marca = marca;
                    coches[i].Modelo = modelo;
                    coches[i].KM = km;
                    coches[i].Precio = precio;
                    ((Moto)coches[i]).Sidecar = sidecar;
                    break;
                }
            }
        }

        public void editarCuatrimoto(int id, string marca, string modelo, int km, int precio, bool transmisionAutomatica)
        {

            for (int i = 0; i < coches.Length; i++)
            {
                if (coches[i].ID == id)
                {
                    coches[i].Marca = marca;
                    coches[i].Modelo = modelo;
                    coches[i].KM = km;
                    coches[i].Precio = precio;
                    ((Cuatrimoto)coches[i]).TransmisionAutomatica = transmisionAutomatica;
                    break;
                }
            }
        }


        public void listarCoches()
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
