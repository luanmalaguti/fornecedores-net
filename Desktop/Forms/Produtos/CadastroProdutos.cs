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
using Desktop.Forms.Template;
using Model;

namespace Desktop.Forms.Produtos
{
    public partial class CadastroProdutos : BasicCadastro
    {
        private Produto produto { get; set; }
        private ProdutoController controller = new ProdutoController();
        
        public CadastroProdutos()
        {
            this.Text = "Cadastro de Produtos";
            this.produto = new Produto();

            InitializeComponent();
        }

        private void BtSalvar_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                ToData(); 

                this.produto = controller.Save(this.produto);
                ShowSuccess("Cadastro realizado com sucesso!");
            }
        }

        protected override void ToFields()
        {
            TbDescricao.Text = this.produto.Descricao;
            TbTamanho.Text = this.produto.Tamanho.ToString();
            TbUnidMedida.Text = this.produto.UnidadeMedida;
        }

        protected override void ToData()
        {
            this.produto.Descricao = TbDescricao.Text;
            this.produto.Tamanho = Convert.ToInt32(TbTamanho.Text);
            this.produto.UnidadeMedida = TbUnidMedida.Text;
        }

        public void Novo()
        {
            this.produto = new Produto();
            ToFields();
            ClearMessage();
        }

        private bool IsValid()
        {
            if (TbDescricao.Text.Trim().Equals("") ||
                TbTamanho.Text.Trim().Equals("") ||
                TbUnidMedida.Text.Trim().Equals(""))
            {
                ShowError("Todos os campos devem ser informados");
                return false;
            }
            return true;
        }

        private void BtNovo_Click(object sender, EventArgs e)
        {
            Novo();
        }

        private void BtBuscar_Click(object sender, EventArgs e)
        {
            var produtos = new ConsultaProdutos();

            if (produtos.ShowDialog(this) == DialogResult.OK)
            {
                this.produto = produtos.produto;
                ToFields();
            }
        }

        private void BtRemover_Click(object sender, EventArgs e)
        {
            if (produto.Id <= 0)
            {
                ShowError("Nenhum produto foi selecionado");
                return;
            }

            controller.Remove(produto);
            Novo();
            ShowSuccess("Registro removido com sucesso!");
        }
    }
}
