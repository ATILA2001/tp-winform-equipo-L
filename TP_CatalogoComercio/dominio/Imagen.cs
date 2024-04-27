using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Imagen
    {
        public string Id { get; set; }
        public string Url { get; set; }
        public Imagen() { }
        public Imagen(string Id, string Url)
        {
            this.Id = Id;
            this.Url = Url;
        }
        public override string ToString()
        {
            return Url;
        }

    }
}
