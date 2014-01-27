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
    public class ProdutoController : Controller<Produto>
    {
        private FornecedoresContext db = ConnProvider.getContext();
        
        public Produto Save(Produto t)
        {
            if (t.Id == 0)
            {
                t = db.Produto.Add(t);
            }
            else
            {
                db.Entry(t).State = EntityState.Modified;
            }

            db.SaveChanges();
            return t;
        }

        public void Remove(Produto t)
        {
            db.Produto.Remove(t);
            db.SaveChanges();
        }

        public Produto Find(int id)
        {
            return db.Produto.Find(id);
        }

        public ICollection<Produto> FindAll()
        {
            return db.Produto.ToList();
        }
    }
}
