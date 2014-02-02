using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication.WsFornecedores;

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
                Console.WriteLine(s.Status);
                Console.WriteLine(s.Prazo);
                Console.WriteLine(s.Entrega);
            }
            Console.ReadKey();

            Console.WriteLine("------------------");

            IWsFornecedoresClient client2 = new IWsFornecedoresClient();
            foreach (var f in client2.GetAll())
            {
                Console.WriteLine(f.RazaoSocial);
            }
            Console.ReadKey();
        }
    }
}
