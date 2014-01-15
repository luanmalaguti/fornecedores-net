

namespace Context.DAO
{
    /// <summary>
    /// Singleton que fornece acesso a uma única instancia 
    /// para o Contexto da Conexão com o banco de dados 
    /// </summary>
    /// 
    public class ConnProvider
    {
        private static FornecedoresContext db;
        
        private ConnProvider(string path)
        {
            db = path == null ? new FornecedoresContext() : new FornecedoresContext(path);
        }
       
        /// <summary>
        /// Alternativa para obter o contexto do banco padrão da aplicação
        /// Como nenhum path é informado, obtem-se a conexão do banco "db_fornecedores"
        /// </summary>
        /// <returns>Contexto da conexão</returns>
        public static FornecedoresContext getContext()
        {
            if (db == null)
            {
                new ConnProvider(null);
            }

            return db;
        }

        /// <summary>
        /// Sobrecarga do método <code>getContext()</code>
        /// Alternativa para obter o contexto de um banco diferente do padrão
        /// </summary>
        /// <returns>Contexto da conexão</returns>
        public static FornecedoresContext getContext(string path)
        {
            if (db == null)
            {
                new ConnProvider(path);
            }

            return db;
        }

        public static void DisposeContext()
        {
            if (db != null)
            {
                db.Dispose();
            }
        }
    }
}
