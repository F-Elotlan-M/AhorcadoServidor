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

        public int Register(String namePlayer, String email, String password, String username, int points, int gamesWin) {
            int respuesta = 0;
            using (var context = new AhorcadoDBEntity()) {
                var newPlayer = context.Player.Add(new Player() { NamePlayer = namePlayer, Lastname = "S/A", Email = email, PasswordPlayer = password, Username = username, Points = points, GamesWin = gamesWin });
                respuesta = context.SaveChanges();
            }
            return respuesta;
        }

        public int UpdateDataPlayer(String namePlayer, String email, String password, String username) {
            int respuesta = 0;
            using (var context = new AhorcadoDBEntity()) {
                var playerUpdate = context.Player.First();
                playerUpdate.NamePlayer = namePlayer;
                playerUpdate.Email = email;
                playerUpdate.PasswordPlayer = password;
                playerUpdate.Username = username; 
                respuesta = context.SaveChanges();
            }
            return respuesta;
        }

        public string recuperarNombre(String email, String password) {
            string nombre;
            Player player2 = new Player();
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
                    player2 = players.First();
                }
            }
            nombre = player2.NamePlayer;
            return nombre;
        }

        public string recuperarUsername(String email, String password)
        {
            string user;
            Player player2 = new Player();
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
                    player2 = players.First();
                }
            }
            user = player2.Username;
            return user;
        }

        public int recuperarPuntos(String email, String password)
        {
            int puntos;
            Player player2 = new Player();
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
                    player2 = players.First();
                }
            }
            puntos = player2.Points;
            return puntos;
        }

        public int recuperarIdPlayer(String email, String password)
        {
            int idPlayer;
            Player player2 = new Player();
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
                    player2 = players.First();
                }
            }
            idPlayer = player2.IdPlayer;
            return idPlayer;
        }

        public int recuperarGamesWin(String email, String password)
        {
            int gamesWin;
            Player player2 = new Player();
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
                    player2 = players.First();
                }
            }
            gamesWin = player2.GamesWin;
            return gamesWin;
        }

    }
}
