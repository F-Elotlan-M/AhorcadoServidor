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
    public interface ISala
    {
        [OperationContract]
        int createLobby(int IdPlayer, int Code);
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
