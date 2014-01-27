namespace Desktop.Forms.Produtos
{
    partial class CadastroProdutos
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
            this.TbDescricao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TbTamanho = new System.Windows.Forms.TextBox();
            this.TbUnidMedida = new System.Windows.Forms.TextBox();
            this.PanelBotoes.SuspendLayout();
            this.PainelCampos.SuspendLayout();
            this.SuspendLayout();
            // 
            // PainelCampos
            // 
            this.PainelCampos.Controls.Add(this.TbUnidMedida);
            this.PainelCampos.Controls.Add(this.TbTamanho);
            this.PainelCampos.Controls.Add(this.label3);
            this.PainelCampos.Controls.Add(this.label2);
            this.PainelCampos.Controls.Add(this.TbDescricao);
            this.PainelCampos.Controls.Add(this.label1);
            this.PainelCampos.Size = new System.Drawing.Size(434, 166);
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
            this.BtBuscar.Click += new System.EventHandler(this.BtBuscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descrição";
            // 
            // TbDescricao
            // 
            this.TbDescricao.Location = new System.Drawing.Point(11, 33);
            this.TbDescricao.Name = "TbDescricao";
            this.TbDescricao.Size = new System.Drawing.Size(400, 23);
            this.TbDescricao.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tamanho";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(226, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Unid. Medida";
            // 
            // TbTamanho
            // 
            this.TbTamanho.Location = new System.Drawing.Point(11, 92);
            this.TbTamanho.Name = "TbTamanho";
            this.TbTamanho.Size = new System.Drawing.Size(182, 23);
            this.TbTamanho.TabIndex = 4;
            // 
            // TbUnidMedida
            // 
            this.TbUnidMedida.Location = new System.Drawing.Point(229, 92);
            this.TbUnidMedida.Name = "TbUnidMedida";
            this.TbUnidMedida.Size = new System.Drawing.Size(182, 23);
            this.TbUnidMedida.TabIndex = 5;
            // 
            // CadastroProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 244);
            this.Name = "CadastroProdutos";
            this.Text = "CadastroProdutos";
            this.PanelBotoes.ResumeLayout(false);
            this.PainelCampos.ResumeLayout(false);
            this.PainelCampos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TbUnidMedida;
        private System.Windows.Forms.TextBox TbTamanho;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbDescricao;
        private System.Windows.Forms.Label label1;

    }
}