using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.POCO
{
    internal class Jugador
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string FechaNacimiento { get; set; }
        public string Telefono { get; set; }
        public int PuntajeGlobal { get; set; }
        public string Email { get; set; }

        public string Password { get; set; }
    }
}
