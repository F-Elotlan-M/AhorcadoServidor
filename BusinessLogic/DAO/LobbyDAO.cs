using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.DAO
{
    public class LobbyDAO
    {
        public LobbyDAO() { 
        
        }

        public int createLobby(int CodeLobby, int IdPlayer) {
            int result = 0;
            using (var context = new AhorcadoDBEntity())
            {
                var newLobby = context.Lobby.Add(new Lobby() { CodeLobby = CodeLobby, IdPlayer = IdPlayer });
                result = context.SaveChanges();
            }
            return result;
        }

        

        /* public Lobby viewLobby() {
            Lobby lobby = new Lobby();
            using (var context = new AhorcadoDBEntity())
            {
                int lobbyCount = (from Lobby in context.Lobby
                                   where == Email && Player.PasswordPlayer == Password
                                   select Player).Count();

                var players = (from Player in context.Player
                               where Player.Email == Email && Player.PasswordPlayer == Password
                               select Player).ToList();

                if (lobbyCount > 0)
                {
                    player = players.First();
                }
            }
            return lobby;
        }*/

    }
}
