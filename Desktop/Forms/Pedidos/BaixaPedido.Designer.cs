namespace Desktop.Forms.Pedidos
{
    partial class BaixaPedido
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
            this.BtRecebido = new System.Windows.Forms.Button();
            this.BtCancelado = new System.Windows.Forms.Button();
            this.BtConferir = new System.Windows.Forms.Button();
            this.PanelBusca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tabela)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelBusca
            // 
            this.PanelBusca.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelBusca.Location = new System.Drawing.Point(-4, 0);
            this.PanelBusca.Margin = new System.Windows.Forms.Padding(4);
            this.PanelBusca.Size = new System.Drawing.Size(542, 44);
            // 
            // BtBuscar
            // 
            this.BtBuscar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtBuscar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtBuscar.Location = new System.Drawing.Point(385, 6);
            this.BtBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.BtBuscar.Size = new System.Drawing.Size(143, 34);
            this.BtBuscar.UseVisualStyleBackColor = false;
            this.BtBuscar.Click += new System.EventHandler(this.BtBuscar_Click);
            // 
            // TbBuscar
            // 
            this.TbBuscar.Location = new System.Drawing.Point(7, 12);
            this.TbBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.TbBuscar.Size = new System.Drawing.Size(373, 23);
            this.TbBuscar.TextChanged += new System.EventHandler(this.TbBuscar_TextChanged);
            // 
            // Tabela
            // 
            this.Tabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tabela.Location = new System.Drawing.Point(7, 51);
            this.Tabela.MultiSelect = false;
            this.Tabela.Name = "Tabela";
            this.Tabela.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Tabela.Size = new System.Drawing.Size(524, 232);
            this.Tabela.TabIndex = 1;
            this.Tabela.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Tabela_MouseClick);
            // 
            // BtRecebido
            // 
            this.BtRecebido.Enabled = false;
            this.BtRecebido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtRecebido.ForeColor = System.Drawing.Color.Green;
            this.BtRecebido.Location = new System.Drawing.Point(6, 289);
            this.BtRecebido.Name = "BtRecebido";
            this.BtRecebido.Size = new System.Drawing.Size(90, 32);
            this.BtRecebido.TabIndex = 2;
            this.BtRecebido.Text = "Recebido";
            this.BtRecebido.UseVisualStyleBackColor = true;
            this.BtRecebido.Click += new System.EventHandler(this.BtRecebido_Click);
            // 
            // BtCancelado
            // 
            this.BtCancelado.Enabled = false;
            this.BtCancelado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtCancelado.ForeColor = System.Drawing.Color.DarkRed;
            this.BtCancelado.Location = new System.Drawing.Point(112, 289);
            this.BtCancelado.Name = "BtCancelado";
            this.BtCancelado.Size = new System.Drawing.Size(90, 32);
            this.BtCancelado.TabIndex = 3;
            this.BtCancelado.Text = "Cancelar";
            this.BtCancelado.UseVisualStyleBackColor = true;
            this.BtCancelado.Click += new System.EventHandler(this.BtCancelado_Click);
            // 
            // BtConferir
            // 
            this.BtConferir.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtConferir.Location = new System.Drawing.Point(402, 287);
            this.BtConferir.Name = "BtConferir";
            this.BtConferir.Size = new System.Drawing.Size(129, 34);
            this.BtConferir.TabIndex = 4;
            this.BtConferir.Text = "Conferir Produtos";
            this.BtConferir.UseVisualStyleBackColor = false;
            this.BtConferir.Click += new System.EventHandler(this.BtConferir_Click);
            // 
            // BaixaPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(537, 322);
            this.Controls.Add(this.BtConferir);
            this.Controls.Add(this.BtCancelado);
            this.Controls.Add(this.BtRecebido);
            this.Controls.Add(this.Tabela);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BaixaPedido";
            this.Text = "BaixaPedido";
            this.Controls.SetChildIndex(this.PanelBusca, 0);
            this.Controls.SetChildIndex(this.Tabela, 0);
            this.Controls.SetChildIndex(this.BtRecebido, 0);
            this.Controls.SetChildIndex(this.BtCancelado, 0);
            this.Controls.SetChildIndex(this.BtConferir, 0);
            this.PanelBusca.ResumeLayout(false);
            this.PanelBusca.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tabela)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Tabela;
        private System.Windows.Forms.Button BtRecebido;
        private System.Windows.Forms.Button BtCancelado;
        private System.Windows.Forms.Button BtConferir;
    }
}