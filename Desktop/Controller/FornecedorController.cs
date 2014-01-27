using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Context.DAO;
using Model;

namespace Desktop.Controller
{
    public class FornecedorController : Controller<Fornecedor>
    {
        private FornecedoresContext db = ConnProvider.getContext();
        
        public Fornecedor Save(Fornecedor t)
        {
            throw new NotImplementedException();
        }

        public void Remove(Fornecedor t)
        {
            throw new NotImplementedException();
        }

        public Fornecedor Find(int id)
        {
            return db.Fornecedor.Find(id);
        }

        public ICollection<Fornecedor> FindAll()
        {
            return db.Fornecedor.ToList();
        }

        public Fornecedor ProdutosDoFornecedor(int id)
        {
            return db.Fornecedor.Find(id);
        }
    }
}
