using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using BusinessLogic;
using BusinessLogic.DAO;

namespace WCF
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código y en el archivo de configuración a la vez.
    public class Service1 : IService1, ISala
    {

        public bool primerMetodo()
        {
            bool prueba;
            BusinessLogic.Metodos
            metodos =  new BusinessLogic.Metodos();
            prueba = metodos.Fernando();
            return prueba; 
        }

        public bool Login(String Email, String Password) { 
            BusinessLogic.DAO.PlayerDAO playerDAO = new PlayerDAO();
            DataAccess.Player player = new DataAccess.Player();
            player = playerDAO.Login(Email, Password);
            bool player1 = false;
            if (player.Email.Equals(Email) && player.PasswordPlayer.Equals(Password)) {
                player1 = true;
            }
            return player1;
        }

        public int register(String NamePlayer, String Lastname, String Email, String Password, String Username, int Points, int GamesWin) {
            BusinessLogic.DAO.PlayerDAO playerDAO = new PlayerDAO();
            return playerDAO.register(NamePlayer, Lastname, Email, Password, Username, Points, GamesWin);
        }

        public int updateDataPlayer(String NamePlayer, String Lastname, String Email, String Password, String Username) {
            BusinessLogic.DAO.PlayerDAO playerDAO = new PlayerDAO();
            return playerDAO.updateDataPlayer(NamePlayer, Lastname, Email, Password, Username);
        }

        public int createLobby(int CodeLobby, int IdPlayer) { 
            
        }
    }
}
