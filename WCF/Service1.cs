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
    public class Service1 : IPlayer, ILobby
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

        public int Register(String namePlayer, String lastname, String email, String password, String username, int points, int gamesWin) {
            BusinessLogic.DAO.PlayerDAO playerDAO = new PlayerDAO();
            return playerDAO.Register(namePlayer, lastname, email, password, username, points, gamesWin);
        }

        public int UpdateDataPlayer(String namePlayer, String lastname, String email, String password, String username) {
            BusinessLogic.DAO.PlayerDAO playerDAO = new PlayerDAO();
            return playerDAO.UpdateDataPlayer(namePlayer, lastname, email, password, username);
        }

        public int CreateLobby(int codeLobby, int idPlayer) {
            BusinessLogic.DAO.LobbyDAO lobbyDAO = new LobbyDAO();
            return lobbyDAO.CreateLobby(codeLobby, idPlayer);
        }
    }
}
