using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reparar
{
    class Profesional : Empleado
    {
        private string TituloHabilitante;
        private ulong Matricula;
        private string ConsejoPro;

        public Profesional(string TH, ulong Mt, string CProf, string Nom, string Ape, ulong Leg, float Sld) : base(Nom, Ape, Leg, Sld)
        {
            TituloHabilitante = TH;
            Matricula = Mt;
            ConsejoPro = CProf;

;        }

        public override void CalcularSueldo()
        {
            float sueldoProfesional = sueldo + 100.3f;
            Console.WriteLine("El sueldo es:{0}", sueldoProfesional);
        }
    }
}
