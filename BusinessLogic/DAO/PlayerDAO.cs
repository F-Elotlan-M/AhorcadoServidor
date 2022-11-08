using System;
using System.Data.Entity.Migrations;
using System.Linq;
using DataAccess;

namespace BusinessLogic.DAO
{
    public class PlayerDAO
    {
        public PlayerDAO() { 
        
        }

        public Player Login(String email, String password) {
            Player player = new Player();
            using (var context = new AhorcadoDBEntity())
            {
                int playersCont = (from Player in context.Player
                                   where Player.Email == email && Player.PasswordPlayer == password
                                   select Player).Count();

                var players = (from Player in context.Player
                               where Player.Email == email && Player.PasswordPlayer == password
                               select Player).ToList();

                if (playersCont > 0)
                {
                    player = players.First();
                }
            }
            return player;
        }

        public int Register(String namePlayer, String lastname, String email, String password, String username, int points, int gamesWin) {
            int respuesta = 0;
            using (var context = new AhorcadoDBEntity()) {
                var newPlayer = context.Player.Add(new Player() { NamePlayer = namePlayer, Lastname = lastname, Email = email, PasswordPlayer = password, Username = username, Points = points, GamesWin = gamesWin });
                respuesta = context.SaveChanges();
            }
            return respuesta;
        }

        public int UpdateDataPlayer(String namePlayer, String lastname, String email, String password, String username) {
            int respuesta = 0;
            using (var context = new AhorcadoDBEntity()) {
                var playerUpdate = context.Player.First();
                playerUpdate.NamePlayer = namePlayer;
                playerUpdate.Lastname = lastname;
                playerUpdate.Email = email;
                playerUpdate.PasswordPlayer = password;
                playerUpdate.Username = username; 
                respuesta = context.SaveChanges();
            }
            return respuesta;
        }
        
    }
}
