using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestService
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceLoL.WsPedidosClient client = new ServiceLoL.WsPedidosClient();
            Console.WriteLine(client.GetAll());
            Console.ReadKey();
        }
    }
}
