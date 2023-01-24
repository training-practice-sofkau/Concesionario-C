namespace Concesionario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escriba el límite de coches");

            int limit = int.Parse(Console.ReadLine());

            Concesionario concesionario = new Concesionario(limit);

            int menu = 0;
            do
            {
                Console.ReadKey();
                Console.WriteLine("*****************************\nSeleccione la opción que desee en el menú");
                Console.WriteLine("1: Para agregar Coche \n2: para editar un coche \n3: para listar los coches \n" +
                    "4: para Elimianr un coche \n0: para salir");
                menu = int.Parse(Console.ReadLine());


                switch (menu)
                {
                    case 1:
                        Console.WriteLine("Para Cuatrimoto digite 1 \npara Moto digite 2");
                        string opcion = Console.ReadLine();
                        if(opcion == "1")
                        {
                            Console.WriteLine("Ingrese los valores de la cuatrimoto");
                            Console.WriteLine("Ingrese el Id");
                            int idMoto = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese la marca");
                            string marca = Console.ReadLine();
                            Console.WriteLine("Ingrese el modelo");
                            string modelo = Console.ReadLine();
                            Console.WriteLine("Ingrese los KM");
                            int km = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese el precio");
                            int precio = int.Parse(Console.ReadLine());
                            Console.WriteLine("¿La cuatrimoto tiene transmisión? (S/N)");
                            bool transmision;
                            string opc = Console.ReadLine();
                            if(opc == ("s") || opc == "S")
                            {
                                transmision = true;
                            }else if(opc == "n" || opc == "N")
                            {
                                transmision = false;
                            }
                            else
                            {
                                Console.WriteLine("La opción es inválida");
                                break;
                            }

                            Cuatrimoto cuatrimoto = new Cuatrimoto(idMoto, marca, modelo, km, precio, transmision);
                            concesionario.AgregarCoche(cuatrimoto);

                        }
                        else if(opcion == "2")
                        {
                            Console.WriteLine("Ingrese los valores de la Moto");
                            Console.WriteLine("Ingrese el Id");
                            int idCuatri = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese la marca");
                            string marca = Console.ReadLine();
                            Console.WriteLine("Ingrese el modelo");
                            string modelo = Console.ReadLine();
                            Console.WriteLine("Ingrese los KM");
                            int km = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese el precio");
                            int precio = int.Parse(Console.ReadLine());
                            Console.WriteLine("¿La Moto tiene sidecar? (S/N)");
                            bool sidecar;
                            string opc = Console.ReadLine();
                            if (opc == ("s") || opc == "S")
                            {
                                sidecar = true;
                            }
                            else if (opc == "n" || opc == "N")
                            {
                                sidecar = false;
                            }
                            else
                            {
                                Console.WriteLine("La opción es inválida");
                                break;
                            }

                            Moto moto = new Moto(idCuatri, marca, modelo, km, precio, sidecar);
                            concesionario.AgregarCoche(moto);
                        }
                        else
                        {
                            Console.WriteLine("La opción no es válida");
                        }
                        break;

                    case 2:
                        Console.WriteLine("Ingrese el ID del coche a editar");
                        int idB = int.Parse(Console.ReadLine());
                        if (concesionario.buscarCoche(idB))
                        {
                            Console.WriteLine("Ingrese los nuevos valores del coche");
                            Console.WriteLine("Ingrese la marca");
                            string marca = Console.ReadLine();
                            Console.WriteLine("Ingrese el modelo");
                            string modelo = Console.ReadLine();
                            Console.WriteLine("Ingrese los KM");
                            int km = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese el precio");
                            int precio = int.Parse(Console.ReadLine());

                            Coche coche = new Coche(idB, marca, modelo, km, precio);

                            concesionario.EditarCoche(coche);
                        }
                        break;

                    case 3:
                        concesionario.ListarCoches();
                        break;

                    case 4:
                        Console.WriteLine("Ingrese el ID del coche a eliminar");
                        int idE = int.Parse(Console.ReadLine());
                        concesionario.EliminarCoche(idE); 
                        break;


                }

            } while (menu != 0);
        }
    }
}