using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IPlayer
    {
        [OperationContract]
        bool primerMetodo();

        [OperationContract]
        bool Login(String email, String password);
        [OperationContract]
        int Register(String namePlayer, String email, String password, String username, int points, int gamesWin);
        [OperationContract]
        int UpdateDataPlayer(String namePlayer, String email, String password, String username);
        [OperationContract]
        string recuperarNombreJugador(String email, String password);
        [OperationContract]
        int recuperarIdPlayer(String email, String password);
        [OperationContract]
        string recuperarUsername(String email, String password);
        [OperationContract]
        int recuperarPoints(String email, String password);
        [OperationContract]
        int recuperarGamesWin(String email, String password);

    }

    [DataContract]
    public class Player
    {
        [DataMember]
        public int IdPlayer { get; set; }
        [DataMember]
        public string NamePlayer { get; set; }
        [DataMember]
        public string Lastname { get; set; }
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public string PasswordPlayer { get; set; }
        [DataMember]
        public string Username { get; set; }
        [DataMember]
        public int Points { get; set; }
        [DataMember]
        public int GamesWin { get; set; }
        [DataMember]
        public Nullable<int> IdAvatar { get; set; }
    }
    /*
    // Utilice un contrato de datos, como se ilustra en el ejemplo siguiente, para agregar tipos compuestos a las operaciones de servicio.
    // Puede agregar archivos XSD al proyecto. Después de compilar el proyecto, puede usar directamente los tipos de datos definidos aquí, con el espacio de nombres "WCF.ContractType".
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }*/
}
