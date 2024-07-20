using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entidades
{
    public class Usuario
    {
        public int Id { get; set; }
        public string? UserName { get; set; }
        public string? Pass { get; set; }

        //llave foranea
        public int ClienteId { get; set; }
        public Cliente? Cliente { get; set; }
    }
}