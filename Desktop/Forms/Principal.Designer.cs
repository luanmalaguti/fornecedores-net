namespace Desktop.Forms
{
    partial class Principal
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
            this.components = new System.ComponentModel.Container();
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.testeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UsuariosNovo = new System.Windows.Forms.ToolStripMenuItem();
            this.UsuariosBuscar = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProdutosNovo = new System.Windows.Forms.ToolStripMenuItem();
            this.ProdutosBuscar = new System.Windows.Forms.ToolStripMenuItem();
            this.teste2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PedidosNovo = new System.Windows.Forms.ToolStripMenuItem();
            this.PedidosBuscar = new System.Windows.Forms.ToolStripMenuItem();
            this.Sair = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.PanelBotoes = new System.Windows.Forms.Panel();
            this.BtFornecedores = new System.Windows.Forms.Button();
            this.LbLogado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelPrincipal = new System.Windows.Forms.Panel();
            this.Menu.SuspendLayout();
            this.PanelBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testeToolStripMenuItem,
            this.produtosToolStripMenuItem,
            this.teste2ToolStripMenuItem,
            this.Sair});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(805, 24);
            this.Menu.TabIndex = 0;
            // 
            // testeToolStripMenuItem
            // 
            this.testeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UsuariosNovo,
            this.UsuariosBuscar});
            this.testeToolStripMenuItem.Name = "testeToolStripMenuItem";
            this.testeToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.testeToolStripMenuItem.Text = "Usuários";
            // 
            // UsuariosNovo
            // 
            this.UsuariosNovo.Name = "UsuariosNovo";
            this.UsuariosNovo.Size = new System.Drawing.Size(120, 22);
            this.UsuariosNovo.Text = "Novo";
            this.UsuariosNovo.Click += new System.EventHandler(this.UsuariosNovo_Click);
            // 
            // UsuariosBuscar
            // 
            this.UsuariosBuscar.Name = "UsuariosBuscar";
            this.UsuariosBuscar.Size = new System.Drawing.Size(120, 22);
            this.UsuariosBuscar.Text = "Buscar";
            this.UsuariosBuscar.Click += new System.EventHandler(this.UsuariosBuscar_Click);
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProdutosNovo,
            this.ProdutosBuscar});
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.produtosToolStripMenuItem.Text = "Produtos";
            // 
            // ProdutosNovo
            // 
            this.ProdutosNovo.Name = "ProdutosNovo";
            this.ProdutosNovo.Size = new System.Drawing.Size(120, 22);
            this.ProdutosNovo.Text = "Novo";
            this.ProdutosNovo.Click += new System.EventHandler(this.ProdutosNovo_Click);
            // 
            // ProdutosBuscar
            // 
            this.ProdutosBuscar.Name = "ProdutosBuscar";
            this.ProdutosBuscar.Size = new System.Drawing.Size(120, 22);
            this.ProdutosBuscar.Text = "Buscar";
            this.ProdutosBuscar.Click += new System.EventHandler(this.ProdutosBuscar_Click);
            // 
            // teste2ToolStripMenuItem
            // 
            this.teste2ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PedidosNovo,
            this.PedidosBuscar});
            this.teste2ToolStripMenuItem.Name = "teste2ToolStripMenuItem";
            this.teste2ToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.teste2ToolStripMenuItem.Text = "Pedidos";
            // 
            // PedidosNovo
            // 
            this.PedidosNovo.Name = "PedidosNovo";
            this.PedidosNovo.Size = new System.Drawing.Size(120, 22);
            this.PedidosNovo.Text = "Novo";
            // 
            // PedidosBuscar
            // 
            this.PedidosBuscar.Name = "PedidosBuscar";
            this.PedidosBuscar.Size = new System.Drawing.Size(120, 22);
            this.PedidosBuscar.Text = "Buscar";
            // 
            // Sair
            // 
            this.Sair.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Sair.Name = "Sair";
            this.Sair.Size = new System.Drawing.Size(45, 20);
            this.Sair.Text = "Sair";
            this.Sair.Click += new System.EventHandler(this.Sair_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // PanelBotoes
            // 
            this.PanelBotoes.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PanelBotoes.Controls.Add(this.BtFornecedores);
            this.PanelBotoes.Controls.Add(this.LbLogado);
            this.PanelBotoes.Controls.Add(this.label1);
            this.PanelBotoes.Location = new System.Drawing.Point(0, 25);
            this.PanelBotoes.Name = "PanelBotoes";
            this.PanelBotoes.Size = new System.Drawing.Size(805, 38);
            this.PanelBotoes.TabIndex = 2;
            // 
            // BtFornecedores
            // 
            this.BtFornecedores.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtFornecedores.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtFornecedores.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtFornecedores.Location = new System.Drawing.Point(12, 4);
            this.BtFornecedores.Name = "BtFornecedores";
            this.BtFornecedores.Size = new System.Drawing.Size(155, 29);
            this.BtFornecedores.TabIndex = 2;
            this.BtFornecedores.Text = "Meus Fornecedores";
            this.BtFornecedores.UseVisualStyleBackColor = false;
            // 
            // LbLogado
            // 
            this.LbLogado.AutoSize = true;
            this.LbLogado.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LbLogado.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbLogado.Location = new System.Drawing.Point(620, 14);
            this.LbLogado.Name = "LbLogado";
            this.LbLogado.Size = new System.Drawing.Size(0, 16);
            this.LbLogado.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(555, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Logado: ";
            // 
            // PanelPrincipal
            // 
            this.PanelPrincipal.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PanelPrincipal.Location = new System.Drawing.Point(12, 78);
            this.PanelPrincipal.Name = "PanelPrincipal";
            this.PanelPrincipal.Size = new System.Drawing.Size(781, 267);
            this.PanelPrincipal.TabIndex = 3;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 357);
            this.Controls.Add(this.PanelPrincipal);
            this.Controls.Add(this.PanelBotoes);
            this.Controls.Add(this.Menu);
            this.MainMenuStrip = this.Menu;
            this.Name = "Principal";
            this.Text = "Principal";
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.PanelBotoes.ResumeLayout(false);
            this.PanelBotoes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem testeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teste2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PedidosNovo;
        private System.Windows.Forms.ToolStripMenuItem UsuariosNovo;
        private System.Windows.Forms.ToolStripMenuItem UsuariosBuscar;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProdutosNovo;
        private System.Windows.Forms.ToolStripMenuItem ProdutosBuscar;
        private System.Windows.Forms.ToolStripMenuItem PedidosBuscar;
        private System.Windows.Forms.ToolStripMenuItem Sair;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel PanelBotoes;
        private System.Windows.Forms.Panel PanelPrincipal;
        private System.Windows.Forms.Label LbLogado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtFornecedores;
    }
}