namespace Desktop.Forms.Pedidos
{
    partial class ConsultaProdutos
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
            this.Tabela = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.TbQtde = new System.Windows.Forms.MaskedTextBox();
            this.LbErro = new System.Windows.Forms.Label();
            this.PanelBusca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tabela)).BeginInit();
            this.SuspendLayout();
            // 
            // BtBuscar
            // 
            this.BtBuscar.Location = new System.Drawing.Point(394, 4);
            // 
            // TbBuscar
            // 
            this.TbBuscar.Size = new System.Drawing.Size(369, 23);
            // 
            // Tabela
            // 
            this.Tabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tabela.Location = new System.Drawing.Point(-3, 42);
            this.Tabela.Name = "Tabela";
            this.Tabela.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Tabela.Size = new System.Drawing.Size(507, 189);
            this.Tabela.TabIndex = 1;
            this.Tabela.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Tabela_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(343, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Quantidade:";
            // 
            // TbQtde
            // 
            this.TbQtde.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbQtde.Location = new System.Drawing.Point(438, 237);
            this.TbQtde.Mask = "00";
            this.TbQtde.Name = "TbQtde";
            this.TbQtde.Size = new System.Drawing.Size(52, 23);
            this.TbQtde.TabIndex = 3;
            // 
            // LbErro
            // 
            this.LbErro.AutoSize = true;
            this.LbErro.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbErro.ForeColor = System.Drawing.Color.Red;
            this.LbErro.Location = new System.Drawing.Point(13, 240);
            this.LbErro.Name = "LbErro";
            this.LbErro.Size = new System.Drawing.Size(0, 16);
            this.LbErro.TabIndex = 4;
            // 
            // ConsultaProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(502, 262);
            this.Controls.Add(this.LbErro);
            this.Controls.Add(this.TbQtde);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Tabela);
            this.Name = "ConsultaProdutos";
            this.Text = "ConsultaProdutos";
            this.Controls.SetChildIndex(this.PanelBusca, 0);
            this.Controls.SetChildIndex(this.Tabela, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.TbQtde, 0);
            this.Controls.SetChildIndex(this.LbErro, 0);
            this.PanelBusca.ResumeLayout(false);
            this.PanelBusca.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tabela)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Tabela;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox TbQtde;
        private System.Windows.Forms.Label LbErro;
    }
}