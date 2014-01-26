using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
    }
}
