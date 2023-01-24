
using Concesionario;

internal class Program
{
    private static void Main(string[] args)
    {
        Coche c = new Coche(1, "Ferrari", "2014", 300, 5000);

        Cuatrimoto cu = new Cuatrimoto(2, "Honda", "2014", 20, 300000, false);
        Moto m = new Moto(3, "Toyota", "2022", 30, 25000, true);
        
        Console.WriteLine(cu.ToString());
        Console.WriteLine(m.ToString());



        Console.ReadLine();
    }
}