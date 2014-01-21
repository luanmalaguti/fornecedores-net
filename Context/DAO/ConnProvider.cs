﻿

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
        /// Acesso para o contexto de conexão da aplicação
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

        public static void DisposeContext()
        {
            if (db != null)
            {
                db.Dispose();
            }
        }
    }
}
