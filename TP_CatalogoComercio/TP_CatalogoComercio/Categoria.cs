using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_CatalogoComercio
{
    internal class Categoria
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public Categoria() { }
        public Categoria(int Id, string Descripcion)
        {   
            this.Id = Id;
            this.Descripcion = Descripcion;
        }

    }
}
