using System;
using System.Collections;

namespace Reparar
{
    class Profesional : Empleado
    {
        //Atributos privados
        private string TituloHabilitante;
        private ulong Matricula;
        private string ConsejoPro;
        private float Sueldo;

        public Profesional(string TH, ulong Mat, string Consejo, float S, string inNom, string inApe, ulong inLeg) :
            base( inNom, inApe, inLeg)
        {
            TituloHabilitante = TH;
            Matricula = Mat;
            ConsejoPro = Consejo;
            Sueldo = S;
        }

        public string TituloHab
        {
            get { return TituloHabilitante; }
            set { TituloHabilitante = value; }
        }
        public ulong matricula
        {
            get { return Matricula; }
            set { Matricula = value; }
        }
        public string consejo
        {
            get { return ConsejoPro; }
            set { ConsejoPro = value; }
        }
        public float sueldo
        {
            get { return Sueldo; }
            set { Sueldo = value; }
        }


        //SOLANA

        public override void CalcularSueldo()
        {
            float sueldoBase = base.CalcularSueldo();

            //prueba
            float sueldoProfesional = sueldoBase+100
            Console.WriteLine($"El sueldo es:{0}", sueldoProfesional);

        }
    }
}