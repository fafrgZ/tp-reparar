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
            ArrayList empleados = new ArrayList();

            while (true)
            {
                MostrarMenu();

                int opcion = ObtenerOpcion();

                EjecutarOpcion(opcion);

                Console.WriteLine("\nPresione cualquier tecla para regresar al menú principal...");
                Console.ReadKey();
                Console.Clear();

            }
        }


        static void MostrarMenu()
        {
            Console.WriteLine("Menú Principal:");
            Console.WriteLine("1- Establecer e informar las variables de sueldos");
            Console.WriteLine("2- Registrar un empleado");
            Console.WriteLine("3- Listado de Empleados");
            Console.WriteLine("4- Registrar una obra con un código");
            Console.WriteLine("5- Modificar Personal Designado a una obra");
            Console.WriteLine("6- Asignar un obrero en una obra.");
            Console.WriteLine("7- Listado completo de una obra");
            Console.WriteLine("8- Eliminar un profesional de la empresa");
            Console.WriteLine("Seleccione una opcion:");
        }

        static int ObtenerOpcion()
        {
            int opcion;
            while (!int.TryParse(Console.ReadLine(), out opcion) || opcion < 1 || opcion > 8)
            {
                Console.WriteLine("Opción inválida. Por favor, intente de nuevo.");
                Console.Write("Seleccione una opción: ");
            }
            return opcion;
        }

        static void EjecutarOpcion(int opcion)
        {
            switch (opcion)
            {
                case 1:
                    //Funcion 1
                    //Establecer e informar las variables de sueldos (el monto de referencia definido por el sindicato y el canon
                    //universal para el pago de la matrícula profesional) y los datos y haber mensual de todos los empleados
                    //registrados en la empresa.

                    Console.WriteLine("Usted eligió la opción 1");
                    InformarSueldos(); 
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



        static public void InformarSueldos(ArrayList empelados)
        {

            foreach (Empleado empleado in empleados)
            {
                Console.WriteLine($"Empleado: {empleado.Nombre}, Sueldo: {empleado.Sueldo}");
            }
        }
    }
}