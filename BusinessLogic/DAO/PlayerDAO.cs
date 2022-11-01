using System;
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
            /* using (AhorcadoDBEntity db = new AhorcadoDBEntity()) {
                 Player playerRequest = new Player();
                 var lista = db.Player;
                 foreach (var oPlayer in lista) {
                     if (oPlayer.Email == Email && oPlayer.PasswordPlayer == Password)
                     {
                         playerRequest.IdPlayer = (oPlayer.IdPlayer);
                         playerRequest.NamePlayer = (oPlayer.NamePlayer);
                         playerRequest.PasswordPlayer = (oPlayer.PasswordPlayer);
                         playerRequest.Points = (oPlayer.Points);
                         playerRequest.Email = (oPlayer.Email);
                         playerRequest.GamesWin = (oPlayer.GamesWin);
                         playerRequest.Lastname = (oPlayer.Lastname);
                         playerRequest.Username = (oPlayer.Username);
                         playerRequest.IdAvatar = (oPlayer.IdAvatar);
                     }
                 }
                 return playerRequest;
             } */
        } 
        
    }
}
