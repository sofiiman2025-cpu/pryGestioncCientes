namespace pryGestioncCientes
{
    partial class frmListadodeClientes
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
            this.grpConsulta = new System.Windows.Forms.GroupBox();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Limite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deuda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblDeuda = new System.Windows.Forms.Label();
            this.lblCantCli = new System.Windows.Forms.Label();
            this.lblPromDeu = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblQclientes = new System.Windows.Forms.Label();
            this.lblProm = new System.Windows.Forms.Label();
            this.btnListar = new System.Windows.Forms.Button();
            this.grpConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // grpConsulta
            // 
            this.grpConsulta.Controls.Add(this.btnListar);
            this.grpConsulta.Controls.Add(this.lblProm);
            this.grpConsulta.Controls.Add(this.lblQclientes);
            this.grpConsulta.Controls.Add(this.lblTotal);
            this.grpConsulta.Controls.Add(this.lblPromDeu);
            this.grpConsulta.Controls.Add(this.lblCantCli);
            this.grpConsulta.Controls.Add(this.lblDeuda);
            this.grpConsulta.Controls.Add(this.dgvDatos);
            this.grpConsulta.Location = new System.Drawing.Point(19, 12);
            this.grpConsulta.Name = "grpConsulta";
            this.grpConsulta.Size = new System.Drawing.Size(482, 425);
            this.grpConsulta.TabIndex = 0;
            this.grpConsulta.TabStop = false;
            this.grpConsulta.Text = "Consulta de datos";
            this.grpConsulta.Enter += new System.EventHandler(this.grpConsulta_Enter);
            // 
            // dgvDatos
            // 
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Limite,
            this.Deuda});
            this.dgvDatos.Location = new System.Drawing.Point(20, 28);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.Size = new System.Drawing.Size(444, 238);
            this.dgvDatos.TabIndex = 0;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre y apellido";
            this.Nombre.Name = "Nombre";
            // 
            // Limite
            // 
            this.Limite.HeaderText = "Limite de crédito";
            this.Limite.Name = "Limite";
            // 
            // Deuda
            // 
            this.Deuda.HeaderText = "Deuda";
            this.Deuda.Name = "Deuda";
            // 
            // lblDeuda
            // 
            this.lblDeuda.AutoSize = true;
            this.lblDeuda.Location = new System.Drawing.Point(276, 303);
            this.lblDeuda.Name = "lblDeuda";
            this.lblDeuda.Size = new System.Drawing.Size(79, 13);
            this.lblDeuda.TabIndex = 1;
            this.lblDeuda.Text = "Total de deuda";
            // 
            // lblCantCli
            // 
            this.lblCantCli.AutoSize = true;
            this.lblCantCli.Location = new System.Drawing.Point(272, 330);
            this.lblCantCli.Name = "lblCantCli";
            this.lblCantCli.Size = new System.Drawing.Size(103, 13);
            this.lblCantCli.TabIndex = 2;
            this.lblCantCli.Text = "Cantidad de clientes";
            // 
            // lblPromDeu
            // 
            this.lblPromDeu.AutoSize = true;
            this.lblPromDeu.Location = new System.Drawing.Point(276, 357);
            this.lblPromDeu.Name = "lblPromDeu";
            this.lblPromDeu.Size = new System.Drawing.Size(99, 13);
            this.lblPromDeu.TabIndex = 3;
            this.lblPromDeu.Text = "Promedio de deuda";
            this.lblPromDeu.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotal.Location = new System.Drawing.Point(382, 303);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(67, 13);
            this.lblTotal.TabIndex = 4;
            // 
            // lblQclientes
            // 
            this.lblQclientes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblQclientes.Location = new System.Drawing.Point(382, 330);
            this.lblQclientes.Name = "lblQclientes";
            this.lblQclientes.Size = new System.Drawing.Size(67, 13);
            this.lblQclientes.TabIndex = 5;
            // 
            // lblProm
            // 
            this.lblProm.BackColor = System.Drawing.SystemColors.Control;
            this.lblProm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblProm.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblProm.Location = new System.Drawing.Point(382, 357);
            this.lblProm.Name = "lblProm";
            this.lblProm.Size = new System.Drawing.Size(67, 13);
            this.lblProm.TabIndex = 6;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(362, 392);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(102, 27);
            this.btnListar.TabIndex = 7;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // frmListadodeClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 457);
            this.Controls.Add(this.grpConsulta);
            this.Name = "frmListadodeClientes";
            this.Text = "Listado de Clientes";
            this.Load += new System.EventHandler(this.frmListadodeClientes_Load);
            this.grpConsulta.ResumeLayout(false);
            this.grpConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpConsulta;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Limite;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deuda;
        private System.Windows.Forms.Label lblProm;
        private System.Windows.Forms.Label lblQclientes;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblPromDeu;
        private System.Windows.Forms.Label lblCantCli;
        private System.Windows.Forms.Label lblDeuda;
        private System.Windows.Forms.Button btnListar;
    }
}