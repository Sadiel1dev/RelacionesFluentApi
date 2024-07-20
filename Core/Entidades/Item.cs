using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entidades
{
    public class Item
    {
        public int Id { get; set; }
        public int Precio { get; set; }

        //llave foranea
        public int ClienteId { get; set; }
        public Cliente? Cliente { get; set; }

         public ICollection<LineaEnvio>? LineaEnvios { get; set; }

    }
}