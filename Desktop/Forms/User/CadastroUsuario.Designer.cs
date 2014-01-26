namespace Desktop.Forms.User
{
    partial class CadastroUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TbUsername = new System.Windows.Forms.TextBox();
            this.TbSenha = new System.Windows.Forms.TextBox();
            this.TbConfirmacao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PanelBotoes.SuspendLayout();
            this.PainelCampos.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelBotoes
            // 
            this.PanelBotoes.Size = new System.Drawing.Size(381, 38);
            // 
            // PainelCampos
            // 
            this.PainelCampos.Controls.Add(this.TbConfirmacao);
            this.PainelCampos.Controls.Add(this.label3);
            this.PainelCampos.Controls.Add(this.TbSenha);
            this.PainelCampos.Controls.Add(this.TbUsername);
            this.PainelCampos.Controls.Add(this.label2);
            this.PainelCampos.Controls.Add(this.label1);
            this.PainelCampos.Size = new System.Drawing.Size(381, 154);
            // 
            // BtNovo
            // 
            this.BtNovo.Click += new System.EventHandler(this.BtNovo_Click);
            // 
            // BtRemover
            // 
            this.BtRemover.Click += new System.EventHandler(this.BtRemover_Click);
            // 
            // BtSalvar
            // 
            this.BtSalvar.Click += new System.EventHandler(this.BtSalvar_Click);
            // 
            // BtBuscar
            // 
            this.BtBuscar.Location = new System.Drawing.Point(299, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Senha";
            // 
            // TbUsername
            // 
            this.TbUsername.Location = new System.Drawing.Point(8, 37);
            this.TbUsername.Name = "TbUsername";
            this.TbUsername.Size = new System.Drawing.Size(338, 23);
            this.TbUsername.TabIndex = 2;
            // 
            // TbSenha
            // 
            this.TbSenha.Location = new System.Drawing.Point(8, 92);
            this.TbSenha.Name = "TbSenha";
            this.TbSenha.PasswordChar = '*';
            this.TbSenha.Size = new System.Drawing.Size(154, 23);
            this.TbSenha.TabIndex = 3;
            // 
            // TbConfirmacao
            // 
            this.TbConfirmacao.Location = new System.Drawing.Point(181, 92);
            this.TbConfirmacao.Name = "TbConfirmacao";
            this.TbConfirmacao.PasswordChar = '*';
            this.TbConfirmacao.Size = new System.Drawing.Size(165, 23);
            this.TbConfirmacao.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(178, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Confirmar Senha";
            // 
            // CadastroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 234);
            this.Name = "CadastroUsuario";
            this.Text = "CadastroUsuario";
            this.PanelBotoes.ResumeLayout(false);
            this.PainelCampos.ResumeLayout(false);
            this.PainelCampos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TbConfirmacao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TbSenha;
        private System.Windows.Forms.TextBox TbUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}