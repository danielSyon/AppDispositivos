using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
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

                    Console.WriteLine("1.-Terminal 1");
                    Console.WriteLine("2.-Controladora 2");
                    Console.WriteLine("3.-Salir");
                    Console.WriteLine("Elige una de las opciones");
                    int opcion = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();

                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine("---------------------------------------------");
                            Console.WriteLine("Has elegido la Terminal ");
                            Console.WriteLine("Ponga la ip de su dispositivo: ");                     
                            string ipTerminal= Console.ReadLine();                               
                            Regex validateIPv4Regex = new Regex("^(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\\.(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\\.(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\\.(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$");
                           
                            if (!validateIPv4Regex.IsMatch(ipTerminal))
                            {
                                Console.WriteLine("La ip insertada no es correcta.");
                            }
                            else
                            {
                                Console.WriteLine("Ip valida!");
                            }
                            Console.WriteLine("Introduzca el puerto de comunicación: ");
                            string puertoTerminal = Console.ReadLine();



                        bool salir2 = false;

                            while (!salir2)
                            {

                                try
                                {
                                    Console.WriteLine("MENÚ DEL TERMINAL");
                                    Console.WriteLine("1.-Datos Empleado");
                                    Console.WriteLine("2.-Guardar en fichero el empleado");
                                    Console.WriteLine("3.-Obtener todos los datos de los empleados");
                                    Console.WriteLine("4.-Guardar en fichero todos los empleados");
                                    Console.WriteLine("5.-Salir");
                                    Console.WriteLine("Elige una de las opciones");
                                    int opcion2 = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine();

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

                            Console.WriteLine();
                            break;

                        case 2:
                            Console.WriteLine("---------------------------------------------");

                            Console.WriteLine("Ponga la ip de su dispositivo: ");

                            string ipControladora = Console.ReadLine();

                            Regex validateIPv4Regex2 = new Regex("^(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\\.(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\\.(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\\.(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$");
                            bool correcto = false;
                            while (!correcto)
                            {
                                if (!validateIPv4Regex2.IsMatch(ipControladora))
                                Console.WriteLine("La ip no es valida");

                                
                                else
                                {
                                    Console.WriteLine("Ip correcta");
                                    correcto = true;
                                  
                                }
                                
                            }
                            Console.WriteLine();

                            Console.WriteLine("Introduzca el puerto de comunicación: ");
                            
                            string puertoControladora = Console.ReadLine();
                            bool salir3 = false;

                            while (!salir3)
                            {

                                try
                                {
                                    Console.WriteLine("MENÚ DE CONTROLADORA");
                                    Console.WriteLine("1.-Datos Empleado");
                                    Console.WriteLine("2.-Guardar en fichero el empleado");
                                    Console.WriteLine("3.-Obtener todos los datos de los empleados");
                                    Console.WriteLine("4.-Guardar en fichero todos los empleados");
                                    Console.WriteLine("5.-Salir");
                                    Console.WriteLine("Elige una de las opciones");
                                    int opcion2 = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("---------------------------------------------");

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




     

