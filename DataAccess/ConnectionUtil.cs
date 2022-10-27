using System;
using MySql.Data.MySqlClient;

namespace DataAccess
{
    public class ConnectionUtil
    {
        private static string SERVIDOR = "localhost";
        private static string PUERTO = "3306";
        private static string BASE_DATOS = "AhorcadoBD";
        private static string USUARIO_BD = "AhorcadoGame";
        private static string PASSWORD = "13F12E2M-";

        public static MySqlConnection obtenerConexion()
        {
            MySqlConnection conexionBD = null;
            try
            {
                string urlConexion = string.Format("server={0};" + "database={1};" +
                                                   "username={2};" + "password={3};" + "port={4};",
                                                   SERVIDOR, BASE_DATOS,
                                                   USUARIO_BD, PASSWORD, PUERTO);
                conexionBD = new MySqlConnection(urlConexion);
                conexionBD.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return conexionBD;
        }
    }
}
