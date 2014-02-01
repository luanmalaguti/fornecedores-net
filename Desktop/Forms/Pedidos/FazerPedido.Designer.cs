namespace Desktop.Forms.Pedidos
{
    partial class FazerPedido
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
            this.BtPedido = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TbFornecedor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TbPrazo = new System.Windows.Forms.MaskedTextBox();
            this.TbDescricao = new System.Windows.Forms.RichTextBox();
            this.Tabela = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtAdicionar = new System.Windows.Forms.Button();
            this.BtRemover = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PanelBotoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tabela)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelBotoes
            // 
            this.PanelBotoes.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.PanelBotoes.Controls.Add(this.BtPedido);
            this.PanelBotoes.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelBotoes.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.PanelBotoes.Location = new System.Drawing.Point(1, 1);
            this.PanelBotoes.Name = "PanelBotoes";
            this.PanelBotoes.Size = new System.Drawing.Size(603, 39);
            this.PanelBotoes.TabIndex = 0;
            // 
            // BtPedido
            // 
            this.BtPedido.ForeColor = System.Drawing.Color.Black;
            this.BtPedido.Location = new System.Drawing.Point(15, 3);
            this.BtPedido.Name = "BtPedido";
            this.BtPedido.Size = new System.Drawing.Size(157, 32);
            this.BtPedido.TabIndex = 0;
            this.BtPedido.Text = "Confirmar Pedido";
            this.BtPedido.UseVisualStyleBackColor = true;
            this.BtPedido.Click += new System.EventHandler(this.BtPedido_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fornecedor";
            // 
            // TbFornecedor
            // 
            this.TbFornecedor.Enabled = false;
            this.TbFornecedor.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbFornecedor.Location = new System.Drawing.Point(16, 76);
            this.TbFornecedor.Name = "TbFornecedor";
            this.TbFornecedor.Size = new System.Drawing.Size(261, 23);
            this.TbFornecedor.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(343, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Prazo";
            // 
            // TbPrazo
            // 
            this.TbPrazo.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbPrazo.Location = new System.Drawing.Point(346, 76);
            this.TbPrazo.Mask = "00/00/0000 90:00";
            this.TbPrazo.Name = "TbPrazo";
            this.TbPrazo.Size = new System.Drawing.Size(172, 23);
            this.TbPrazo.TabIndex = 4;
            this.TbPrazo.ValidatingType = typeof(System.DateTime);
            // 
            // TbDescricao
            // 
            this.TbDescricao.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbDescricao.Location = new System.Drawing.Point(16, 131);
            this.TbDescricao.Name = "TbDescricao";
            this.TbDescricao.Size = new System.Drawing.Size(588, 47);
            this.TbDescricao.TabIndex = 5;
            this.TbDescricao.Text = "";
            // 
            // Tabela
            // 
            this.Tabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tabela.Location = new System.Drawing.Point(16, 213);
            this.Tabela.MultiSelect = false;
            this.Tabela.Name = "Tabela";
            this.Tabela.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Tabela.Size = new System.Drawing.Size(588, 189);
            this.Tabela.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Descrição Do Pedido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Produtos do Pedido";
            // 
            // BtAdicionar
            // 
            this.BtAdicionar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtAdicionar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtAdicionar.Location = new System.Drawing.Point(348, 181);
            this.BtAdicionar.Name = "BtAdicionar";
            this.BtAdicionar.Size = new System.Drawing.Size(107, 26);
            this.BtAdicionar.TabIndex = 9;
            this.BtAdicionar.Text = "Adicionar";
            this.BtAdicionar.UseVisualStyleBackColor = false;
            this.BtAdicionar.Click += new System.EventHandler(this.BtAdicionar_Click);
            // 
            // BtRemover
            // 
            this.BtRemover.BackColor = System.Drawing.Color.Red;
            this.BtRemover.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtRemover.Location = new System.Drawing.Point(461, 181);
            this.BtRemover.Name = "BtRemover";
            this.BtRemover.Size = new System.Drawing.Size(107, 26);
            this.BtRemover.TabIndex = 10;
            this.BtRemover.Text = "Remover";
            this.BtRemover.UseVisualStyleBackColor = false;
            this.BtRemover.Click += new System.EventHandler(this.BtRemover_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(362, 415);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "TOTAL:  R$";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.BackColor = System.Drawing.Color.Green;
            this.lbTotal.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.Location = new System.Drawing.Point(445, 415);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(0, 16);
            this.lbTotal.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 16);
            this.label6.TabIndex = 12;
            // 
            // FazerPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(610, 440);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtRemover);
            this.Controls.Add(this.BtAdicionar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Tabela);
            this.Controls.Add(this.TbDescricao);
            this.Controls.Add(this.TbPrazo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TbFornecedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PanelBotoes);
            this.Name = "FazerPedido";
            this.Text = "FazerPedido";
            this.PanelBotoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Tabela)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelBotoes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbFornecedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox TbPrazo;
        private System.Windows.Forms.RichTextBox TbDescricao;
        private System.Windows.Forms.DataGridView Tabela;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtAdicionar;
        private System.Windows.Forms.Button BtRemover;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtPedido;
    }
}