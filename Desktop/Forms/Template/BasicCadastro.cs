using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop.Forms.Template
{
    public partial class BasicCadastro : BasicForm
    {
        public BasicCadastro()
        {
            InitializeComponent();
        }

        protected virtual void ToFields(){}
        protected virtual void ToData(){}

        public void ShowSuccess(string msg)
        {
            lbErro.ForeColor = Color.DarkGreen;
            lbErro.Text = msg;
        }

        public void ShowError(string msg)
        {
            lbErro.ForeColor = Color.Red;
            lbErro.Text = msg;
        }

        public void ClearMessage()
        {
            lbErro.Text = "";
        }
    }
}
