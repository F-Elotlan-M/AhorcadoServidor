﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        bool primerMetodo();

        [OperationContract]
        bool Login(String Email, String Password);
        [OperationContract]
        int register(String NamePlayer, String Lastname, String Email, String Password, String Username, int Points, int GamesWin);
        [OperationContract]
        int updateDataPlayer(String NamePlayer, String Lastname, String Email, String Password, String Username);
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
