using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace Desktop.Forms.Fornecedores
{
    public partial class ProdutosDoFornecedor : Form
    {
        public ProdutosDoFornecedor(List<Produto> produtos)
        {
            InitializeComponent();
            Tabela.DataSource = produtos.ToList();

            Tabela.Columns[0].HeaderText = "Código";
            Tabela.Columns[1].HeaderText = "Descrição";
            Tabela.Columns[2].HeaderText = "Tamanho";
            Tabela.Columns[3].HeaderText = "Unid. Medida";
        }
    }
}
