using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WCF
{
    [ServiceContract]
    public interface ILobby
    {
        [OperationContract]
        int CreateLobby(int idPlayer, int code);
    }

    [DataContract]
    public class Lobby
    {
        [DataMember]
        public int IdLobby { get; set; }
        [DataMember]
        public int CodeLobby { get; set; }
        [DataMember]
        public int IdPlayer { get; set; }
    }
}
