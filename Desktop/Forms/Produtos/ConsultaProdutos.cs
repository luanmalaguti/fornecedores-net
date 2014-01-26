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
    public partial class ConsultaProdutos : BasicConsulta
    {
        public Produto produto { get; set; }
        private UsuarioController controller = new UsuarioController();
        
        public ConsultaProdutos()
        {
            this.Text = "Consulta de Produtos";
            InitializeComponent();
            Buscar("");
        }

        private void Buscar(string param)
        {
            var produtos = from p in ConnProvider.getContext().Produto
                           where p.Descricao.Contains(param)
                           select new
                           {
                               p.Id,
                               p.Descricao,
                               p.Tamanho,
                               p.UnidadeMedida
                           };

            Tabela.DataSource = produtos.ToList();

            Tabela.Columns[0].HeaderText = "Código";
            Tabela.Columns[1].HeaderText = "Descrição";
            Tabela.Columns[2].HeaderText = "Tamanho";
            Tabela.Columns[3].HeaderText = "Unid. Medida";
        }

        private void BtBuscar_Click(object sender, EventArgs e)
        {
            Buscar(TbBuscar.Text);
        }

        private void TbBuscar_TextChanged(object sender, EventArgs e)
        {
            Buscar(TbBuscar.Text);
        }
    }
}
