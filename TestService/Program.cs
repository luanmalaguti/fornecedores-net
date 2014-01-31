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
            ServiceReference1.TesteClient client = new ServiceReference1.TesteClient();
            Console.WriteLine(client.Print());
            Console.ReadKey();
        }
    }
}
