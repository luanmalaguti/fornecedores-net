namespace Desktop.Forms.Template
{
    partial class BasicCadastro
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
            this.PanelBotoes = new System.Windows.Forms.Panel();
            this.BtBuscar = new System.Windows.Forms.Button();
            this.BtNovo = new System.Windows.Forms.Button();
            this.BtRemover = new System.Windows.Forms.Button();
            this.BtSalvar = new System.Windows.Forms.Button();
            this.PainelCampos = new System.Windows.Forms.Panel();
            this.lbErro = new System.Windows.Forms.Label();
            this.PanelBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelBotoes
            // 
            this.PanelBotoes.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.PanelBotoes.Controls.Add(this.BtBuscar);
            this.PanelBotoes.Controls.Add(this.BtNovo);
            this.PanelBotoes.Controls.Add(this.BtRemover);
            this.PanelBotoes.Controls.Add(this.BtSalvar);
            this.PanelBotoes.Location = new System.Drawing.Point(13, 13);
            this.PanelBotoes.Name = "PanelBotoes";
            this.PanelBotoes.Size = new System.Drawing.Size(434, 38);
            this.PanelBotoes.TabIndex = 0;
            // 
            // BtBuscar
            // 
            this.BtBuscar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtBuscar.Location = new System.Drawing.Point(356, 4);
            this.BtBuscar.Name = "BtBuscar";
            this.BtBuscar.Size = new System.Drawing.Size(75, 31);
            this.BtBuscar.TabIndex = 3;
            this.BtBuscar.Text = "Buscar";
            this.BtBuscar.UseVisualStyleBackColor = true;
            // 
            // BtNovo
            // 
            this.BtNovo.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtNovo.Location = new System.Drawing.Point(166, 4);
            this.BtNovo.Name = "BtNovo";
            this.BtNovo.Size = new System.Drawing.Size(75, 31);
            this.BtNovo.TabIndex = 2;
            this.BtNovo.Text = "Novo";
            this.BtNovo.UseVisualStyleBackColor = true;
            // 
            // BtRemover
            // 
            this.BtRemover.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtRemover.Location = new System.Drawing.Point(87, 4);
            this.BtRemover.Name = "BtRemover";
            this.BtRemover.Size = new System.Drawing.Size(75, 31);
            this.BtRemover.TabIndex = 1;
            this.BtRemover.Text = "Remover";
            this.BtRemover.UseVisualStyleBackColor = true;
            // 
            // BtSalvar
            // 
            this.BtSalvar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtSalvar.Location = new System.Drawing.Point(8, 4);
            this.BtSalvar.Name = "BtSalvar";
            this.BtSalvar.Size = new System.Drawing.Size(75, 31);
            this.BtSalvar.TabIndex = 0;
            this.BtSalvar.Text = "Salvar";
            this.BtSalvar.UseVisualStyleBackColor = true;
            // 
            // PainelCampos
            // 
            this.PainelCampos.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PainelCampos.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PainelCampos.Location = new System.Drawing.Point(13, 67);
            this.PainelCampos.Name = "PainelCampos";
            this.PainelCampos.Size = new System.Drawing.Size(434, 183);
            this.PainelCampos.TabIndex = 1;
            // 
            // lbErro
            // 
            this.lbErro.AutoSize = true;
            this.lbErro.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErro.ForeColor = System.Drawing.Color.Red;
            this.lbErro.Location = new System.Drawing.Point(11, 53);
            this.lbErro.Name = "lbErro";
            this.lbErro.Size = new System.Drawing.Size(0, 13);
            this.lbErro.TabIndex = 2;
            // 
            // BasicCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 262);
            this.Controls.Add(this.lbErro);
            this.Controls.Add(this.PainelCampos);
            this.Controls.Add(this.PanelBotoes);
            this.Name = "BasicCadastro";
            this.Text = "BasicCadastro";
            this.PanelBotoes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel PanelBotoes;
        public System.Windows.Forms.Panel PainelCampos;
        public System.Windows.Forms.Button BtNovo;
        public System.Windows.Forms.Button BtRemover;
        public System.Windows.Forms.Button BtSalvar;
        public System.Windows.Forms.Button BtBuscar;
        public System.Windows.Forms.Label lbErro;
    }
}