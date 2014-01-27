using System;
using System.Windows.Forms;
using Desktop.Controller;
using Desktop.Forms.Template;
using Model.POCO;

namespace Desktop.Forms.User
{
    public partial class CadastroUsuario : BasicCadastro
    {
        private Usuario usuario { get; set;}
        private UsuarioController controller = new UsuarioController();

        public CadastroUsuario()
        {
            this.Text = "Cadastro de Usuários";
            this.usuario = new Usuario();

            InitializeComponent();
        }

        protected override void ToFields()
        {
            TbUsername.Text = usuario == null ? "" : usuario.Username;
            TbSenha.Text = usuario == null ? "" : usuario.Password;
        }

        protected override void ToData()
        {
            this.usuario.Username = TbUsername.Text;
            this.usuario.Password = TbSenha.Text;
            this.usuario.Admin = true;
        }

        private void BtSalvar_Click(object sender, EventArgs e)
        {
            ToData();

            if (IsValid())
            {
                usuario = controller.Save(usuario);
                ShowSuccess("Cadastro realizado com sucesso!");
            }
        }

        private void BtNovo_Click(object sender, EventArgs e)
        {
            Novo();
        }

        private void BtRemover_Click(object sender, EventArgs e)
        {
            if (usuario.Id <= 0)
            {
                ShowError("Nenhum usuário foi selecionado");
                return;
            }

            controller.Remove(usuario);    
            Novo();
            ShowSuccess("Registro removido com sucesso!");
        }

        private bool IsValid()
        {
            if (!usuario.Password.Equals(TbConfirmacao.Text))
            {
                ShowError("A confirmação da senha não é valida");
                return false;
            }

            if (TbUsername.Text.Trim().Equals("") || TbSenha.Text.Trim().Equals(""))
            {
                ShowError("Todos os campos devem ser informados!");
                return false;
            }

            return true;
        }

        public void Novo()
        {
            this.usuario = new Usuario();
            ToFields();
            TbConfirmacao.Text = "";
            ClearMessage();
        }

        private void BtBuscar_Click(object sender, EventArgs e)
        {
            var consulta = new ConsultaUsuario();

            if (consulta.ShowDialog(this) == DialogResult.OK)
            {
                this.usuario = consulta.usuario;
                ToFields();
            }
        }
    }
}
