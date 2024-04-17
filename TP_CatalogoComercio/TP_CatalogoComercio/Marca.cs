using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_CatalogoComercio
{
    internal class Marca
    {
        public string Descripcion { get; set; }
        public Marca() { }
        public Marca(string Descripcion)
        {
            this.Descripcion = Descripcion;
        }

    }
}
