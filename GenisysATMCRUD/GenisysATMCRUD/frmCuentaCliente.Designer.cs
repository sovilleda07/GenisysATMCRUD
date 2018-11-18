namespace GenisysATMCRUD
{
    partial class frmCuentaCliente
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
            this.gbServicioCliente = new System.Windows.Forms.GroupBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lsCuenta = new System.Windows.Forms.ListBox();
            this.lblCuentaCliente = new System.Windows.Forms.Label();
            this.gbListas = new System.Windows.Forms.GroupBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.panelBotones = new System.Windows.Forms.Panel();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.gbCliente = new System.Windows.Forms.GroupBox();
            this.txtPin = new System.Windows.Forms.TextBox();
            this.lblPin = new System.Windows.Forms.Label();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lstClientes = new System.Windows.Forms.ListBox();
            this.gbServicioCliente.SuspendLayout();
            this.gbListas.SuspendLayout();
            this.panelBotones.SuspendLayout();
            this.gbCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbServicioCliente
            // 
            this.gbServicioCliente.Controls.Add(this.lblTitulo);
            this.gbServicioCliente.Controls.Add(this.lsCuenta);
            this.gbServicioCliente.Location = new System.Drawing.Point(634, 84);
            this.gbServicioCliente.Name = "gbServicioCliente";
            this.gbServicioCliente.Size = new System.Drawing.Size(251, 385);
            this.gbServicioCliente.TabIndex = 9;
            this.gbServicioCliente.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(40, 16);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(170, 23);
            this.lblTitulo.TabIndex = 11;
            this.lblTitulo.Text = "Cuentas del Cliente";
            // 
            // lsCuenta
            // 
            this.lsCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsCuenta.FormattingEnabled = true;
            this.lsCuenta.ItemHeight = 24;
            this.lsCuenta.Location = new System.Drawing.Point(6, 43);
            this.lsCuenta.Name = "lsCuenta";
            this.lsCuenta.Size = new System.Drawing.Size(239, 316);
            this.lsCuenta.TabIndex = 10;
            this.lsCuenta.TabStop = false;
            this.lsCuenta.UseTabStops = false;
            this.lsCuenta.Click += new System.EventHandler(this.lsCuenta_Click);
            // 
            // lblCuentaCliente
            // 
            this.lblCuentaCliente.AutoSize = true;
            this.lblCuentaCliente.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuentaCliente.Location = new System.Drawing.Point(260, 30);
            this.lblCuentaCliente.Name = "lblCuentaCliente";
            this.lblCuentaCliente.Size = new System.Drawing.Size(341, 33);
            this.lblCuentaCliente.TabIndex = 8;
            this.lblCuentaCliente.Text = "MÓDULO CUENTA CLIENTE";
            // 
            // gbListas
            // 
            this.gbListas.Controls.Add(this.lblCliente);
            this.gbListas.Controls.Add(this.panelBotones);
            this.gbListas.Controls.Add(this.gbCliente);
            this.gbListas.Controls.Add(this.lstClientes);
            this.gbListas.Location = new System.Drawing.Point(16, 84);
            this.gbListas.Name = "gbListas";
            this.gbListas.Size = new System.Drawing.Size(612, 386);
            this.gbListas.TabIndex = 7;
            this.gbListas.TabStop = false;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(79, 16);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(66, 23);
            this.lblCliente.TabIndex = 5;
            this.lblCliente.Text = "Cliente";
            // 
            // panelBotones
            // 
            this.panelBotones.Controls.Add(this.btnAgregar);
            this.panelBotones.Controls.Add(this.btnLimpiar);
            this.panelBotones.Controls.Add(this.btnActualizar);
            this.panelBotones.Controls.Add(this.btnEliminar);
            this.panelBotones.Location = new System.Drawing.Point(83, 286);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new System.Drawing.Size(424, 74);
            this.panelBotones.TabIndex = 21;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(13, 25);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(87, 32);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(322, 25);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(87, 32);
            this.btnLimpiar.TabIndex = 10;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(116, 25);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(87, 32);
            this.btnActualizar.TabIndex = 8;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(219, 25);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(87, 32);
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // gbCliente
            // 
            this.gbCliente.Controls.Add(this.txtPin);
            this.gbCliente.Controls.Add(this.lblPin);
            this.gbCliente.Controls.Add(this.txtSaldo);
            this.gbCliente.Controls.Add(this.lblSaldo);
            this.gbCliente.Controls.Add(this.txtNumero);
            this.gbCliente.Controls.Add(this.lblNumero);
            this.gbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCliente.Location = new System.Drawing.Point(267, 42);
            this.gbCliente.Name = "gbCliente";
            this.gbCliente.Size = new System.Drawing.Size(334, 220);
            this.gbCliente.TabIndex = 19;
            this.gbCliente.TabStop = false;
            this.gbCliente.Text = "Información";
            // 
            // txtPin
            // 
            this.txtPin.Location = new System.Drawing.Point(118, 167);
            this.txtPin.Name = "txtPin";
            this.txtPin.Size = new System.Drawing.Size(189, 26);
            this.txtPin.TabIndex = 14;
            // 
            // lblPin
            // 
            this.lblPin.AutoSize = true;
            this.lblPin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPin.Location = new System.Drawing.Point(9, 170);
            this.lblPin.Name = "lblPin";
            this.lblPin.Size = new System.Drawing.Size(34, 20);
            this.lblPin.TabIndex = 15;
            this.lblPin.Text = "Pin";
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(118, 109);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(189, 26);
            this.txtSaldo.TabIndex = 12;
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.Location = new System.Drawing.Point(9, 112);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(55, 20);
            this.lblSaldo.TabIndex = 13;
            this.lblSaldo.Text = "Saldo";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(118, 54);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(189, 26);
            this.txtNumero.TabIndex = 1;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(9, 54);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(71, 20);
            this.lblNumero.TabIndex = 11;
            this.lblNumero.Text = "Numero";
            // 
            // lstClientes
            // 
            this.lstClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstClientes.FormattingEnabled = true;
            this.lstClientes.ItemHeight = 24;
            this.lstClientes.Location = new System.Drawing.Point(6, 45);
            this.lstClientes.Name = "lstClientes";
            this.lstClientes.Size = new System.Drawing.Size(244, 220);
            this.lstClientes.TabIndex = 10;
            this.lstClientes.TabStop = false;
            this.lstClientes.UseTabStops = false;
            this.lstClientes.Click += new System.EventHandler(this.lstClientes_Click);
            // 
            // frmCuentaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 505);
            this.Controls.Add(this.gbServicioCliente);
            this.Controls.Add(this.lblCuentaCliente);
            this.Controls.Add(this.gbListas);
            this.Name = "frmCuentaCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GenisysATM";
            this.Load += new System.EventHandler(this.frmCuentaCliente_Load);
            this.gbServicioCliente.ResumeLayout(false);
            this.gbServicioCliente.PerformLayout();
            this.gbListas.ResumeLayout(false);
            this.gbListas.PerformLayout();
            this.panelBotones.ResumeLayout(false);
            this.gbCliente.ResumeLayout(false);
            this.gbCliente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbServicioCliente;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ListBox lsCuenta;
        private System.Windows.Forms.Label lblCuentaCliente;
        private System.Windows.Forms.GroupBox gbListas;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Panel panelBotones;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.GroupBox gbCliente;
        private System.Windows.Forms.TextBox txtPin;
        private System.Windows.Forms.Label lblPin;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.ListBox lstClientes;
    }
}