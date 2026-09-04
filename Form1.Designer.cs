namespace pryGestioncCientes
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.agregarNuevoClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lIstadoDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesDeudoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesOrdenadosPorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarNuevoClienteToolStripMenuItem,
            this.lIstadoDeClientesToolStripMenuItem,
            this.clientesDeudoresToolStripMenuItem,
            this.clientesOrdenadosPorToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // vendedoresToolStripMenuItem
            // 
            this.vendedoresToolStripMenuItem.Name = "vendedoresToolStripMenuItem";
            this.vendedoresToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.vendedoresToolStripMenuItem.Text = "Vendedores";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemaToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.vendedoresToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(552, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // agregarNuevoClienteToolStripMenuItem
            // 
            this.agregarNuevoClienteToolStripMenuItem.Name = "agregarNuevoClienteToolStripMenuItem";
            this.agregarNuevoClienteToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.agregarNuevoClienteToolStripMenuItem.Text = "Agregar nuevo cliente";
            this.agregarNuevoClienteToolStripMenuItem.Click += new System.EventHandler(this.agregarNuevoClienteToolStripMenuItem_Click);
            // 
            // lIstadoDeClientesToolStripMenuItem
            // 
            this.lIstadoDeClientesToolStripMenuItem.Name = "lIstadoDeClientesToolStripMenuItem";
            this.lIstadoDeClientesToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.lIstadoDeClientesToolStripMenuItem.Text = "Listado de clientes";
            this.lIstadoDeClientesToolStripMenuItem.Click += new System.EventHandler(this.lIstadoDeClientesToolStripMenuItem_Click);
            // 
            // clientesDeudoresToolStripMenuItem
            // 
            this.clientesDeudoresToolStripMenuItem.Name = "clientesDeudoresToolStripMenuItem";
            this.clientesDeudoresToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.clientesDeudoresToolStripMenuItem.Text = "Clientes deudores";
            // 
            // clientesOrdenadosPorToolStripMenuItem
            // 
            this.clientesOrdenadosPorToolStripMenuItem.Name = "clientesOrdenadosPorToolStripMenuItem";
            this.clientesOrdenadosPorToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.clientesOrdenadosPorToolStripMenuItem.Text = "Clientes ordenados por";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(552, 465);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Gestión de clientes (Archivo CSV)";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendedoresToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem agregarNuevoClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lIstadoDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesDeudoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesOrdenadosPorToolStripMenuItem;
    }
}

