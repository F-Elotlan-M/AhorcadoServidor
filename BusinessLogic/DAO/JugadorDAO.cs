using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using BusinessLogic.POCO;

namespace BusinessLogic.DAO
{
    internal class JugadorDAO
    {
        public static RespuestaLogin logear(String correo, String password)
        {
            RespuestaLogin respuestaBD = new RespuestaLogin();
            MySqlConnection conexionBD = ConnectionUtil.obtenerConexion();

            if (conexionBD != null)
            {
                try
                {
                    String consulta = "SELECT * FROM jugador WHERE email = @email AND password = @password";
                    MySqlCommand mySqlCommand = new MySqlCommand(consulta, conexionBD);
                    mySqlCommand.Parameters.AddWithValue("@email", correo);
                    mySqlCommand.Parameters.AddWithValue("@password", password);
                    MySqlDataReader respuesta = mySqlCommand.ExecuteReader();
                    if (respuesta.Read())
                    {
                        respuestaBD.Error = false;
                        respuestaBD.Mensaje = "Bienvenido al juego!!";

                        Jugador jugadorBD = new Jugador();
                        jugadorBD.Id = ((respuesta.IsDBNull(0)) ? 0 : respuesta.GetInt32(0));
                        jugadorBD.Nombre = ((respuesta.IsDBNull(1)) ? "" : respuesta.GetString(1));
                        jugadorBD.Email = ((respuesta.IsDBNull(6)) ? "" : respuesta.GetString(6));

                        respuestaBD.DatosJugador = jugadorBD;
                    }
                    else
                    {
                        respuestaBD.Error = true;
                        respuestaBD.Mensaje = "Contraseña o usuario inválidos";
                        respuestaBD.DatosJugador = null;
                    }

                }
                catch (Exception ex)
                {
                    respuestaBD.Error = true;
                    respuestaBD.Mensaje = "Hubo un problema de conexión, inténtelo más tarde";
                    respuestaBD.DatosJugador = null;
                }
            }
            else
            {
                respuestaBD.Error = true;
                respuestaBD.Mensaje = "Hubo un problema de conexión, inténtelo más tarde";
                respuestaBD.DatosJugador = null;
            }

            return respuestaBD;
        }

        public static Mensaje insertarJugador(Jugador jugadorRegistro)
        {
            Mensaje mensaje = new Mensaje();
            MySqlConnection conexionBD = ConnectionUtil.obtenerConexion();
            if (conexionBD != null)
            {
                try
                {
                    string sentencia = "INSERT INTO jugador (nombreCompleto, fechaNacimiento, password, email, puntajeGlobal) " +
                                       "VALUES(@nombreCompleto,@fechaNacimiento,@telefono,@password,@email, @puntajeGlobal)";
                    MySqlCommand mySqlCommand = new MySqlCommand(sentencia, conexionBD);
                    mySqlCommand.Parameters.AddWithValue("@nombreCompleto", jugadorRegistro.Nombre);
                    mySqlCommand.Parameters.AddWithValue("@fechaNacimiento", jugadorRegistro.FechaNacimiento);
                    mySqlCommand.Parameters.AddWithValue("@password", jugadorRegistro.Password);
                    mySqlCommand.Parameters.AddWithValue("@email", jugadorRegistro.Email);
                    mySqlCommand.Parameters.AddWithValue("@puntajeGlobal", 0);
                    mySqlCommand.Prepare();
                    int filasAfectadas = mySqlCommand.ExecuteNonQuery();
                    if (filasAfectadas > 0)
                    {
                        mensaje.Error = false;
                        mensaje.MensajeRespuesta = "Jugador registrado con éxito";
                    }
                    else
                    {
                        mensaje.Error = true;
                        mensaje.MensajeRespuesta = "Error al registrar el jugador";
                    }

                }
                catch (Exception ex)
                {
                    mensaje.Error = true;
                    mensaje.MensajeRespuesta = ex.Message;
                }
            }
            else
            {
                mensaje.Error = true;
                mensaje.MensajeRespuesta = "Por el momento no hay conexión con los servicios...";
            }
            return mensaje;
        }
    }
}
