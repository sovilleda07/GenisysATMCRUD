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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnServiciosPublicos = new System.Windows.Forms.Button();
            this.btnConfiguración = new System.Windows.Forms.Button();
            this.btnServicioCliente = new System.Windows.Forms.Button();
            this.btnTarjeta = new System.Windows.Forms.Button();
            this.btnCuentaCliente = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnInformacion = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Constantia", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(116, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(508, 42);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "BIENVENIDO A GENISYS ATM";
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Image = global::GenisysATMCRUD.Properties.Resources.cliente;
            this.btnClientes.Location = new System.Drawing.Point(67, 211);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(131, 71);
            this.btnClientes.TabIndex = 1;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnServiciosPublicos
            // 
            this.btnServiciosPublicos.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnServiciosPublicos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServiciosPublicos.Image = global::GenisysATMCRUD.Properties.Resources.water;
            this.btnServiciosPublicos.Location = new System.Drawing.Point(300, 211);
            this.btnServiciosPublicos.Name = "btnServiciosPublicos";
            this.btnServiciosPublicos.Size = new System.Drawing.Size(131, 71);
            this.btnServiciosPublicos.TabIndex = 2;
            this.btnServiciosPublicos.Text = "Servicios Publicos";
            this.btnServiciosPublicos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnServiciosPublicos.UseVisualStyleBackColor = false;
            this.btnServiciosPublicos.Click += new System.EventHandler(this.btnServiciosPublicos_Click);
            // 
            // btnConfiguración
            // 
            this.btnConfiguración.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConfiguración.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfiguración.Image = global::GenisysATMCRUD.Properties.Resources.confi;
            this.btnConfiguración.Location = new System.Drawing.Point(533, 350);
            this.btnConfiguración.Name = "btnConfiguración";
            this.btnConfiguración.Size = new System.Drawing.Size(131, 71);
            this.btnConfiguración.TabIndex = 6;
            this.btnConfiguración.Text = "Configuración";
            this.btnConfiguración.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnConfiguración.UseVisualStyleBackColor = false;
            this.btnConfiguración.Click += new System.EventHandler(this.btnConfiguración_Click);
            // 
            // btnServicioCliente
            // 
            this.btnServicioCliente.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnServicioCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServicioCliente.Image = global::GenisysATMCRUD.Properties.Resources.servicio;
            this.btnServicioCliente.Location = new System.Drawing.Point(300, 350);
            this.btnServicioCliente.Name = "btnServicioCliente";
            this.btnServicioCliente.Size = new System.Drawing.Size(131, 71);
            this.btnServicioCliente.TabIndex = 3;
            this.btnServicioCliente.Text = "Servicios Cliente";
            this.btnServicioCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnServicioCliente.UseVisualStyleBackColor = false;
            this.btnServicioCliente.Click += new System.EventHandler(this.btnServicioCliente_Click);
            // 
            // btnTarjeta
            // 
            this.btnTarjeta.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTarjeta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTarjeta.Image = global::GenisysATMCRUD.Properties.Resources.visa64;
            this.btnTarjeta.Location = new System.Drawing.Point(533, 211);
            this.btnTarjeta.Name = "btnTarjeta";
            this.btnTarjeta.Size = new System.Drawing.Size(131, 71);
            this.btnTarjeta.TabIndex = 4;
            this.btnTarjeta.Text = "Tarjeta Crédito";
            this.btnTarjeta.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnTarjeta.UseVisualStyleBackColor = false;
            this.btnTarjeta.Click += new System.EventHandler(this.btnTarjeta_Click);
            // 
            // btnCuentaCliente
            // 
            this.btnCuentaCliente.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCuentaCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCuentaCliente.Image = global::GenisysATMCRUD.Properties.Resources.cuenta;
            this.btnCuentaCliente.Location = new System.Drawing.Point(67, 350);
            this.btnCuentaCliente.Name = "btnCuentaCliente";
            this.btnCuentaCliente.Size = new System.Drawing.Size(131, 71);
            this.btnCuentaCliente.TabIndex = 5;
            this.btnCuentaCliente.Text = "Cuenta Cliente";
            this.btnCuentaCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCuentaCliente.UseVisualStyleBackColor = false;
            this.btnCuentaCliente.Click += new System.EventHandler(this.btnCuentaCliente_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::GenisysATMCRUD.Properties.Resources.atm3;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(300, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 116);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btnInformacion
            // 
            this.btnInformacion.BackColor = System.Drawing.Color.Transparent;
            this.btnInformacion.BackgroundImage = global::GenisysATMCRUD.Properties.Resources.info;
            this.btnInformacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInformacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInformacion.Location = new System.Drawing.Point(702, 9);
            this.btnInformacion.Name = "btnInformacion";
            this.btnInformacion.Size = new System.Drawing.Size(35, 35);
            this.btnInformacion.TabIndex = 9;
            this.btnInformacion.UseVisualStyleBackColor = false;
            this.btnInformacion.Click += new System.EventHandler(this.btnInformacion_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.BackgroundImage = global::GenisysATMCRUD.Properties.Resources.delete_icon;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Location = new System.Drawing.Point(702, 451);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(35, 35);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GenisysATMCRUD.Properties.Resources.app_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(739, 487);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnInformacion);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCuentaCliente);
            this.Controls.Add(this.btnTarjeta);
            this.Controls.Add(this.btnServicioCliente);
            this.Controls.Add(this.btnConfiguración);
            this.Controls.Add(this.btnServiciosPublicos);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.lblTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GenisysATM";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnInformacion;
        private System.Windows.Forms.Button btnSalir;
    }
}