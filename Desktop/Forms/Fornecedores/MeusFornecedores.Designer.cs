namespace Desktop.Forms
{
    partial class MeusFornecedores
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
            this.BtProdutos = new System.Windows.Forms.Button();
            this.BtPedido = new System.Windows.Forms.Button();
            this.Tabela = new System.Windows.Forms.DataGridView();
            this.PanelBotoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tabela)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelBotoes
            // 
            this.PanelBotoes.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.PanelBotoes.Controls.Add(this.BtPedido);
            this.PanelBotoes.Controls.Add(this.BtProdutos);
            this.PanelBotoes.Location = new System.Drawing.Point(2, 0);
            this.PanelBotoes.Name = "PanelBotoes";
            this.PanelBotoes.Size = new System.Drawing.Size(550, 39);
            this.PanelBotoes.TabIndex = 0;
            // 
            // BtProdutos
            // 
            this.BtProdutos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtProdutos.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtProdutos.Location = new System.Drawing.Point(128, 4);
            this.BtProdutos.Name = "BtProdutos";
            this.BtProdutos.Size = new System.Drawing.Size(139, 32);
            this.BtProdutos.TabIndex = 0;
            this.BtProdutos.Text = "Exibir Produtos";
            this.BtProdutos.UseVisualStyleBackColor = false;
            this.BtProdutos.Click += new System.EventHandler(this.BtProdutos_Click);
            // 
            // BtPedido
            // 
            this.BtPedido.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtPedido.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtPedido.Location = new System.Drawing.Point(275, 4);
            this.BtPedido.Name = "BtPedido";
            this.BtPedido.Size = new System.Drawing.Size(139, 32);
            this.BtPedido.TabIndex = 1;
            this.BtPedido.Text = "Efetuar Pedido";
            this.BtPedido.UseVisualStyleBackColor = false;
            this.BtPedido.Click += new System.EventHandler(this.BtPedido_Click);
            // 
            // Tabela
            // 
            this.Tabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tabela.Location = new System.Drawing.Point(2, 46);
            this.Tabela.MultiSelect = false;
            this.Tabela.Name = "Tabela";
            this.Tabela.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Tabela.Size = new System.Drawing.Size(550, 259);
            this.Tabela.TabIndex = 1;
            // 
            // MeusFornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 304);
            this.Controls.Add(this.Tabela);
            this.Controls.Add(this.PanelBotoes);
            this.Name = "MeusFornecedores";
            this.Text = "MeusFornecedores";
            this.PanelBotoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Tabela)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelBotoes;
        private System.Windows.Forms.Button BtPedido;
        private System.Windows.Forms.Button BtProdutos;
        private System.Windows.Forms.DataGridView Tabela;

    }
}