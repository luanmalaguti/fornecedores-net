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
using Desktop.Forms.Model;
using Desktop.Forms.Pedidos;
using Desktop.Forms.Produtos;
using Desktop.Forms.Reports;
using Desktop.Forms.Template;
using Desktop.Forms.User;
using Model;
using Model.POCO;
using ConsultaProdutos = Desktop.Forms.Produtos.ConsultaProdutos;

namespace Desktop.Forms
{
    public partial class Principal : BasicForm
    {
        private Usuario usuario { get; set; }
        FornecedorController fornecedorController = new FornecedorController();
        
        public Principal(Usuario usuario)
        {
            this.usuario = usuario;
            InitializeComponent();
            LbLogado.Text = usuario.Username;

            UpdateTabela();
        }

        private void UsuariosNovo_Click(object sender, EventArgs e)
        {
            new CadastroUsuario().Show(); 
        }

        private void UsuariosBuscar_Click(object sender, EventArgs e)
        {
            new ConsultaUsuario().Show();
        }

        private void ProdutosNovo_Click(object sender, EventArgs e)
        {
            new CadastroProdutos().Show();
        }

        private void ProdutosBuscar_Click(object sender, EventArgs e)
        {
            new ConsultaProdutos().Show();
        }

        private void Sair_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void BtFornecedores_Click(object sender, EventArgs e)
        {
            new MeusFornecedores(this).Show();
        }

        private void PedidosNovo_Click(object sender, EventArgs e)
        {
            new MeusFornecedores(this).Show();
        }

        public void UpdateTabela()
        {
           var pedidos = from p in ConnProvider.getContext().Pedido
                              
                               select new
                               {
                                   p.Id,
                                   p.Descricao,
                                   p.Prazo,
                                   p.Entrega,
                                   p.Status,
                                   p.Total,
                               };

            //Tabela.DataSource = pedidos.ToList();

            //-------------------------------------
            List<Fornecedor> fornecedores = fornecedorController.FindAll().ToList();

            List<TableModel> tableModel = new List<TableModel>();
            foreach (var f in fornecedores)
            {
                foreach (var p in f.Pedidos)
                {
                    tableModel.Add(new TableModel(f,p));
                }
            }

            Tabela.DataSource = tableModel.ToList();

            Tabela.Columns[0].HeaderText = "Fornecedor";
            Tabela.Columns[1].HeaderText = "Cnpj";
            Tabela.Columns[2].HeaderText = "Pedido";
            Tabela.Columns[3].HeaderText = "Status";
            Tabela.Columns[4].HeaderText = "Total R$";
            Tabela.Columns[5].HeaderText = "Prazo";
            Tabela.Columns[6].HeaderText = "Entrega";
        }

        private void BtBaixa_Click(object sender, EventArgs e)
        {
            new BaixaPedido().Show();
        }

        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new PedidosReportForm().Show();
        }

        private void PedidosBuscar_Click(object sender, EventArgs e)
        {
            new BaixaPedido().Show();
        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FornecedoresReportForm().Show();
        }
    }
}
