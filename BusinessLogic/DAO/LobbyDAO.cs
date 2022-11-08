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

        public int CreateLobby(int codeLobby, int idPlayer) {
            int result = 0;
            using (var context = new AhorcadoDBEntity())
            {
                var newLobby = context.Lobby.Add(new Lobby() { CodeLobby = codeLobby, IdPlayer = idPlayer });
                result = context.SaveChanges();
            }
            return result;
        }
    }
}
