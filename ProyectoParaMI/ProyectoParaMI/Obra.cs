using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reparar
{
    class Obra
    {
        private uint Codigo;
        private string Direccion;
        private ulong Matricula_Profesional;
        public ArrayList Obreros = new ArrayList();

        public Obra(uint cod, string dire, ulong mat_pro)
        {
            Codigo = cod;
            Direccion = dire;
            Matricula_Profesional = mat_pro;
        }

        public uint codigo
        {
            get { return Codigo; }
            set { Codigo = value; }
        }
        public string direccion
        {
            get { return Direccion; }
            set { Direccion = value; }
        }
        public ulong matricula
        {
            get { return Matricula_Profesional; }
            set { Matricula_Profesional = value; }
        }
    }
}
