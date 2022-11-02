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

        public Player Login(String Email, String Password) {
            Player player = new Player();
            using (var context = new AhorcadoDBEntity())
            {
                int playersCont = (from Player in context.Player
                                   where Player.Email == Email && Player.PasswordPlayer == Password
                                   select Player).Count();

                var players = (from Player in context.Player
                               where Player.Email == Email && Player.PasswordPlayer == Password
                               select Player).ToList();

                if (playersCont > 0)
                {
                    player = players.First();
                }
            }
            return player;
        }

        public int register(String NamePlayer, String Lastname, String Email, String Password, String Username, int Points, int GamesWin) {
            int respuesta = 0;
            using (var context = new AhorcadoDBEntity()) {
                var newPlayer = context.Player.Add(new Player() { NamePlayer = NamePlayer, Lastname = Lastname, Email = Email, PasswordPlayer = Password, Username = Username, Points = Points, GamesWin = GamesWin });
                respuesta = context.SaveChanges();
            }
            return respuesta;
        }

        public int updateDataPlayer(String NamePlayer, String Lastname, String Email, String Password, String Username) {
            int respuesta = 0;
            using (var context = new AhorcadoDBEntity()) {
                var playerUpdate = context.Player.First();
                playerUpdate.NamePlayer = NamePlayer;
                playerUpdate.Lastname = Lastname;
                playerUpdate.Email = Email;
                playerUpdate.PasswordPlayer = Password;
                playerUpdate.Username = Username; 
                respuesta = context.SaveChanges();
            }
            return respuesta;
        }
        
    }
}
