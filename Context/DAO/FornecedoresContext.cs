using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace Context.DAO
{
    /// <summary>
    /// Contexto da conexão, representa as transações com o banco de dados,
    /// Extende de <see cref="DbContext"/>
    /// </summary>
    public class FornecedoresContext : DbContext 
    {
        
        /// <summary>
        /// Define-se o nome do banco passando por parametro uma string
        /// para o construtor da super classe <code>DbContext(String)</code>
        /// 
        /// <example><code> : base("nomeBanco")</code></example>
        /// 
        /// </summary>
        public FornecedoresContext() : base("db_fornecedores")
        {      
        }

        public FornecedoresContext(string path) : base(path)
        {
        }

        /// <example>
        /// Para tornar uma nova entidade persistivel deve-se registra-la da seguinte maneira:
        /// 
        /// <code>
        ///   public DbSet<Entidade> entidade {get; set; }
        /// </code>
        /// 
        /// </example>>
        public DbSet<Fornecedor> Fornecedor { get; set; }

        public DbSet<Produto> Produto { get; set; }

        public DbSet<Pedido> Pedido { get; set; }

        public DbSet<ItemPedido> ItemPedido { get; set; }
    }
}
