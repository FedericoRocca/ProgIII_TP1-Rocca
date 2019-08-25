using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo_de_dominio
{
    class Pasillo
    {
        public int Lados { get; set; }
        public int Piso { get; set; }
        public Compartimiento Compartimientos { get; set; }
    }
}
