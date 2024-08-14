namespace Sistema_Reservas_Admin
{
    partial class Bitacora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bitacora));
            this.lblBitacora = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tablaBitacora = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new Sistema_Reservas.Botones.BotonPrimario();
            this.btnExportar = new Sistema_Reservas.Botones.BotonPrimario();
            this.btnAtras = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaBitacora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAtras)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBitacora
            // 
            this.lblBitacora.AutoSize = true;
            this.lblBitacora.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBitacora.Location = new System.Drawing.Point(213, 14);
            this.lblBitacora.Name = "lblBitacora";
            this.lblBitacora.Size = new System.Drawing.Size(116, 38);
            this.lblBitacora.TabIndex = 2;
            this.lblBitacora.Text = "Bitácora";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tablaBitacora);
            this.panel1.Controls.Add(this.lblBitacora);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Controls.Add(this.btnExportar);
            this.panel1.Location = new System.Drawing.Point(114, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(736, 496);
            this.panel1.TabIndex = 2114;
            // 
            // tablaBitacora
            // 
            this.tablaBitacora.AllowUserToAddRows = false;
            this.tablaBitacora.BackgroundColor = System.Drawing.Color.White;
            this.tablaBitacora.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablaBitacora.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.tablaBitacora.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaBitacora.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tablaBitacora.ColumnHeadersHeight = 100;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaBitacora.DefaultCellStyle = dataGridViewCellStyle2;
            this.tablaBitacora.EnableHeadersVisualStyles = false;
            this.tablaBitacora.GridColor = System.Drawing.Color.White;
            this.tablaBitacora.Location = new System.Drawing.Point(44, 285);
            this.tablaBitacora.Name = "tablaBitacora";
            this.tablaBitacora.RowHeadersWidth = 50;
            this.tablaBitacora.RowTemplate.Height = 80;
            this.tablaBitacora.Size = new System.Drawing.Size(551, 150);
            this.tablaBitacora.TabIndex = 2116;
            this.tablaBitacora.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaBitacora_CellValueChanged_1);
            this.tablaBitacora.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.tablaBitacora_UserDeletingRow);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAgregar.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAgregar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAgregar.BorderRadius = 40;
            this.btnAgregar.BorderSize = 0;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(65, 69);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(150, 40);
            this.btnAgregar.TabIndex = 2110;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextColor = System.Drawing.Color.White;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnExportar.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnExportar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnExportar.BorderRadius = 40;
            this.btnExportar.BorderSize = 0;
            this.btnExportar.FlatAppearance.BorderSize = 0;
            this.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportar.ForeColor = System.Drawing.Color.White;
            this.btnExportar.Image = global::Sistema_Reservas_Admin.Properties.Resources.Excel;
            this.btnExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExportar.Location = new System.Drawing.Point(333, 69);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(150, 40);
            this.btnExportar.TabIndex = 2111;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.TextColor = System.Drawing.Color.White;
            this.btnExportar.UseVisualStyleBackColor = false;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtras.Image = global::Sistema_Reservas_Admin.Properties.Resources.Atras;
            this.btnAtras.Location = new System.Drawing.Point(12, 12);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(96, 92);
            this.btnAtras.TabIndex = 2109;
            this.btnAtras.TabStop = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // Bitacora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(862, 553);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Bitacora";
            this.Text = "Bitácora";
            this.Load += new System.EventHandler(this.Bitacora_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaBitacora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAtras)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblBitacora;
        private System.Windows.Forms.PictureBox btnAtras;
        private Sistema_Reservas.Botones.BotonPrimario btnAgregar;
        private Sistema_Reservas.Botones.BotonPrimario btnExportar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView tablaBitacora;
    }
}