using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo_de_dominio
{
    public class Empleado : Persona
    {
        public int Tipo { get; set; }
        public float Sueldo { get; set; }
        public int DepositoID { get; set; }
        public string Cargo { get; set; }
    }
}
