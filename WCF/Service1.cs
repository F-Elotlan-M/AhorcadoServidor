using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using BusinessLogic;
namespace WCF
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código y en el archivo de configuración a la vez.
    public class Service1 : IService1
    {

        public bool primerMetodo()
        {
            bool prueba;
            BusinessLogic.Metodos
            metodos =  new BusinessLogic.Metodos();
            prueba = metodos.Fernando();
            return prueba; 
        }
    }
}
