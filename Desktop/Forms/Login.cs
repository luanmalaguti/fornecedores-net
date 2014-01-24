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

namespace Desktop.Forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
               if (new LoginController().Login(tbUsername.Text, tbSenha.Text))
               {
                   new Principal().Show();
               }
               else
               {
                   lbError.Text = "Login ou Senha inválidos";
               }
            }
        }

        private bool ValidarCampos()
        {
            if(tbUsername.Text.Trim().Equals(""))
            {
                lbUsername.Text = "Informe o Username";
                return false;
            }
            else
            {
                lbUsername.Text = "";
            }

            if (tbSenha.Text.Trim().Equals(""))
            {
                lbSenha.Text = "Informe a Senha";
                return false;
            }
            else
            {
                lbSenha.Text = "";
            }

            return true;
        }
    }
}
