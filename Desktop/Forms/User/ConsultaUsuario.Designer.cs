namespace Desktop.Forms.User
{
    partial class ConsultaUsuario
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
            // PanelBusca
            // 
            this.PanelBusca.Location = new System.Drawing.Point(-4, 0);
            this.PanelBusca.Margin = new System.Windows.Forms.Padding(4);
            this.PanelBusca.Size = new System.Drawing.Size(769, 44);
            // 
            // BtBuscar
            // 
            this.BtBuscar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BtBuscar.Location = new System.Drawing.Point(396, 6);
            this.BtBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.BtBuscar.Size = new System.Drawing.Size(143, 34);
            this.BtBuscar.UseVisualStyleBackColor = false;
            this.BtBuscar.Click += new System.EventHandler(this.BtBuscar_Click);
            // 
            // TbBuscar
            // 
            this.TbBuscar.Location = new System.Drawing.Point(25, 9);
            this.TbBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.TbBuscar.Size = new System.Drawing.Size(353, 23);
            this.TbBuscar.TextChanged += new System.EventHandler(this.TbBuscar_TextChanged);
            // 
            // Tabela
            // 
            this.Tabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tabela.Location = new System.Drawing.Point(16, 52);
            this.Tabela.Margin = new System.Windows.Forms.Padding(4);
            this.Tabela.Name = "Tabela";
            this.Tabela.Size = new System.Drawing.Size(519, 256);
            this.Tabela.TabIndex = 1;
            this.Tabela.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Tabela_MouseDoubleClick);
            // 
            // ConsultaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 322);
            this.Controls.Add(this.Tabela);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ConsultaUsuario";
            this.Text = "ConsultaUsuario";
            this.Controls.SetChildIndex(this.Tabela, 0);
            this.Controls.SetChildIndex(this.PanelBusca, 0);
            this.PanelBusca.ResumeLayout(false);
            this.PanelBusca.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tabela)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Tabela;
    }
}