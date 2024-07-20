using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entidades
{
    public class LineaEnvio
    {
        public int Id { get; set; }
        public string? Ruta { get; set; }


        //paginacion
        public ICollection<Item>? Items { get; set; }

    }
}