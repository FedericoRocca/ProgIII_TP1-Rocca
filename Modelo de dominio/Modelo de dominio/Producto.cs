using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo_de_dominio
{
    class Producto
    {
        public int Tipo { get; set; }
        public int Cantidad { get; set; }
        public Tamanio Tam { get; set; }
    }
}
