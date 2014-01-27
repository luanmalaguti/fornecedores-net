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
using Model;
namespace Desktop.Forms
{
    public partial class MeusFornecedores : Form
    {
        private FornecedorController controller = new FornecedorController();
        private Fornecedor selecionado; 
        
        public MeusFornecedores()
        {
            this.Text = "Meus Fornecedores";

            InitializeComponent();
            LoadFornecedores();
        }

        private void LoadSelecionado()
        {
            this.selecionado = new Fornecedor();
            int id = Convert.ToInt32(Tabela.CurrentRow.Cells[0].Value);
            this.selecionado = controller.ProdutosDoFornecedor(id);
        }

        private void LoadFornecedores()
        {
            var fornecedores = from p in ConnProvider.getContext().Fornecedor
                           
                           select new
                           {
                               p.Id,
                               p.RazaoSocial,
                               p.Cnpj,
                               p.Telefone,
                               p.Endereco
                           };

            Tabela.DataSource = fornecedores.ToList();

            Tabela.Columns[0].HeaderText = "Código";
            Tabela.Columns[1].HeaderText = "Razão Social";
            Tabela.Columns[2].HeaderText = "Cnpj";
            Tabela.Columns[3].HeaderText = "Telefone";
            Tabela.Columns[4].HeaderText = "Endereço";
        }

        private void BtProdutos_Click(object sender, EventArgs e)
        {
            LoadSelecionado();
            if (selecionado != null)
            {
                new ProdutosDoFornecedor(selecionado.FornecedorProduto.)
            }
        }

        private void BtPedido_Click(object sender, EventArgs e)
        {

        }
    }
}
