using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Context.DAO;
using Model;
using Context;
namespace WebService.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "WsPedidos" in both code and config file together.
    public class WsPedidos : IWsPedidos
    {
        public Pedido[] GetPedidos()
        {
            return ConnProvider.getContext().Pedido.ToArray();
        }
    }
}
