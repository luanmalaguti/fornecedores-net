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
using Desktop.Forms.Template;
using Model;

namespace Desktop.Forms.Pedidos
{
    public partial class ConsultaProdutos : BasicConsulta
    {
        private FornecedorController fornecedorController = new FornecedorController();
        private ProdutoController produtoController = new ProdutoController();
        public Produto produto { get; set; }

        public ConsultaProdutos(Fornecedor fornecedor)
        {
            InitializeComponent();

            Tabela.DataSource = fornecedorController.ProdutosDoFornecedor(fornecedor.Id).ToList();

            Tabela.Columns[0].HeaderText = "Código";
            Tabela.Columns[1].HeaderText = "Descrição";
            Tabela.Columns[2].HeaderText = "Tamanho";
            Tabela.Columns[3].HeaderText = "Unid. Medida";
            Tabela.Columns[4].HeaderText = "R$";
        }

        public void LoadProduto() 
        {
           this.produto = new Produto();
           int id = Convert.ToInt32(Tabela.CurrentRow.Cells[0].Value);
           this.produto = produtoController.Find(id);
        }

        private void Tabela_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            LoadProduto();
            this.DialogResult = DialogResult.OK;
        }
    }
}
