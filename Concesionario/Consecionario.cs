using System.Diagnostics;

namespace Concesionario
{
    /// <summary>
    /// Clase representativa de un consesionario gestor de coches de muchos tipos
    /// </summary>
    internal class Concesionario
    {


        static void Main(string[] args)
        {

            //Variable respuesta del usuario controladora de los metodos
            int reply;

            // id unico auto generado de los coches
            int newid = 0;

            //opcion controladora del ciclo del programa
            int option = 0;

            //variable encargada de almacenar el id del coche que vamos a modificar
            int optionEdit;

            //variable encargada de almacenar que tipo de vehiculo voy a modificar
            int optionType;

            //variable encargada de almacenar la posicion de la coleccion para la respectiva eliminacion
            int position;

            //objeto de clase procesos encargado de direccionarnos a los metodos gestores de coches
            process firstprocess = new process();

            //Lista de coches de todo tipo
            List<Coche> arrayVehicles = new();

            try
            {

                while (option == 0)
                {
                    Console.WriteLine("------------------------------------------BIENVENIDO-----------------------------------------------------");
                    Console.WriteLine("¿Que  te gustaria hacer?");
                    Console.WriteLine("---------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("1.Añadir un coche;  2. Editar un coche; 3. Listar los coches; 4. Eliminar un coche;");
                    reply = int.Parse(Console.ReadLine());
                    Console.WriteLine("---------------------------------------------------------------------------------------------------------------");


                    //Nos administra la eleccion que hizo el usuario
                    switch (reply)
                    {

                        //caso encargado de añadir los coches 
                        case 1:

                            //gestor maximo de coches 
                            if (arrayVehicles.Count < 5)
                            {

                                Console.WriteLine("¿Que tipo te gustaria?");
                                Console.WriteLine("---------------------------------------------------------------------------------------------------------------");
                                Console.WriteLine("1. Automovil;   2. Cuatrimoto;   3. Motocicleta");
                                reply = int.Parse(Console.ReadLine());

                                //gestor de agregacion de tipo de coche
                                if (reply == 1)
                                {

                                    arrayVehicles.Add(firstprocess.addCoche(newid));


                                }
                                else if (reply == 2)
                                {

                                    arrayVehicles.Add(firstprocess.addQuadBike(newid));

                                }
                                else if (reply == 3)
                                {

                                    arrayVehicles.Add(firstprocess.addBike(newid));

                                }
                                else
                                {

                                    Console.WriteLine("Por favor ingresa un valor valido");

                                }

                            }
                            else
                            {
                                Console.WriteLine("---------------------------------------------------------------------------------------------------------------");
                                Console.WriteLine("El sistema gestiona un limite de 5 coches");
                                Console.WriteLine("---------------------------------------------------------------------------------------------------------------");

                            }

                            break;

                        case 2:

                            //condicion si la lista esta vacia
                            if (arrayVehicles.Count < 1)
                            {
                                Console.WriteLine("---------------------------------------------------------------------------------------------------------------");
                                Console.WriteLine("No tienes coches añadidos");
                                Console.WriteLine("---------------------------------------------------------------------------------------------------------------");

                                break;
                            }

                            Console.WriteLine("---------------------------------------------------------------------------------------------------------------");
                            Console.WriteLine("Estos son los coches que tienes hasta el momento");
                            Console.WriteLine("---------------------------------------------------------------------------------------------------------------");

                            //encargado de mostrar los coches actuales en la lista
                            for (int i = 0; i < arrayVehicles.Count; i++)

                            {
                                Console.WriteLine("---------------------------------------------------------------------------------------------------------------");
                                Console.WriteLine(arrayVehicles[i].ToString());
                                Console.WriteLine("---------------------------------------------------------------------------------------------------------------");

                            }

                            Console.WriteLine("---------------------------------------------------------------------------------------------------------------");
                            Console.WriteLine("¡No te preocupes!, tambien puedes cambiar tu tipo de coche ");
                            Console.WriteLine("1.  Coche;  2  .Cuatrimoto; 3.  Motocicleta. ");
                            optionType = int.Parse(Console.ReadLine());

                            //para editar todos los campos adicionales de las subclases
                            if (optionType == 1)
                            {
                                Console.WriteLine("¿Cual coche quieres  editar?, Escribe  el id  del  coche a modificar ");
                                optionEdit = int.Parse(Console.ReadLine());

                                for (int i = 0; i < arrayVehicles.Count; i++)
                                {

                                    if (optionEdit == arrayVehicles[i].ID)
                                    {
                                        arrayVehicles[i] = firstprocess.addCoche(newid);
                                        break;
                                    }
                                    else
                                    {

                                        Console.WriteLine("---------------------------------------------------------------------------------------------------------------");

                                        Console.WriteLine("No existen vehiculos con ese id");

                                        Console.WriteLine("---------------------------------------------------------------------------------------------------------------");

                                        break;
                                    }

                                }

                            }
                            else if (optionType == 2)
                            {

                                Console.WriteLine("Cual coche quieres  editar?, Escribe  el id  del  coche a modificar ");
                                optionEdit = int.Parse(Console.ReadLine());

                                for (int i = 0; i < arrayVehicles.Count; i++)
                                {

                                    if (optionEdit == arrayVehicles[i].ID)
                                    {

                                        arrayVehicles[i] = firstprocess.addQuadBike(newid);
                                        break;
                                    }
                                    else
                                    {

                                        Console.WriteLine("---------------------------------------------------------------------------------------------------------------");

                                        Console.WriteLine("No existen vehiculos con ese id");

                                        Console.WriteLine("---------------------------------------------------------------------------------------------------------------");

                                        break;
                                    }
                                }

                            }
                            else if (optionType == 3)
                            {

                                Console.WriteLine("Cual coche quieres  editar?, Escribe  el id  del  coche a modificar ");
                                optionEdit = int.Parse(Console.ReadLine());

                                for (int i = 0; i < arrayVehicles.Count; i++)
                                {

                                    if (optionEdit == arrayVehicles[i].ID)
                                    {

                                        arrayVehicles[i] = firstprocess.addBike(newid);
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("---------------------------------------------------------------------------------------------------------------");
                                        Console.WriteLine("No existen vehiculos con ese id");
                                        Console.WriteLine("---------------------------------------------------------------------------------------------------------------");
                                        break;
                                    }


                                }

                            }
                            else
                            {
                                Console.WriteLine("---------------------------------------------------------------------------------------------------------------");
                                Console.WriteLine("Ingresa opcion valida");
                                Console.WriteLine("---------------------------------------------------------------------------------------------------------------");
                            }

                            break;

                        case 3:
                            //es solo recorrido e impresion de la coleccion

                            if (arrayVehicles.Count < 1)
                            {
                                Console.WriteLine("---------------------------------------------------------------------------------------------------------------");
                                Console.WriteLine("No tienes coches por listar");
                                Console.WriteLine("---------------------------------------------------------------------------------------------------------------");

                                break;
                            }

                            for (int i = 0; i < arrayVehicles.Count; i++)
                            {
                                Console.WriteLine("---------------------------------------------------------------------------------------------------------------");
                                Console.WriteLine(arrayVehicles[i].ToString());
                                Console.WriteLine("---------------------------------------------------------------------------------------------------------------");

                            }

                            break;

                        case 4:

                            //si la lista esta vacia 
                            if (arrayVehicles.Count < 1)
                            {
                                Console.WriteLine("---------------------------------------------------------------------------------------------------------------");
                                Console.WriteLine("No tienes coches para eliminar");
                                Console.WriteLine("---------------------------------------------------------------------------------------------------------------");

                                break;
                            }
                            Console.WriteLine("---------------------------------------------------------------------------------------------------------------");
                            Console.WriteLine("Estos son los coches que tienes hasta el momento");
                            //recorrido de la coleccion
                            for (int i = 0; i < arrayVehicles.Count; i++)
                            {
                                Console.WriteLine("---------------------------------------------------------------------------------------------------------------");
                                Console.WriteLine(arrayVehicles[i].ToString());
                                Console.WriteLine("---------------------------------------------------------------------------------------------------------------");

                            }
                            Console.WriteLine("Cual coche quieres  eliminar?, Escribe  el id  del  coche");
                            position = int.Parse(Console.ReadLine());

                            //encargado de recorrer toda la lista y en el objeto que esta dentro de la lista cojer el atributo
                            for (int i = 0; i < arrayVehicles.Count; i++)
                            {

                                if (position == arrayVehicles[i].ID)
                                {

                                    arrayVehicles.Remove(arrayVehicles[i]);
                                    Console.WriteLine("Coche Eliminado");
                                    break;

                                }


                            }

                            break;


                        default:
                            Console.WriteLine("---------------------------------------------------------------------------------------------------------------");
                            Console.WriteLine("Ingrese una opcion valida");
                            Console.WriteLine("---------------------------------------------------------------------------------------------------------------");

                            break;

                    }

                    newid++;
                    Console.WriteLine("¿Que quieres hacer?  Menu principal 0.  Salir del programa 1.");
                    option = int.Parse(Console.ReadLine());

                }

            }
            catch (Exception)
            {
                Console.WriteLine("Ingresa valores correctos para un buen funcionamiento del programa");
            }

        }

    }
}
