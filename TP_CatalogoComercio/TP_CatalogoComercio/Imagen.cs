using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_CatalogoComercio
{
    internal class Imagen
    {
        public int IDImagen { get; set; }
        public string Descripcion { get; set; }
        public string Url { get; set; }
        public Imagen() { }
        public Imagen(int iDImagen, string Descripcion, string Url)
        {
            this.IDImagen = iDImagen;
            this.Descripcion = Descripcion;
            this.Url = Url;
        }

    }
}
