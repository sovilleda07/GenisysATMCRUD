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
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(210, 19);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(497, 37);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "BIENVENIDO A GENISYS ATM";
            // 
            // btnClientes
            // 
            this.btnClientes.Location = new System.Drawing.Point(34, 130);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(75, 23);
            this.btnClientes.TabIndex = 1;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnServiciosPublicos
            // 
            this.btnServiciosPublicos.Location = new System.Drawing.Point(132, 130);
            this.btnServiciosPublicos.Name = "btnServiciosPublicos";
            this.btnServiciosPublicos.Size = new System.Drawing.Size(113, 23);
            this.btnServiciosPublicos.TabIndex = 2;
            this.btnServiciosPublicos.Text = "Servicios Publicos";
            this.btnServiciosPublicos.UseVisualStyleBackColor = true;
            this.btnServiciosPublicos.Click += new System.EventHandler(this.btnServiciosPublicos_Click);
            // 
            // btnConfiguración
            // 
            this.btnConfiguración.Location = new System.Drawing.Point(626, 130);
            this.btnConfiguración.Name = "btnConfiguración";
            this.btnConfiguración.Size = new System.Drawing.Size(81, 23);
            this.btnConfiguración.TabIndex = 3;
            this.btnConfiguración.Text = "Configuración";
            this.btnConfiguración.UseVisualStyleBackColor = true;
            this.btnConfiguración.Click += new System.EventHandler(this.btnConfiguración_Click);
            // 
            // btnServicioCliente
            // 
            this.btnServicioCliente.Location = new System.Drawing.Point(272, 130);
            this.btnServicioCliente.Name = "btnServicioCliente";
            this.btnServicioCliente.Size = new System.Drawing.Size(113, 23);
            this.btnServicioCliente.TabIndex = 4;
            this.btnServicioCliente.Text = "Servicios Cliente";
            this.btnServicioCliente.UseVisualStyleBackColor = true;
            this.btnServicioCliente.Click += new System.EventHandler(this.btnServicioCliente_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}