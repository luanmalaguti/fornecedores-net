using System;
using System.Collections.Generic;
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
            throw new NotImplementedException();
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
