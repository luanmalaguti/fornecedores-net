using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Context.DAO;
using Desktop.Controller;
using Desktop.Forms.Fornecedores;
using Desktop.Forms.Template;
using Model;
using Model.Util;

namespace Desktop.Forms.Pedidos
{
    public partial class BaixaPedido : BasicConsulta
    {
        private Pedido selecionado;
        private PedidoController controller = new PedidoController(); 

        public BaixaPedido()
        {
            InitializeComponent();
            Buscar("");
        }

        public void Buscar(string param)
        {
            var pedidos = from u in ConnProvider.getContext().Pedido
                           where u.Descricao.Contains(param) && u.Status != StatusPedido.REJEITADO && u.Status != StatusPedido.ENTREGUE
                           
                           select new
                           {
                               u.Id,
                               u.Descricao,
                               u.Prazo,
                               u.Status,
                               u.Total
                           };

            Tabela.DataSource = pedidos.ToList();

            Tabela.Columns[0].HeaderText = "Código";
            Tabela.Columns[1].HeaderText = "Descrição";
            Tabela.Columns[2].HeaderText = "Prazo";
            Tabela.Columns[3].HeaderText = "Status";
            Tabela.Columns[4].HeaderText = "Total R$";
        }

        private void LoadSelecionado()
        {
            this.selecionado = new Pedido();
            int id = Convert.ToInt32(Tabela.CurrentRow.Cells[0].Value);
            this.selecionado = controller.Find(id);
        }

        private void BtBuscar_Click(object sender, EventArgs e)
        {
            Buscar(TbBuscar.Text);
        }

        private void TbBuscar_TextChanged(object sender, EventArgs e)
        {
            Buscar(TbBuscar.Text);
        }

        private void BtRecebido_Click(object sender, EventArgs e)
        {
            this.selecionado.Status = StatusPedido.ENTREGUE;
            this.selecionado.Entrega = DateTime.Now;
            controller.Save(selecionado);
            Buscar("");
        }

        private void BtCancelado_Click(object sender, EventArgs e)
        {
            this.selecionado.Status = StatusPedido.REJEITADO;
            controller.Save(selecionado);
            Buscar("");
        }

        private void Tabela_MouseClick(object sender, MouseEventArgs e)
        {
            LoadSelecionado();
            BtRecebido.Enabled = selecionado.Status == StatusPedido.ACEITO;
            BtCancelado.Enabled = selecionado.Status == StatusPedido.AGUARDANDO;
        }

        private void BtConferir_Click(object sender, EventArgs e)
        {
            if(selecionado != null)
                new ProdutosDoFornecedor(controller.ProdutosDoPedido(selecionado)).Show();
        }
    }
}
