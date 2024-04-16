using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_CatalogoComercio
{
    internal class Categoria
    {
        public int IDCategoria { get; set; }
        public string Descripcion { get; set; }
        public Categoria() { }
        public Categoria(int IDCategoria, string Descripcion)
        {
            this.IDCategoria = IDCategoria;
            this.Descripcion = Descripcion;
        }

    }
}
