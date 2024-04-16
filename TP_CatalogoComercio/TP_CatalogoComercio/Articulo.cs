using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TP_CatalogoComercio
{
    internal class Articulo
    {
        public int CodigoArticulo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public Marca Marca { get; set; }
        public Categoria Categoria { get; set; }
        public Imagen Imagen { get; set; }
        public float Precio { get; set; }
        public Articulo() { }
        public Articulo(int CodigoArticulo, string Nombre, string Descripcion, Marca Marca, Categoria Categoria, Imagen Imagen, float Precio)
        {
            this.CodigoArticulo = CodigoArticulo;
            this.Nombre = Nombre;
            this.Descripcion = Descripcion;
            this.Marca = Marca;
            this.Categoria = Categoria;
            this.Imagen = Imagen;
            this.Precio = Precio;
        }
    }
}
