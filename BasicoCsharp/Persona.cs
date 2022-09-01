using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicoCsharp
{
    public class Persona
    {
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public int Edad { get; set; }

        public string NombresCompletos { get; set; }

        //procedimiento
        public void AsignarNombresCompletos()
        {
            NombresCompletos = Nombres + " " + Apellidos;
        }
        //función
        public string GetNombresCompletos()
        {
            return Nombres + " " + Apellidos;
        }

    }
}
