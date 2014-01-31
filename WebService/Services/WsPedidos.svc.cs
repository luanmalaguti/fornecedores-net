using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Context.DAO;
using Model;
using WebService.Models;

namespace WebService.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "WsPedidos" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select WsPedidos.svc or WsPedidos.svc.cs at the Solution Explorer and start debugging.
    public class WsPedidos : IWsPedidos
    {
        PedidosController controller = new PedidosController();
        
        public PedidoDB[] GetAll()
        {
            return controller.getAll();
        }
    }
}
