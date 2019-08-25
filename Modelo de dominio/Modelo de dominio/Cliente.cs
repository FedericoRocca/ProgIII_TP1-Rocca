using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo_de_dominio
{
    public class Cliente : Persona
    {
        public string Contrato { get; set; }
        public int Tipo { get; set; }
        public bool Cuota { get; set; }
    }
}
