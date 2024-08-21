using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    public class Direccion
    {
        public string Numero { get; set; } 
        public string NombreCalle { get; set; }
        public string Ciudad { get; set; }
        public string Provincia { get; set; }
        public string Pais { get; set; }

        public string DireccionCompleta
        {
            get
            {
               return $"{Numero} {NombreCalle}, {Ciudad} , {Pais}";     
            }
        }
    }
}