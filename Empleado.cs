using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reparar
{
    class Empleado
    {
        private string Nombre;
        private string Apellido;
        private ulong Legajo;


        private float Sueldo;

        public Empleado(string Nom, string Ape, ulong Leg, float Sld)
        {
            Nombre = Nom;
            Apellido = Ape;
            Legajo = Leg;


            Sueldo = Sld;

        }

        public string nombre
        {
            get { return Nombre; }
            set { Nombre = value; }
        }
        public string apellido
        {
            get { return Apellido; }
            set { Apellido = value; }
        }
        public ulong legajo
        {
            get { return Legajo; }
            set { Legajo = value; }
        }



        public float sueldo
        {
            get { return Sueldo; }
            set { Sueldo = value; }
        }

        virtual public void CalcularSueldo()
        {
            return Sueldo; 
        }


    }

}
