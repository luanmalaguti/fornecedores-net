using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Desktop.Controller;
using Model;
using Model.POCO;
using Model.Util;

namespace Desktop.Forms.Pedidos
{
    public partial class FazerPedido : Form
    {
        private ProdutoController produtoController = new ProdutoController();
        private PedidoController pedidoController = new PedidoController();
        private FornecedorController fornecedorController = new FornecedorController();

        private Fornecedor fornecedor;
        private List<Produto> produtos = new List<Produto>(); 
        private Pedido pedido = new Pedido();

        public FazerPedido(Fornecedor fornecedor)
        {
            this.fornecedor = fornecedor;
            InitializeComponent();

            TbFornecedor.Text = fornecedor.RazaoSocial;
            pedido.Total = 0.00;
            UpdateTotal();
        }

        public void UpdateTabela()
        {
            Tabela.DataSource = produtos.ToList();

            Tabela.Columns[0].HeaderText = "Código";
            Tabela.Columns[1].HeaderText = "Descrição";
            Tabela.Columns[2].HeaderText = "Tamanho";
            Tabela.Columns[3].HeaderText = "Unid. Medida";
            Tabela.Columns[4].HeaderText = "R$";

            UpdateTotal();
        }

        public void UpdateTotal()
        {
            pedido.Total = 0.00;
            
            if (produtos.Any())
            {      
                foreach (var p in produtos)
                {
                    pedido.Total = pedido.Total + p.valor;
                }
            }

            lbTotal.Text = pedido.Total.ToString();
        }

        private void BtAdicionar_Click(object sender, EventArgs e)
        {
            var consulta = new ConsultaProdutos(fornecedor);

            if (consulta.ShowDialog(this) == DialogResult.OK)
            {
                this.produtos.Add(consulta.produto);
                UpdateTabela();
            }
        }

        private void BtRemover_Click(object sender, EventArgs e)
        {
            if(produtos.Any()){
                int id = Convert.ToInt32(Tabela.CurrentRow.Cells[0].Value);
                Produto selecionado = produtoController.Find(id);
                produtos.Remove(selecionado);
                UpdateTabela();
            }
        }

        public bool IsValid()
        {
            if (TbDescricao.Text.Trim().Equals(""))
            {
                ShowError("Campos obrigatórrios não informados!");
                return false;
            }
            return true;
        }

        public void ShowSuccess(string msg)
        {
            label6.ForeColor = Color.DarkGreen;
            label6.Text = msg;
        }

        public void ShowError(string msg)
        {
            label6.ForeColor = Color.Red;
            label6.Text = msg;
        }

        private void BtPedido_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                pedido.Descricao = TbDescricao.Text;
                pedido.Prazo = Convert.ToDateTime(TbPrazo.Text);
                pedido.Entrega = Convert.ToDateTime(TbPrazo.Text);
                pedido.Status = StatusPedido.AGUARDANDO;

                pedido = pedidoController.Save(pedido);

                // adiciona os produtos atuais da lista no pedido
                foreach (var p in produtos)
                {
                    ItemPedido item = new ItemPedido();
                    item.Pedido = pedido;
                    item.Produto = p;
                    item.quantidade = 1;

                    pedido.ItemsPedido.Add(item);
                }

                // registra o pedido
                pedidoController.Save(pedido);

                // registra o pedido para o fornecedor selecionado
                fornecedor.Pedidos.Add(pedido);
                fornecedorController.Save(fornecedor);

                ShowSuccess("Pedido ao fornecedor "+fornecedor.RazaoSocial+" efetuado com sucesso");
            }

        }
    }
}
