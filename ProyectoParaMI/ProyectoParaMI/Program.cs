using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Reparar
{
    class Program
    {
        public static void Main()
        {





            string valor = "";
            int opcion = 0;
            int cont = 0;

            Console.WriteLine("Hola como estas soy Sosa Gonzalo Agustin");

            Console.WriteLine("1- Establecer e informar las variables de sueldos");
            Console.WriteLine("2- Registrar un empleado");
            Console.WriteLine("3- Listado de Empleados");
            Console.WriteLine("4- Registrar una obra con un código");
            Console.WriteLine("5- Modificar Personal Designado a una obra");
            Console.WriteLine("6- Asignar un obrero en una obra.");
            Console.WriteLine("7- Listado completo de una obra");
            Console.WriteLine("8- Eliminar un profesional de la empresa");
            Console.WriteLine("Que operación desea hacer?");

            valor = Console.ReadLine();
            opcion = Convert.ToInt32(valor);

            Empresa empresa = new Empresa();
            string nombre = "";
            string apellido = "";
            ulong legajo = 0;


                switch (opcion)
                {
                    case 1:
                        empresa.Mostrar_Empleados();
                        break;

                    case 2:

                        Console.WriteLine("Ingrese su apellido. En caso de querer salir ponga 'salir' :");
                        apellido = Console.ReadLine();

                        while (apellido.ToUpper() != "SALIR")
                        {
                            Console.WriteLine("Ingrese su nombre :");
                            nombre = Console.ReadLine();

                            Console.WriteLine("Ingrese su legajo :");
                            legajo = Convert.ToUInt64(Console.ReadLine());

                            empresa.Recibir_Empleado(nombre, apellido, legajo);
                            cont++;

                            Console.WriteLine("Ingrese su apellido. En caso de querer salir ponga 'salir' :");
                            apellido = Console.ReadLine();
                        }

                        if (cont <= 0)
                        {
                            Console.WriteLine("No se han agregado empleados ");
                        }


                        empresa.Mostrar_Empleados();
                        break;

                    case 3:
                        //Funcion 3
                        Console.WriteLine("Usted eligió la opción 3");
                        break;

                    case 4:
                        //Funcion 4
                        Console.WriteLine("Usted eligió la opción 4");
                        break;

                    case 5:
                        //Funcion 5
                        Console.WriteLine("Usted eligió la opción 5");
                        break;

                    case 6:
                        //Funcion 6
                        Console.WriteLine("Usted eligió la opción 6");
                        break;

                    case 7:
                        //Funcion 7
                        Console.WriteLine("Usted eligió la opción 7");
                        break;

                    case 8:
                        //funcion 8
                        Console.WriteLine("Usted eligió la opción 8");
                        break;

                    default:
                        Console.WriteLine("Opción no válida");
                        break;

                }

            }

        }
    }








