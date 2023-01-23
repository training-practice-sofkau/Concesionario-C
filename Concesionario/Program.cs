
using Concesionario;

Coche c = new Coche(1, "Ferrari", "2014", 300, 5000);

Console.WriteLine(c.Marca);
Console.WriteLine(c.Modelo);
c.KM = 700;
Console.WriteLine(c.Precio);
Console.WriteLine(c.KM);
Console.WriteLine(c.ToString());
Console.ReadLine();
