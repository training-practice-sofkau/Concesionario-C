
using Concesionario;

internal class Program
{
    private static void Main(string[] args)
    {
        

        Cuatrimoto cu = new Cuatrimoto("1", "Honda", "2014", 20, 300000, false);
        Moto m = new Moto("2", "Toyota", "2022", 30, 25000, true);
        
        Console.WriteLine(cu.ToString());
        Console.WriteLine(m.ToString());
        Console.WriteLine("\n");
        Console.WriteLine("\n");
        Console.WriteLine("\n");
        Console.WriteLine("\n");
        Console.WriteLine("\n");


        Menu start = new Menu();
        start.Iniciar();
        Console.ReadLine();
    }
}