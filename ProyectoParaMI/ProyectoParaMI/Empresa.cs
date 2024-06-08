using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reparar
{
    class Empresa
    {
        //ATRIBUTOS PRIVADOS
        private ArrayList Obras = new ArrayList();
        private ArrayList Empleados = new ArrayList();
        private const ulong MONTO2 = 400;
        private const ulong MONTO1 = 100;

        //Metodos Miembro

        private bool Buscar_Legajo(ulong Leg)
        {
            foreach (var item in Empleados)
            {
                if (item is Profesionales Profe)
                {
                    if (Profe.legajo == Leg)
                        return true;
                }
                if (item is Obrero Obre)
                {
                    if (Obre.legajo == Leg)
                        return true;
                }
            }

            return false;
        }

        public bool Recibir_Empleado(string Nom, string Ape, ulong Leg)
        {

            string TH;
            ulong MAT;
            string Consejo;
            float Porcentaje;

            string Oficio;
            string Categoria;

            int valor = 0;

             if (Buscar_Legajo(Leg) == true)
             {
                 Console.WriteLine("Legajo de Empleado Repetido");
                 return false;
             }
            
            Console.WriteLine("Profesional(1) / Obrero(2)");
            valor = int.Parse(Console.ReadLine());

            if (valor == 1)
            {
                Console.WriteLine("Titulo: ");
                TH = Console.ReadLine();

                Console.WriteLine("Consejo que emite el titulo: ");
                Consejo = Console.ReadLine();

                Console.WriteLine("Matricula: ");
                MAT = ulong.Parse(Console.ReadLine());

                Console.WriteLine("Porcentaje extra a pagar discutido: ");
                Porcentaje = float.Parse(Console.ReadLine());
                if (Porcentaje > 0)
                    Porcentaje = Porcentaje / 100;

                if (Recibir_Profesional(TH, MAT, Consejo, Porcentaje, Nom, Ape, Leg) == false)
                    return false;
            }

            else if (valor == 2)
            {
                Console.WriteLine("Oficio: ");
                Oficio = Console.ReadLine();
                Console.WriteLine("Categoria: ");
                Categoria = Console.ReadLine();

                if (Recibir_Obrero(Oficio, Categoria, Nom, Ape, Leg) == false)
                    return false;
            }



            return true;
        }

        private bool Recibir_Profesional(string TH, ulong MAT, string Consejo, float P, string Nom, string Ape, ulong Leg)
        {

            float Sueldo = MONTO1 + MONTO1 * P;


            Profesionales Dato_Profe = new Profesionales(TH, MAT, Consejo, Sueldo, Nom, Ape, Leg);
            Empleados.Add(Dato_Profe);

            return true;
        }

        private bool Recibir_Obrero(string oficio, string categoria, string Nom, string Ape, ulong Leg)
        {

            float Sueldo = MONTO1;

            if (categoria == "medio-oficial")
                Sueldo = (float)(MONTO1 * 0.65);
            else if (categoria == "aprendiz")
                Sueldo = (float)(MONTO1 * 0.25);

            Obrero Obre = new Obrero(oficio, categoria, Sueldo, Nom, Ape, Leg);

            Empleados.Add(Obre);

            //Console.WriteLine("Codigo de Obra no Encontrado");
            return false;

        }

        public void Mostrar_Empleados()
        {
            foreach (var item in Empleados)
            {
                if (item is Profesionales profe)
                {
                    Console.WriteLine("\nNombre: " + profe.nombre + " Apellido: " + profe.apellido + " Legajo: " + profe.legajo + " Matricula: " + profe.matricula + " Titulo Habilitante: " + profe.TituloHab + " Consejo:" + profe.consejo + " Sueldo:" + profe.sueldo);  
                    
                }

                if (item is Obrero obre)
                {
                    Console.WriteLine("Nombre: " + obre.nombre + " Apellido:" + obre.apellido + " Legajo: " + obre.legajo + " Oficio: " + obre.oficio + " Categoria: " + obre.categoria + " Sueldo: " + obre.sueldo );
                }

            }

        }

    }

}

