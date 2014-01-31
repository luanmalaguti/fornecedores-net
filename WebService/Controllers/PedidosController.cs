using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Context;
using Context.DAO;
using Model;
using WebService.Controllers;
using WebService.Models;

namespace WebService
{
    public class PedidosController : IController<Pedido, PedidoDB>
    {
        private FornecedoresContext db = ConnProvider.getContext();

        public PedidoDB[] getAll()
        {
            List<PedidoDB> pedidosDb = new List<PedidoDB>();

            foreach (var pedido in db.Pedido.ToList())
            {
                pedidosDb.Add(ToDataMember(pedido));
            }

            return pedidosDb.ToArray();
        }

        public PedidoDB ToDataMember(Pedido pedido)
        {
            PedidoDB pedidoDb = new PedidoDB();

            pedidoDb.Id = pedido.Id;
            pedidoDb.Descricao = pedido.Descricao;
            pedidoDb.Total = pedido.Total;
            pedidoDb.Status = pedido.Status.ToString();
            pedidoDb.Prazo = pedido.Prazo.ToString();
            pedidoDb.Entrega = pedido.Entrega.ToString();

            return pedidoDb;
        }
    }
}