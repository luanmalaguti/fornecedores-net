namespace Desktop.Forms.Template
{
    partial class BasicConsulta
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
            this.PanelBusca = new System.Windows.Forms.Panel();
            this.TbBuscar = new System.Windows.Forms.TextBox();
            this.BtBuscar = new System.Windows.Forms.Button();
            this.PanelBusca.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelBusca
            // 
            this.PanelBusca.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.PanelBusca.Controls.Add(this.BtBuscar);
            this.PanelBusca.Controls.Add(this.TbBuscar);
            this.PanelBusca.Location = new System.Drawing.Point(-3, 0);
            this.PanelBusca.Name = "PanelBusca";
            this.PanelBusca.Size = new System.Drawing.Size(577, 36);
            this.PanelBusca.TabIndex = 0;
            // 
            // TbBuscar
            // 
            this.TbBuscar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbBuscar.Location = new System.Drawing.Point(19, 7);
            this.TbBuscar.Name = "TbBuscar";
            this.TbBuscar.Size = new System.Drawing.Size(414, 23);
            this.TbBuscar.TabIndex = 0;
            // 
            // BtBuscar
            // 
            this.BtBuscar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtBuscar.Location = new System.Drawing.Point(448, 5);
            this.BtBuscar.Name = "BtBuscar";
            this.BtBuscar.Size = new System.Drawing.Size(107, 28);
            this.BtBuscar.TabIndex = 1;
            this.BtBuscar.Text = "Buscar";
            this.BtBuscar.UseVisualStyleBackColor = true;
            // 
            // BasicConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 262);
            this.Controls.Add(this.PanelBusca);
            this.Name = "BasicConsulta";
            this.Text = "BasicConsulta";
            this.PanelBusca.ResumeLayout(false);
            this.PanelBusca.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel PanelBusca;
        public System.Windows.Forms.Button BtBuscar;
        public System.Windows.Forms.TextBox TbBuscar;
    }
}