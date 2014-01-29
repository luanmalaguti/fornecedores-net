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
            throw new NotImplementedException();
        }

        public ICollection<Pedido> FindAll()
        {
            throw new NotImplementedException();
        }
    }
}
