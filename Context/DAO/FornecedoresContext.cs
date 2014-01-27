
using System.Data.Entity;
using Model;
using Model.POCO;

namespace Context.DAO
{
    /// <summary>
    /// Contexto da conexão, representa as transações com o banco de dados,
    /// Extende de <see cref="DbContext"/>
    /// </summary>
    public class FornecedoresContext : DbContext 
    {
        
        /// <summary>
        /// Define-se o nome do contexto passando por parametro uma string
        /// para o construtor da super classe <code>DbContext(String)</code>
        /// 
        /// <example><code> : base("contexto")</code></example>
        /// 
        /// </summary>
        public FornecedoresContext() : base("FornecedoresContext")
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
        public DbSet<Usuario> Usuario { get; set; }
        
        public DbSet<Fornecedor> Fornecedor { get; set; }

        public DbSet<Produto> Produto { get; set; }

        public DbSet<Pedido> Pedido { get; set; }

        public DbSet<ItemPedido> ItemPedido { get; set; }

        public DbSet<FornecedorProduto> FornecedorProdutos { get; set; }

    }
}
