using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Reservas_Admin
{
    public partial class Categorias : Form
    {
        private readonly IConfiguration _configuration;
        public Categorias(int id, IConfiguration configuration)
        {
            InitializeComponent();
            panel1.Paint += Panel1_Paint;
            this.id = id;
            _configuration = configuration;
        }

        // Id del asiento
        int id;

        // Colores de los botones 
        Color colorCoches = ColorTranslator.FromHtml("#CD0000");
        Color colorAC = ColorTranslator.FromHtml("#003CFF");

        private void Categorias_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            int ancho_pantalla = Screen.PrimaryScreen.WorkingArea.Width;
            int alto_pantalla = Screen.PrimaryScreen.WorkingArea.Height;

            /* Inicio Panel 1 */

            int ancho_panel1 = (int)Math.Round(ancho_pantalla * 0.75); //1450
            int alto_panel1 = (int)Math.Round(alto_pantalla * 0.70); //750
            panel1.Size = new Size(ancho_panel1, alto_panel1);
            int x_panel1 = (ancho_pantalla - ancho_panel1) / 2;
            int y_panel1 = (alto_pantalla - alto_panel1) / 2;
            panel1.Location = new Point(x_panel1, y_panel1);

            /* Fin Panel 1 */

            /* Inicio Label 1 */

            label1.Font = new Font(label1.Font.FontFamily, 34, FontStyle.Regular);
            int x_label1 = (ancho_panel1 - label1.Size.Width) / 2;
            label1.Location = new Point(x_label1, 30);

            /* Fin Label 1 */

            /* Inicio btnDisponible */

            int ancho_btnDisponible = 400;
            int alto_btnDisponible = 75;
            btnDisponible.Font = new Font(btnDisponible.Font.FontFamily, 24, FontStyle.Regular);
            btnDisponible.Size = new Size(ancho_btnDisponible, alto_btnDisponible);
            int x_btnDisponible = (ancho_panel1 - ancho_btnDisponible) / 2;
            btnDisponible.Location = new Point(x_btnDisponible, 150);

            /* Fin btnDisponible */

            /* Inicio btnAC */

            int ancho_btnAC = 400;
            int alto_btnAC = 75;
            btnAC.Font = new Font(btnAC.Font.FontFamily, 24, FontStyle.Regular);
            btnAC.Size = new Size(ancho_btnAC, alto_btnAC);
            int x_btnAC = (ancho_panel1 - ancho_btnAC) / 2;
            btnAC.Location = new Point(x_btnAC, 300);
            btnAC.ForeColor = colorAC;
            btnAC.BorderColor = colorAC;

            /* Fin btnAC */

            /* Inicio btnCoches */

            int ancho_btnCoches = 400;
            int alto_btnCoches = 75;
            btnCoches.Font = new Font(btnCoches.Font.FontFamily, 24, FontStyle.Regular);
            btnCoches.Size = new Size(ancho_btnCoches, alto_btnCoches);
            int x_btnCoches = (ancho_panel1 - ancho_btnCoches) / 2;
            btnCoches.Location = new Point(x_btnCoches, 450);
            btnCoches.ForeColor = colorCoches;
            btnCoches.BorderColor = colorCoches;

            /* Fin btnCoches */
        }

        /* Definir bordes al panel 1 */

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            // Obtener el control Label
            Panel panel = sender as Panel;

            // Dibujar un borde adicional alrededor del control Label
            ControlPaint.DrawBorder(e.Graphics, panel1.ClientRectangle,
                                         Color.Black, 2, ButtonBorderStyle.Solid,
                                         Color.Black, 2, ButtonBorderStyle.Solid,
                                         Color.Black, 2, ButtonBorderStyle.Solid,
                                         Color.Black, 2, ButtonBorderStyle.Solid);
        }

        /* Volver a la página anterior */

        private void btnAtras_Click(object sender, EventArgs e)
        {
            SalonPrincipal salon = new SalonPrincipal(_configuration);
            salon.Show();
            this.Close();
        }

        /* Abrir el form de Numero de Asiento pasando como parametro "Disponible" */

        private void btnDisponible_Click(object sender, EventArgs e)
        {
            NumeroAsientoSalon numeroAsiento = new NumeroAsientoSalon(id, "Disponible", _configuration);
            numeroAsiento.Show();
            this.Close();
        }

        /* Abrir el form de Numero de Asiento pasando como parametro "A/C" */

        private void btnAC_Click(object sender, EventArgs e)
        {
            NumeroAsientoSalon numeroAsiento = new NumeroAsientoSalon(id, "A/C", _configuration);
            numeroAsiento.Show();
            this.Close();
        }

        /* Abrir el form de Numero de Asiento pasando como parametro "Coches" */

        private void btnCoches_Click(object sender, EventArgs e)
        {
            NumeroAsientoSalon numeroAsiento = new NumeroAsientoSalon(id, "Coches", _configuration);
            numeroAsiento.Show();
            this.Close();
        }
    }
}
