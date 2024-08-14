namespace Sistema_Reservas_Admin
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.lblMenu = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.logoCasa242 = new System.Windows.Forms.PictureBox();
            this.pnlHistorial = new Sistema_Reservas.Botones.PanelInicio();
            this.imgHistorial = new System.Windows.Forms.PictureBox();
            this.lblHistorial = new System.Windows.Forms.Label();
            this.pnlBitacora = new Sistema_Reservas.Botones.PanelInicio();
            this.imgBitacora = new System.Windows.Forms.PictureBox();
            this.lblBitacora = new System.Windows.Forms.Label();
            this.pnlTransmision = new Sistema_Reservas.Botones.PanelInicio();
            this.imgTransmision = new System.Windows.Forms.PictureBox();
            this.lblTransmision = new System.Windows.Forms.Label();
            this.pnlSalon = new Sistema_Reservas.Botones.PanelInicio();
            this.imgSalon = new System.Windows.Forms.PictureBox();
            this.lblSalon = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoCasa242)).BeginInit();
            this.pnlHistorial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgHistorial)).BeginInit();
            this.pnlBitacora.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgBitacora)).BeginInit();
            this.pnlTransmision.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgTransmision)).BeginInit();
            this.pnlSalon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgSalon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.Location = new System.Drawing.Point(282, 9);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(275, 38);
            this.lblMenu.TabIndex = 4;
            this.lblMenu.Text = "Menú Administrativo";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.logoCasa242);
            this.panel1.Location = new System.Drawing.Point(12, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(957, 494);
            this.panel1.TabIndex = 6;
            // 
            // logoCasa242
            // 
            this.logoCasa242.Image = ((System.Drawing.Image)(resources.GetObject("logoCasa242.Image")));
            this.logoCasa242.Location = new System.Drawing.Point(809, 16);
            this.logoCasa242.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logoCasa242.Name = "logoCasa242";
            this.logoCasa242.Size = new System.Drawing.Size(89, 40);
            this.logoCasa242.TabIndex = 5;
            this.logoCasa242.TabStop = false;
            // 
            // pnlHistorial
            // 
            this.pnlHistorial.Asiento = null;
            this.pnlHistorial.BackColor = System.Drawing.Color.White;
            this.pnlHistorial.BackgroundColor = System.Drawing.Color.White;
            this.pnlHistorial.BorderColor = System.Drawing.Color.Red;
            this.pnlHistorial.BorderRadius = 40;
            this.pnlHistorial.BorderSize = 2;
            this.pnlHistorial.Controls.Add(this.imgHistorial);
            this.pnlHistorial.Controls.Add(this.lblHistorial);
            this.pnlHistorial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlHistorial.ForeColor = System.Drawing.Color.Black;
            this.pnlHistorial.Location = new System.Drawing.Point(579, 304);
            this.pnlHistorial.Name = "pnlHistorial";
            this.pnlHistorial.Size = new System.Drawing.Size(306, 176);
            this.pnlHistorial.TabIndex = 3;
            this.pnlHistorial.TextColor = System.Drawing.Color.Black;
            this.pnlHistorial.Click += new System.EventHandler(this.pnlHistorial_Click);
            // 
            // imgHistorial
            // 
            this.imgHistorial.Image = global::Sistema_Reservas_Admin.Properties.Resources.Historial;
            this.imgHistorial.Location = new System.Drawing.Point(99, 59);
            this.imgHistorial.Name = "imgHistorial";
            this.imgHistorial.Size = new System.Drawing.Size(100, 50);
            this.imgHistorial.TabIndex = 5;
            this.imgHistorial.TabStop = false;
            // 
            // lblHistorial
            // 
            this.lblHistorial.AutoSize = true;
            this.lblHistorial.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistorial.Location = new System.Drawing.Point(80, 133);
            this.lblHistorial.Name = "lblHistorial";
            this.lblHistorial.Size = new System.Drawing.Size(164, 28);
            this.lblHistorial.TabIndex = 6;
            this.lblHistorial.Text = "Historial Reservas";
            // 
            // pnlBitacora
            // 
            this.pnlBitacora.Asiento = null;
            this.pnlBitacora.BackColor = System.Drawing.Color.White;
            this.pnlBitacora.BackgroundColor = System.Drawing.Color.White;
            this.pnlBitacora.BorderColor = System.Drawing.Color.Red;
            this.pnlBitacora.BorderRadius = 40;
            this.pnlBitacora.BorderSize = 2;
            this.pnlBitacora.Controls.Add(this.imgBitacora);
            this.pnlBitacora.Controls.Add(this.lblBitacora);
            this.pnlBitacora.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlBitacora.ForeColor = System.Drawing.Color.Black;
            this.pnlBitacora.Location = new System.Drawing.Point(36, 304);
            this.pnlBitacora.Name = "pnlBitacora";
            this.pnlBitacora.Size = new System.Drawing.Size(324, 176);
            this.pnlBitacora.TabIndex = 2;
            this.pnlBitacora.TextColor = System.Drawing.Color.Black;
            this.pnlBitacora.Click += new System.EventHandler(this.pnlBitacora_Click);
            // 
            // imgBitacora
            // 
            this.imgBitacora.Image = global::Sistema_Reservas_Admin.Properties.Resources.Bitacora;
            this.imgBitacora.Location = new System.Drawing.Point(111, 59);
            this.imgBitacora.Name = "imgBitacora";
            this.imgBitacora.Size = new System.Drawing.Size(100, 50);
            this.imgBitacora.TabIndex = 5;
            this.imgBitacora.TabStop = false;
            // 
            // lblBitacora
            // 
            this.lblBitacora.AutoSize = true;
            this.lblBitacora.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBitacora.Location = new System.Drawing.Point(128, 133);
            this.lblBitacora.Name = "lblBitacora";
            this.lblBitacora.Size = new System.Drawing.Size(83, 28);
            this.lblBitacora.TabIndex = 6;
            this.lblBitacora.Text = "Bitácora";
            // 
            // pnlTransmision
            // 
            this.pnlTransmision.Asiento = null;
            this.pnlTransmision.BackColor = System.Drawing.Color.White;
            this.pnlTransmision.BackgroundColor = System.Drawing.Color.White;
            this.pnlTransmision.BorderColor = System.Drawing.Color.Red;
            this.pnlTransmision.BorderRadius = 40;
            this.pnlTransmision.BorderSize = 2;
            this.pnlTransmision.Controls.Add(this.imgTransmision);
            this.pnlTransmision.Controls.Add(this.lblTransmision);
            this.pnlTransmision.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlTransmision.ForeColor = System.Drawing.Color.Black;
            this.pnlTransmision.Location = new System.Drawing.Point(579, 75);
            this.pnlTransmision.Name = "pnlTransmision";
            this.pnlTransmision.Size = new System.Drawing.Size(306, 176);
            this.pnlTransmision.TabIndex = 1;
            this.pnlTransmision.TextColor = System.Drawing.Color.Black;
            this.pnlTransmision.Click += new System.EventHandler(this.pnlTransmision_Click);
            // 
            // imgTransmision
            // 
            this.imgTransmision.Image = global::Sistema_Reservas_Admin.Properties.Resources.TransmisionAdmin;
            this.imgTransmision.Location = new System.Drawing.Point(99, 33);
            this.imgTransmision.Name = "imgTransmision";
            this.imgTransmision.Size = new System.Drawing.Size(100, 50);
            this.imgTransmision.TabIndex = 5;
            this.imgTransmision.TabStop = false;
            // 
            // lblTransmision
            // 
            this.lblTransmision.AutoSize = true;
            this.lblTransmision.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransmision.Location = new System.Drawing.Point(28, 126);
            this.lblTransmision.Name = "lblTransmision";
            this.lblTransmision.Size = new System.Drawing.Size(254, 28);
            this.lblTransmision.TabIndex = 6;
            this.lblTransmision.Text = "Gestión Transmisión en vivo";
            // 
            // pnlSalon
            // 
            this.pnlSalon.Asiento = null;
            this.pnlSalon.BackColor = System.Drawing.Color.White;
            this.pnlSalon.BackgroundColor = System.Drawing.Color.White;
            this.pnlSalon.BorderColor = System.Drawing.Color.Red;
            this.pnlSalon.BorderRadius = 40;
            this.pnlSalon.BorderSize = 2;
            this.pnlSalon.Controls.Add(this.imgSalon);
            this.pnlSalon.Controls.Add(this.lblSalon);
            this.pnlSalon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlSalon.ForeColor = System.Drawing.Color.Black;
            this.pnlSalon.Location = new System.Drawing.Point(36, 75);
            this.pnlSalon.Name = "pnlSalon";
            this.pnlSalon.Size = new System.Drawing.Size(324, 176);
            this.pnlSalon.TabIndex = 0;
            this.pnlSalon.TextColor = System.Drawing.Color.Black;
            this.pnlSalon.Click += new System.EventHandler(this.pnlSalon_Click);
            // 
            // imgSalon
            // 
            this.imgSalon.Image = global::Sistema_Reservas_Admin.Properties.Resources.SalonPrincipalAdmin;
            this.imgSalon.Location = new System.Drawing.Point(111, 33);
            this.imgSalon.Name = "imgSalon";
            this.imgSalon.Size = new System.Drawing.Size(100, 50);
            this.imgSalon.TabIndex = 5;
            this.imgSalon.TabStop = false;
            // 
            // lblSalon
            // 
            this.lblSalon.AutoSize = true;
            this.lblSalon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalon.Location = new System.Drawing.Point(49, 117);
            this.lblSalon.Name = "lblSalon";
            this.lblSalon.Size = new System.Drawing.Size(213, 28);
            this.lblSalon.TabIndex = 5;
            this.lblSalon.Text = "Gestión Salón Principal";
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1010, 528);
            this.Controls.Add(this.lblMenu);
            this.Controls.Add(this.pnlHistorial);
            this.Controls.Add(this.pnlBitacora);
            this.Controls.Add(this.pnlTransmision);
            this.Controls.Add(this.pnlSalon);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Inicio";
            this.Text = "Menú Administrativo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoCasa242)).EndInit();
            this.pnlHistorial.ResumeLayout(false);
            this.pnlHistorial.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgHistorial)).EndInit();
            this.pnlBitacora.ResumeLayout(false);
            this.pnlBitacora.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgBitacora)).EndInit();
            this.pnlTransmision.ResumeLayout(false);
            this.pnlTransmision.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgTransmision)).EndInit();
            this.pnlSalon.ResumeLayout(false);
            this.pnlSalon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgSalon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sistema_Reservas.Botones.PanelInicio pnlSalon;
        private Sistema_Reservas.Botones.PanelInicio pnlTransmision;
        private Sistema_Reservas.Botones.PanelInicio pnlBitacora;
        private Sistema_Reservas.Botones.PanelInicio pnlHistorial;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.PictureBox imgSalon;
        private System.Windows.Forms.Label lblSalon;
        private System.Windows.Forms.Label lblTransmision;
        private System.Windows.Forms.Label lblBitacora;
        private System.Windows.Forms.Label lblHistorial;
        private System.Windows.Forms.PictureBox imgTransmision;
        private System.Windows.Forms.PictureBox imgBitacora;
        private System.Windows.Forms.PictureBox imgHistorial;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox logoCasa242;
    }
}

