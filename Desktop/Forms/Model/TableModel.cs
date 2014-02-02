using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Model.Util;

namespace Desktop.Forms.Model
{
    public class TableModel
    {
        public TableModel(Fornecedor fornecedor, Pedido pedido)
        {
            RazaoSocial = fornecedor.RazaoSocial;
            Cnpj = fornecedor.Cnpj;
            Descricao = pedido.Descricao;
            Status = pedido.Status;
            Total = pedido.Total;
            Prazo = pedido.Prazo;
            Entrega = pedido.Prazo.Equals(pedido.Entrega) ? "N/C" : pedido.Entrega.ToString();
        }

        public string RazaoSocial { get; set; }
        public string Cnpj { get; set; }
        public string Descricao { get; set; }
        public StatusPedido Status { get; set; }
        public double Total { get; set; }
        public System.DateTime Prazo { get; set; }
        public string Entrega { get; set; }
    }
}
