namespace Sistema_Reservas_Admin
{
    partial class Historial
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Historial));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblHistorial = new System.Windows.Forms.Label();
            this.tablaHistorial = new System.Windows.Forms.DataGridView();
            this.btnAtras = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaHistorial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAtras)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lblHistorial);
            this.panel1.Controls.Add(this.tablaHistorial);
            this.panel1.Location = new System.Drawing.Point(135, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(637, 364);
            this.panel1.TabIndex = 2113;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblTelefono);
            this.panel2.Controls.Add(this.btnBuscar);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Location = new System.Drawing.Point(35, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(551, 65);
            this.panel2.TabIndex = 2122;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(50, 15);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(103, 17);
            this.lblTelefono.TabIndex = 2119;
            this.lblTelefono.Text = "Buscar Teléfono:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Image = global::Sistema_Reservas_Admin.Properties.Resources.Buscar;
            this.btnBuscar.Location = new System.Drawing.Point(334, 15);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(44, 40);
            this.btnBuscar.TabIndex = 2121;
            this.btnBuscar.TabStop = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(184, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 2120;
            // 
            // lblHistorial
            // 
            this.lblHistorial.AutoSize = true;
            this.lblHistorial.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistorial.Location = new System.Drawing.Point(179, 27);
            this.lblHistorial.Name = "lblHistorial";
            this.lblHistorial.Size = new System.Drawing.Size(234, 38);
            this.lblHistorial.TabIndex = 2118;
            this.lblHistorial.Text = "Historial Reservas";
            // 
            // tablaHistorial
            // 
            this.tablaHistorial.AllowUserToAddRows = false;
            this.tablaHistorial.AllowUserToDeleteRows = false;
            this.tablaHistorial.BackgroundColor = System.Drawing.Color.White;
            this.tablaHistorial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablaHistorial.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.tablaHistorial.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaHistorial.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tablaHistorial.ColumnHeadersHeight = 100;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaHistorial.DefaultCellStyle = dataGridViewCellStyle2;
            this.tablaHistorial.EnableHeadersVisualStyles = false;
            this.tablaHistorial.GridColor = System.Drawing.Color.White;
            this.tablaHistorial.Location = new System.Drawing.Point(35, 183);
            this.tablaHistorial.Name = "tablaHistorial";
            this.tablaHistorial.RowHeadersVisible = false;
            this.tablaHistorial.RowHeadersWidth = 50;
            this.tablaHistorial.RowTemplate.Height = 80;
            this.tablaHistorial.Size = new System.Drawing.Size(551, 150);
            this.tablaHistorial.TabIndex = 2117;
            // 
            // btnAtras
            // 
            this.btnAtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtras.Image = global::Sistema_Reservas_Admin.Properties.Resources.Atras;
            this.btnAtras.Location = new System.Drawing.Point(12, 12);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(96, 92);
            this.btnAtras.TabIndex = 2110;
            this.btnAtras.TabStop = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // Historial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Historial";
            this.Text = "Historial Reservas";
            this.Load += new System.EventHandler(this.Historial_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaHistorial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAtras)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox btnAtras;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView tablaHistorial;
        private System.Windows.Forms.Label lblHistorial;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox btnBuscar;
        private System.Windows.Forms.Panel panel2;
    }
}