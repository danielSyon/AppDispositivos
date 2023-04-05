using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDispositivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool salir = false;

            while (!salir)
            {

                try
                {

                    Console.WriteLine("1. Terminal 1");
                    Console.WriteLine("2. Controladora 2");
                    Console.WriteLine("3. Salir");
                    Console.WriteLine("Elige una de las opciones");
                    int opcion = Convert.ToInt32(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine("Has elegido la Terminal ");
                            Console.WriteLine("Ponga la ip de su dispositivo: ");
                            string ipTerminal= Console.ReadLine();
                            Console.WriteLine("Introduzca el puerto de comunicación: ");
                            string puertoTerminal = Console.ReadLine();



                        bool salir2 = false;

                            while (!salir2)
                            {

                                try
                                {
                                    Console.WriteLine("MENÚ DEL TERMINAL");
                                    Console.WriteLine("1. Datos Empleado");
                                    Console.WriteLine("2. Guardar en fichero el empleado");
                                    Console.WriteLine("3. Obtener todos los datos de los empleados");
                                    Console.WriteLine("4. Guardar en fichero todos los empleados");
                                    Console.WriteLine("5. Salir");
                                    Console.WriteLine("Elige una de las opciones");
                                    int opcion2 = Convert.ToInt32(Console.ReadLine());

                                    switch (opcion2)
                                    {
                                        case 1:
                                            Console.WriteLine("Datos del empleado");
                                            break;

                                        case 2:
                                            Console.WriteLine("Guardar en fichero el empleado");
                                            break;

                                        case 3:
                                            Console.WriteLine("Obtener todos los datos de los empleados");
                                            break;
                                        case 4:
                                            Console.WriteLine("Guardar en fichero todos los empleados");
                                            break;
                                        case 5:
                                            Console.WriteLine("Has salido del menu de Terminal");
                                            salir2 = true;
                                            break;
                                        default:
                                            Console.WriteLine("Elige una opcion entre 1 y 5");
                                            break;
                                    }

                                }
                                catch (FormatException e)
                                {
                                    Console.WriteLine(e.Message);
                                }
                            }
                          

                            break;

                        case 2:
                            
                            Console.WriteLine("Ponga la ip de su dispositivo: ");
                            string ipControladora = Console.ReadLine();
                            Console.WriteLine("Introduzca el puerto de comunicación: ");
                            string puertoControladora = Console.ReadLine();
                            bool salir3 = false;

                            while (!salir3)
                            {

                                try
                                {
                                    Console.WriteLine("MENÚ DE CONTROLADORA");
                                    Console.WriteLine("1. Datos Empleado");
                                    Console.WriteLine("2. Guardar en fichero el empleado");
                                    Console.WriteLine("3. Obtener todos los datos de los empleados");
                                    Console.WriteLine("4. Guardar en fichero todos los empleados");
                                    Console.WriteLine("5. Salir");
                                    Console.WriteLine("Elige una de las opciones");
                                    int opcion2 = Convert.ToInt32(Console.ReadLine());

                                    switch (opcion2)
                                    {
                                        case 1:
                                            Console.WriteLine("Datos del empleado");
                                            break;

                                        case 2:
                                            Console.WriteLine("Guardar en fichero el empleado");
                                            break;

                                        case 3:
                                            Console.WriteLine("Obtener todos los datos de los empleados");
                                            break;
                                        case 4:
                                            Console.WriteLine("Guardar en fichero todos los empleados");
                                            break;
                                        case 5:
                                            Console.WriteLine("Has salido del menu de Controladora");
                                            salir3 = true;
                                            break;
                                        default:
                                            Console.WriteLine("Elige una opcion entre 1 y 5");
                                            break;
                                    }

                                }
                                catch (FormatException e)
                                {
                                    Console.WriteLine(e.Message);
                                }
                            }


                            break;
                       
                        case 3:
                            Console.WriteLine("Has elegido salir de la aplicación");
                            salir = true;
                            break;
                        default:
                            Console.WriteLine("Elige una opcion entre 1 y 3");
                            break;
                    }

                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}




     

