namespace GenisysATMCRUD
{
    partial class frmMenu
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnServiciosPublicos = new System.Windows.Forms.Button();
            this.btnConfiguración = new System.Windows.Forms.Button();
            this.btnServicioCliente = new System.Windows.Forms.Button();
            this.btnTarjeta = new System.Windows.Forms.Button();
            this.btnCuentaCliente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Constantia", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(147, 13);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(471, 39);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "BIENVENIDO A GENISYS ATM";
            // 
            // btnClientes
            // 
            this.btnClientes.Location = new System.Drawing.Point(87, 248);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(129, 83);
            this.btnClientes.TabIndex = 1;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnServiciosPublicos
            // 
            this.btnServiciosPublicos.Location = new System.Drawing.Point(322, 248);
            this.btnServiciosPublicos.Name = "btnServiciosPublicos";
            this.btnServiciosPublicos.Size = new System.Drawing.Size(129, 83);
            this.btnServiciosPublicos.TabIndex = 2;
            this.btnServiciosPublicos.Text = "Servicios Publicos";
            this.btnServiciosPublicos.UseVisualStyleBackColor = true;
            this.btnServiciosPublicos.Click += new System.EventHandler(this.btnServiciosPublicos_Click);
            // 
            // btnConfiguración
            // 
            this.btnConfiguración.Location = new System.Drawing.Point(557, 389);
            this.btnConfiguración.Name = "btnConfiguración";
            this.btnConfiguración.Size = new System.Drawing.Size(129, 83);
            this.btnConfiguración.TabIndex = 6;
            this.btnConfiguración.Text = "Configuración";
            this.btnConfiguración.UseVisualStyleBackColor = true;
            this.btnConfiguración.Click += new System.EventHandler(this.btnConfiguración_Click);
            // 
            // btnServicioCliente
            // 
            this.btnServicioCliente.Location = new System.Drawing.Point(322, 389);
            this.btnServicioCliente.Name = "btnServicioCliente";
            this.btnServicioCliente.Size = new System.Drawing.Size(129, 83);
            this.btnServicioCliente.TabIndex = 3;
            this.btnServicioCliente.Text = "Servicios Cliente";
            this.btnServicioCliente.UseVisualStyleBackColor = true;
            this.btnServicioCliente.Click += new System.EventHandler(this.btnServicioCliente_Click);
            // 
            // btnTarjeta
            // 
            this.btnTarjeta.Location = new System.Drawing.Point(557, 248);
            this.btnTarjeta.Name = "btnTarjeta";
            this.btnTarjeta.Size = new System.Drawing.Size(129, 83);
            this.btnTarjeta.TabIndex = 4;
            this.btnTarjeta.Text = "Tarjeta Crédito";
            this.btnTarjeta.UseVisualStyleBackColor = true;
            this.btnTarjeta.Click += new System.EventHandler(this.btnTarjeta_Click);
            // 
            // btnCuentaCliente
            // 
            this.btnCuentaCliente.Location = new System.Drawing.Point(87, 389);
            this.btnCuentaCliente.Name = "btnCuentaCliente";
            this.btnCuentaCliente.Size = new System.Drawing.Size(129, 83);
            this.btnCuentaCliente.TabIndex = 5;
            this.btnCuentaCliente.Text = "Cuenta Cliente";
            this.btnCuentaCliente.UseVisualStyleBackColor = true;
            this.btnCuentaCliente.Click += new System.EventHandler(this.btnCuentaCliente_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(780, 485);
            this.Controls.Add(this.btnCuentaCliente);
            this.Controls.Add(this.btnTarjeta);
            this.Controls.Add(this.btnServicioCliente);
            this.Controls.Add(this.btnConfiguración);
            this.Controls.Add(this.btnServiciosPublicos);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GenisysATM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnServiciosPublicos;
        private System.Windows.Forms.Button btnConfiguración;
        private System.Windows.Forms.Button btnServicioCliente;
        private System.Windows.Forms.Button btnTarjeta;
        private System.Windows.Forms.Button btnCuentaCliente;
    }
}