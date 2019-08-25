using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo_de_dominio
{
    class Compartimiento
    {
        public Producto Prod { get; set; }
        public Cliente Cli { get; set; }
        public string Estado { get; set; }
        public Tamanio Tam { get; set; }
    }
}
