namespace GenisysATMCRUD
{
    partial class frmTarjetaCredito
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTarjetaCredito));
            this.gbListas = new System.Windows.Forms.GroupBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.panelBotones = new System.Windows.Forms.Panel();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.gbCliente = new System.Windows.Forms.GroupBox();
            this.txtLimite = new System.Windows.Forms.TextBox();
            this.lblLimite = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.lblMonto = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lstClientes = new System.Windows.Forms.ListBox();
            this.lblTarjetaCredito = new System.Windows.Forms.Label();
            this.gbServicioCliente = new System.Windows.Forms.GroupBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lstTarjeta = new System.Windows.Forms.ListBox();
            this.gbListas.SuspendLayout();
            this.panelBotones.SuspendLayout();
            this.gbCliente.SuspendLayout();
            this.gbServicioCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbListas
            // 
            this.gbListas.BackColor = System.Drawing.Color.Transparent;
            this.gbListas.Controls.Add(this.lblCliente);
            this.gbListas.Controls.Add(this.panelBotones);
            this.gbListas.Controls.Add(this.gbCliente);
            this.gbListas.Controls.Add(this.lstClientes);
            this.gbListas.Location = new System.Drawing.Point(12, 72);
            this.gbListas.Name = "gbListas";
            this.gbListas.Size = new System.Drawing.Size(612, 386);
            this.gbListas.TabIndex = 4;
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
            this.panelBotones.Location = new System.Drawing.Point(57, 286);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new System.Drawing.Size(489, 74);
            this.panelBotones.TabIndex = 21;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Gold;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(15, 25);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(87, 32);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Gold;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(381, 25);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(87, 32);
            this.btnLimpiar.TabIndex = 10;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.Gold;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(137, 25);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(87, 32);
            this.btnActualizar.TabIndex = 8;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Gold;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(259, 25);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(87, 32);
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // gbCliente
            // 
            this.gbCliente.Controls.Add(this.txtLimite);
            this.gbCliente.Controls.Add(this.lblLimite);
            this.gbCliente.Controls.Add(this.txtMonto);
            this.gbCliente.Controls.Add(this.lblMonto);
            this.gbCliente.Controls.Add(this.txtDescripcion);
            this.gbCliente.Controls.Add(this.lblDescripcion);
            this.gbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCliente.Location = new System.Drawing.Point(267, 42);
            this.gbCliente.Name = "gbCliente";
            this.gbCliente.Size = new System.Drawing.Size(334, 220);
            this.gbCliente.TabIndex = 19;
            this.gbCliente.TabStop = false;
            this.gbCliente.Text = "Información";
            // 
            // txtLimite
            // 
            this.txtLimite.Location = new System.Drawing.Point(118, 167);
            this.txtLimite.Name = "txtLimite";
            this.txtLimite.Size = new System.Drawing.Size(189, 26);
            this.txtLimite.TabIndex = 14;
            // 
            // lblLimite
            // 
            this.lblLimite.AutoSize = true;
            this.lblLimite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLimite.Location = new System.Drawing.Point(9, 170);
            this.lblLimite.Name = "lblLimite";
            this.lblLimite.Size = new System.Drawing.Size(57, 20);
            this.lblLimite.TabIndex = 15;
            this.lblLimite.Text = "Limite";
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(118, 109);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(189, 26);
            this.txtMonto.TabIndex = 12;
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonto.Location = new System.Drawing.Point(9, 112);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(59, 20);
            this.lblMonto.TabIndex = 13;
            this.lblMonto.Text = "Monto";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(118, 54);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(189, 26);
            this.txtDescripcion.TabIndex = 1;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(9, 54);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(103, 20);
            this.lblDescripcion.TabIndex = 11;
            this.lblDescripcion.Text = "Descripcion";
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
            // lblTarjetaCredito
            // 
            this.lblTarjetaCredito.AutoSize = true;
            this.lblTarjetaCredito.BackColor = System.Drawing.Color.Transparent;
            this.lblTarjetaCredito.Font = new System.Drawing.Font("Constantia", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTarjetaCredito.Location = new System.Drawing.Point(216, 21);
            this.lblTarjetaCredito.Name = "lblTarjetaCredito";
            this.lblTarjetaCredito.Size = new System.Drawing.Size(504, 42);
            this.lblTarjetaCredito.TabIndex = 5;
            this.lblTarjetaCredito.Text = "MÓDULO TARJETA CRÉDITO";
            // 
            // gbServicioCliente
            // 
            this.gbServicioCliente.BackColor = System.Drawing.Color.Transparent;
            this.gbServicioCliente.Controls.Add(this.lblTitulo);
            this.gbServicioCliente.Controls.Add(this.lstTarjeta);
            this.gbServicioCliente.Location = new System.Drawing.Point(630, 72);
            this.gbServicioCliente.Name = "gbServicioCliente";
            this.gbServicioCliente.Size = new System.Drawing.Size(251, 385);
            this.gbServicioCliente.TabIndex = 6;
            this.gbServicioCliente.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(6, 17);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(170, 23);
            this.lblTitulo.TabIndex = 11;
            this.lblTitulo.Text = "Tarjetas del Cliente";
            // 
            // lstTarjeta
            // 
            this.lstTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstTarjeta.FormattingEnabled = true;
            this.lstTarjeta.ItemHeight = 24;
            this.lstTarjeta.Location = new System.Drawing.Point(6, 43);
            this.lstTarjeta.Name = "lstTarjeta";
            this.lstTarjeta.Size = new System.Drawing.Size(239, 340);
            this.lstTarjeta.TabIndex = 10;
            this.lstTarjeta.TabStop = false;
            this.lstTarjeta.UseTabStops = false;
            this.lstTarjeta.Click += new System.EventHandler(this.lstTarjeta_Click);
            // 
            // frmTarjetaCredito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GenisysATMCRUD.Properties.Resources.app_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(889, 465);
            this.Controls.Add(this.gbServicioCliente);
            this.Controls.Add(this.lblTarjetaCredito);
            this.Controls.Add(this.gbListas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTarjetaCredito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GenisysATM";
            this.Load += new System.EventHandler(this.frmTarjetaCredito_Load);
            this.gbListas.ResumeLayout(false);
            this.gbListas.PerformLayout();
            this.panelBotones.ResumeLayout(false);
            this.gbCliente.ResumeLayout(false);
            this.gbCliente.PerformLayout();
            this.gbServicioCliente.ResumeLayout(false);
            this.gbServicioCliente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbListas;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Panel panelBotones;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.GroupBox gbCliente;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.ListBox lstClientes;
        private System.Windows.Forms.TextBox txtLimite;
        private System.Windows.Forms.Label lblLimite;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Label lblTarjetaCredito;
        private System.Windows.Forms.GroupBox gbServicioCliente;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ListBox lstTarjeta;
    }
}