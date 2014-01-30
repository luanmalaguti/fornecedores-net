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
    class PedidoController : Controller<Pedido>
    {
        private FornecedoresContext db = ConnProvider.getContext();
        ProdutoController produtoController = new ProdutoController();
        
        public Pedido Save(Pedido t)
        {
            if (t.Id == 0)
            {
                t = db.Pedido.Add(t);
            }
            else
            {
                db.Entry(t).State = EntityState.Modified;
            }

            db.SaveChanges();
            return t;
        }

        public void Remove(Pedido t)
        {
            throw new NotImplementedException();
        }

        public Pedido Find(int id)
        {
            return db.Pedido.Find(id);
        }

        public ICollection<Pedido> FindAll()
        {
            return db.Pedido.ToList();
        }

        public List<Produto> ProdutosDoPedido(Pedido pedido)
        {
            List<Produto> produtos = new List<Produto>();

            foreach(var item in pedido.ItemsPedido)
            {
                produtos.Add(produtoController.Find(item.ProdutoID));
            }

            return produtos;
        } 
    }
}
