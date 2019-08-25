using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo_de_dominio
{
    class Deposito
    {
        public int Pisos { get; set; }
        public Pasillo Pasillos { get; set; }
        public Direccion Dir { get; set; }
        public int ID { get; set; }
    }
}
