using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace Host
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(WCF.Service1))) 
            {
                host.Open();
                Console.WriteLine("Si jalo");
                Console.ReadLine();
            }
        }
    }
}
