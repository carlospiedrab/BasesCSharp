using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    public class Persona
    {
        public Persona(string nombres)
        {
            Nombres = nombres;
        }

        public Persona()
        {

        }

        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }

        public Genero Genero { get; set; }

        public string NombreCompleto
        {
            get
            {
                return $"{Nombres} {Apellidos}";
            }
        }
        public Direccion Direccion { get; set; }
        public string Telefono { get; set; }
    }

    public enum Genero
    {
        Masculino,
        Femenino
    }

}