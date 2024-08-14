namespace Sistema_Reservas_Admin
{
    partial class Categorias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Categorias));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCoches = new Sistema_Reservas.Botones.BotonPrimario();
            this.btnAC = new Sistema_Reservas.Botones.BotonPrimario();
            this.btnDisponible = new Sistema_Reservas.Botones.BotonPrimario();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAtras = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAtras)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnCoches);
            this.panel1.Controls.Add(this.btnAC);
            this.panel1.Controls.Add(this.btnDisponible);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(146, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(535, 386);
            this.panel1.TabIndex = 0;
            // 
            // btnCoches
            // 
            this.btnCoches.BackColor = System.Drawing.Color.White;
            this.btnCoches.BackgroundColor = System.Drawing.Color.White;
            this.btnCoches.BorderColor = System.Drawing.Color.Red;
            this.btnCoches.BorderRadius = 20;
            this.btnCoches.BorderSize = 2;
            this.btnCoches.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCoches.FlatAppearance.BorderSize = 0;
            this.btnCoches.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCoches.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCoches.ForeColor = System.Drawing.Color.Red;
            this.btnCoches.Location = new System.Drawing.Point(188, 276);
            this.btnCoches.Name = "btnCoches";
            this.btnCoches.Size = new System.Drawing.Size(150, 40);
            this.btnCoches.TabIndex = 3;
            this.btnCoches.Text = "Coches";
            this.btnCoches.TextColor = System.Drawing.Color.Red;
            this.btnCoches.UseVisualStyleBackColor = false;
            this.btnCoches.Click += new System.EventHandler(this.btnCoches_Click);
            // 
            // btnAC
            // 
            this.btnAC.BackColor = System.Drawing.Color.White;
            this.btnAC.BackgroundColor = System.Drawing.Color.White;
            this.btnAC.BorderColor = System.Drawing.Color.Blue;
            this.btnAC.BorderRadius = 20;
            this.btnAC.BorderSize = 2;
            this.btnAC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAC.FlatAppearance.BorderSize = 0;
            this.btnAC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAC.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAC.ForeColor = System.Drawing.Color.Blue;
            this.btnAC.Location = new System.Drawing.Point(188, 191);
            this.btnAC.Name = "btnAC";
            this.btnAC.Size = new System.Drawing.Size(150, 40);
            this.btnAC.TabIndex = 2;
            this.btnAC.Text = "A/C";
            this.btnAC.TextColor = System.Drawing.Color.Blue;
            this.btnAC.UseVisualStyleBackColor = false;
            this.btnAC.Click += new System.EventHandler(this.btnAC_Click);
            // 
            // btnDisponible
            // 
            this.btnDisponible.BackColor = System.Drawing.Color.White;
            this.btnDisponible.BackgroundColor = System.Drawing.Color.White;
            this.btnDisponible.BorderColor = System.Drawing.Color.Black;
            this.btnDisponible.BorderRadius = 20;
            this.btnDisponible.BorderSize = 2;
            this.btnDisponible.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDisponible.FlatAppearance.BorderSize = 0;
            this.btnDisponible.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisponible.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisponible.ForeColor = System.Drawing.Color.Black;
            this.btnDisponible.Location = new System.Drawing.Point(188, 111);
            this.btnDisponible.Name = "btnDisponible";
            this.btnDisponible.Size = new System.Drawing.Size(150, 40);
            this.btnDisponible.TabIndex = 1;
            this.btnDisponible.Text = "Disponible";
            this.btnDisponible.TextColor = System.Drawing.Color.Black;
            this.btnDisponible.UseVisualStyleBackColor = false;
            this.btnDisponible.Click += new System.EventHandler(this.btnDisponible_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(136, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione la categoría";
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
            // Categorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Categorias";
            this.Text = "Seleccione la categoría";
            this.Load += new System.EventHandler(this.Categorias_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAtras)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Sistema_Reservas.Botones.BotonPrimario btnCoches;
        private Sistema_Reservas.Botones.BotonPrimario btnAC;
        private Sistema_Reservas.Botones.BotonPrimario btnDisponible;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnAtras;
    }
}