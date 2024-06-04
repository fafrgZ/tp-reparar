using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reparar
{
    class Inicio
    {
        public static void Main()
        {
            string valor = "";
            int opcion = 0;

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

            switch (opcion)
            {

                case 1:
                    //Funcion 1
                    Console.WriteLine("Usted eligió la opción 1");
                    break;

                case 2:
                    //Funcion 2
                    Console.WriteLine("Usted eligió la opción 2");
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
                    Console.WriteLine("Opción no valida");
                    break;
            }
        }
    }
}
