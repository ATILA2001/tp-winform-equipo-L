﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_CatalogoComercio
{
    internal class Imagen
    {
        public string Url { get; set; }
        public Imagen() { }
        public Imagen(string Url)
        {
            this.Url = Url;
        }

    }
}