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
using Desktop.Forms.Produtos;
using Desktop.Forms.Template;
using Desktop.Forms.User;
using Model;
using Model.POCO;

namespace Desktop.Forms
{
    public partial class Principal : BasicForm
    {
        private Usuario usuario { get; set; }
        
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

            Tabela.DataSource = pedidos.ToList();

            Tabela.Columns[0].HeaderText = "Código";
            Tabela.Columns[1].HeaderText = "Descrição";
            Tabela.Columns[2].HeaderText = "Prazo";
            Tabela.Columns[3].HeaderText = "Entrega";
            Tabela.Columns[4].HeaderText = "Status";
            Tabela.Columns[5].HeaderText = "Total R$";
        }
    }
}
