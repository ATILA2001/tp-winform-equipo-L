using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_CatalogoComercio
{
    internal class Marca
    {
        public int IDMarca { get; set; }
        public string Descripcion { get; set; }
        public Marca() { }
        public Marca(int IDMarca, string Descripcion)
        {
            this.IDMarca = IDMarca;
            this.Descripcion = Descripcion;
        }

    }
}
