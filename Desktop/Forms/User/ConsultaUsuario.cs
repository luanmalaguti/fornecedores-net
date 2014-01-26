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
using Model.POCO;

namespace Desktop.Forms.User
{
    public partial class ConsultaUsuario : BasicConsulta
    {
        public Usuario usuario { get; set; }
        private UsuarioController controller = new UsuarioController();
        
        public ConsultaUsuario()
        {
            this.Text = "Consulta de Usuários";
            InitializeComponent();
            Buscar("");
        }

        public void Buscar(string param)
        {
            var usuarios = from u in ConnProvider.getContext().Usuario
                               where u.Username.Contains(param) && u.Admin
                               select new
                               {
                                   u.Id,
                                   u.Username,
                                   u.Password,
                                   u.Admin
                               };

            Tabela.DataSource = usuarios.ToList();

            Tabela.Columns[0].HeaderText = "Código";
            Tabela.Columns[1].HeaderText = "Username";
            Tabela.Columns[2].HeaderText = "Senha";
            Tabela.Columns[3].HeaderText = "Admin";
        }

        public void LoadUsuario()
        {
           this.usuario = new Usuario();
           int id = Convert.ToInt32(Tabela.CurrentRow.Cells[0].Value);
           this.usuario = controller.Find(id);
        }

        private void Tabela_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            LoadUsuario();
            this.DialogResult = DialogResult.OK;
        }

        private void TbBuscar_TextChanged(object sender, EventArgs e)
        {
            Buscar(TbBuscar.Text.Trim());
        }

        private void BtBuscar_Click(object sender, EventArgs e)
        {
            Buscar(TbBuscar.Text.Trim());
        }
    }
}
