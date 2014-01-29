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
            this.Tabela.Location = new System.Drawing.Point(-3, 43);
            this.Tabela.Name = "Tabela";
            this.Tabela.Size = new System.Drawing.Size(501, 219);
            this.Tabela.TabIndex = 1;
            this.Tabela.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Tabela_MouseDoubleClick);
            // 
            // ConsultaProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 262);
            this.Controls.Add(this.Tabela);
            this.Name = "ConsultaProdutos";
            this.Text = "ConsultaProdutos";
            this.Controls.SetChildIndex(this.PanelBusca, 0);
            this.Controls.SetChildIndex(this.Tabela, 0);
            this.PanelBusca.ResumeLayout(false);
            this.PanelBusca.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tabela)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Tabela;
    }
}