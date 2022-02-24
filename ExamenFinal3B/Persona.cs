using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinal3B
{
    class Persona
    {
        private int no;
        private string cliente;
        private string domicilio;
        public int No { get { return no; } set { no = value; } }
        public string Cliente { get { return cliente; } set { cliente = value; } }
        public string Domicilio { get { return domicilio; } set { Domicilio = value; } }
    }
}
