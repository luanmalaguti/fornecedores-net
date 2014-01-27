using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Desktop.Forms.Produtos;
using Desktop.Forms.Template;
using Desktop.Forms.User;

namespace Desktop.Forms
{
    public partial class Principal : BasicForm
    {
        public Principal()
        {
            InitializeComponent();
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
    }
}
