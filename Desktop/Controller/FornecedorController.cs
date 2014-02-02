using System;
using System.Collections.Generic;
using System.Data;
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
            if (t.Id == 0)
            {
                t = db.Fornecedor.Add(t);
            }
            else
            {
                db.Entry(t).State = EntityState.Modified;
            }

            db.SaveChanges();
            return t;
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

        public List<Produto> ProdutosDoFornecedor(int id)
        {
            List<Produto> produtos = new List<Produto>();
            
            Fornecedor f = db.Fornecedor.Find(id);
            
            foreach (var fp in f.FornecedorProduto)
            {
                Produto p = db.Produto.Find(fp.ProdutoID);
                p.valor = fp.ValorUnitario;
                produtos.Add(p);
            }

            return produtos;
        }

        public List<Fornecedor> GetForncedorByCombo(int id)
        {
            return db.Fornecedor.Where(f => f.Id == id).ToList();
        } 
    }
}
