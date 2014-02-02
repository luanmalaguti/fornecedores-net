using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleWebService.WsPedidosClient client = new ConsoleWebService.WsPedidosClient();
            Console.WriteLine("tamanho: "+client.GetAll().Count());
            foreach (var s in client.GetAll())
            {
                Console.WriteLine(s.Id);
                Console.WriteLine(s.Descricao);
                Console.WriteLine(s.Entrega);
                Console.WriteLine(s.Status);
            }
            Console.ReadKey();
        }
    }
}
