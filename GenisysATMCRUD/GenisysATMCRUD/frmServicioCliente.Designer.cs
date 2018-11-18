namespace GenisysATMCRUD
{
    partial class frmServicioCliente
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
            this.lblServicioC = new System.Windows.Forms.Label();
            this.gbListas = new System.Windows.Forms.GroupBox();
            this.lblServicio = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.panelBotones = new System.Windows.Forms.Panel();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.gbCliente = new System.Windows.Forms.GroupBox();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lstClientes = new System.Windows.Forms.ListBox();
            this.lstServicioP = new System.Windows.Forms.ListBox();
            this.gbServicioCliente = new System.Windows.Forms.GroupBox();
            this.lstServicioCliente = new System.Windows.Forms.ListBox();
            this.gbListas.SuspendLayout();
            this.panelBotones.SuspendLayout();
            this.gbCliente.SuspendLayout();
            this.gbServicioCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblServicioC
            // 
            this.lblServicioC.AutoSize = true;
            this.lblServicioC.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServicioC.Location = new System.Drawing.Point(199, 9);
            this.lblServicioC.Name = "lblServicioC";
            this.lblServicioC.Size = new System.Drawing.Size(360, 33);
            this.lblServicioC.TabIndex = 2;
            this.lblServicioC.Text = "MÓDULO SERVICIO CLIENTE";
            // 
            // gbListas
            // 
            this.gbListas.Controls.Add(this.lblServicio);
            this.gbListas.Controls.Add(this.lblCliente);
            this.gbListas.Controls.Add(this.panelBotones);
            this.gbListas.Controls.Add(this.gbCliente);
            this.gbListas.Controls.Add(this.lstClientes);
            this.gbListas.Controls.Add(this.lstServicioP);
            this.gbListas.Location = new System.Drawing.Point(13, 45);
            this.gbListas.Name = "gbListas";
            this.gbListas.Size = new System.Drawing.Size(586, 440);
            this.gbListas.TabIndex = 3;
            this.gbListas.TabStop = false;
            // 
            // lblServicio
            // 
            this.lblServicio.AutoSize = true;
            this.lblServicio.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServicio.Location = new System.Drawing.Point(391, 9);
            this.lblServicio.Name = "lblServicio";
            this.lblServicio.Size = new System.Drawing.Size(74, 23);
            this.lblServicio.TabIndex = 22;
            this.lblServicio.Text = "Servicio";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(107, 9);
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
            this.panelBotones.Location = new System.Drawing.Point(73, 355);
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
            this.gbCliente.Controls.Add(this.txtSaldo);
            this.gbCliente.Controls.Add(this.lblDescripcion);
            this.gbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCliente.Location = new System.Drawing.Point(87, 261);
            this.gbCliente.Name = "gbCliente";
            this.gbCliente.Size = new System.Drawing.Size(385, 88);
            this.gbCliente.TabIndex = 19;
            this.gbCliente.TabStop = false;
            this.gbCliente.Text = "Información";
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(79, 35);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(283, 26);
            this.txtSaldo.TabIndex = 1;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(9, 38);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(55, 20);
            this.lblDescripcion.TabIndex = 11;
            this.lblDescripcion.Text = "Saldo";
            // 
            // lstClientes
            // 
            this.lstClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstClientes.FormattingEnabled = true;
            this.lstClientes.ItemHeight = 24;
            this.lstClientes.Location = new System.Drawing.Point(6, 35);
            this.lstClientes.Name = "lstClientes";
            this.lstClientes.Size = new System.Drawing.Size(278, 220);
            this.lstClientes.TabIndex = 10;
            this.lstClientes.TabStop = false;
            this.lstClientes.UseTabStops = false;
            this.lstClientes.Click += new System.EventHandler(this.lstClientes_Click);
            // 
            // lstServicioP
            // 
            this.lstServicioP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstServicioP.FormattingEnabled = true;
            this.lstServicioP.ItemHeight = 24;
            this.lstServicioP.Location = new System.Drawing.Point(298, 35);
            this.lstServicioP.Name = "lstServicioP";
            this.lstServicioP.Size = new System.Drawing.Size(282, 220);
            this.lstServicioP.TabIndex = 9;
            this.lstServicioP.TabStop = false;
            this.lstServicioP.UseTabStops = false;
            // 
            // gbServicioCliente
            // 
            this.gbServicioCliente.Controls.Add(this.lstServicioCliente);
            this.gbServicioCliente.Location = new System.Drawing.Point(616, 45);
            this.gbServicioCliente.Name = "gbServicioCliente";
            this.gbServicioCliente.Size = new System.Drawing.Size(277, 431);
            this.gbServicioCliente.TabIndex = 4;
            this.gbServicioCliente.TabStop = false;
            // 
            // lstServicioCliente
            // 
            this.lstServicioCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstServicioCliente.FormattingEnabled = true;
            this.lstServicioCliente.ItemHeight = 24;
            this.lstServicioCliente.Location = new System.Drawing.Point(6, 19);
            this.lstServicioCliente.Name = "lstServicioCliente";
            this.lstServicioCliente.Size = new System.Drawing.Size(265, 388);
            this.lstServicioCliente.TabIndex = 10;
            this.lstServicioCliente.TabStop = false;
            this.lstServicioCliente.UseTabStops = false;
            this.lstServicioCliente.Click += new System.EventHandler(this.lstServicioCliente_Click);
            // 
            // frmServicioCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 488);
            this.Controls.Add(this.gbServicioCliente);
            this.Controls.Add(this.gbListas);
            this.Controls.Add(this.lblServicioC);
            this.Name = "frmServicioCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GenisysATM";
            this.Load += new System.EventHandler(this.frmServicioCliente_Load);
            this.gbListas.ResumeLayout(false);
            this.gbListas.PerformLayout();
            this.panelBotones.ResumeLayout(false);
            this.gbCliente.ResumeLayout(false);
            this.gbCliente.PerformLayout();
            this.gbServicioCliente.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblServicioC;
        private System.Windows.Forms.GroupBox gbListas;
        private System.Windows.Forms.ListBox lstServicioP;
        private System.Windows.Forms.ListBox lstClientes;
        private System.Windows.Forms.GroupBox gbCliente;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Panel panelBotones;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.GroupBox gbServicioCliente;
        private System.Windows.Forms.ListBox lstServicioCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblServicio;
    }
}