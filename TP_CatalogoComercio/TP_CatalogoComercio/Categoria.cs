﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_CatalogoComercio
{
    internal class Categoria
    {
        public string Descripcion { get; set; }
        public Categoria() { }
        public Categoria(string Descripcion)
        {
            this.Descripcion = Descripcion;
        }

    }
}
