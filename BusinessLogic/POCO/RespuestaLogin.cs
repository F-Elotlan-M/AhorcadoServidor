using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.POCO
{
    internal class RespuestaLogin
    {
        public String Mensaje { get; set; }
        public bool Error { get; set; }
        public Jugador DatosJugador { get; set; }
    }
}
