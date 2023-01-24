using Concesionario;
using System.Reflection;
using System.Text.RegularExpressions;

internal class Program
{
    private static void Main(string[] args)
    {
        Conccesionario conccesionario = new Conccesionario(5);


        Coche c1 = new Coche(1, "yamaha", "2022", 4500, 5800000);
        Coche c2 = new Coche(2, "pulsar", "2021", 10000, 8800000);
        Coche c3 = new Coche(3, "auteco", "2018", 8900, 3500000);

        conccesionario.añadirCoche(c1);
        conccesionario.añadirCoche(c2);
        conccesionario.añadirCoche(c3);

        Console.WriteLine("todos los coches");
        conccesionario.listarCoches();

        conccesionario.eliminarCoche(c1);
        Console.WriteLine("todos los coches");
        conccesionario.listarCoches();

        Coche c4 = new Coche(3, "nissan", "2016", 9600, 4500000);
        conccesionario.editarCoche(c4);

        conccesionario.listarCoches();




    }
}