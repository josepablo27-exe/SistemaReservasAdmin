using Microsoft.Extensions.Configuration;
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
    public partial class Inicio : Form
    {
        private readonly IConfiguration _configuration;

        public Inicio(IConfiguration configuration)
        {
            InitializeComponent();
            _configuration = configuration;
        }

        // Color bordes paneles
        Color color = ColorTranslator.FromHtml("#ED4F49");

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            int ancho_pantalla = Screen.PrimaryScreen.WorkingArea.Width;
            int alto_pantalla = Screen.PrimaryScreen.WorkingArea.Height;


            /* Inicio Panel 1 */

            int ancho_panel1 = (int)Math.Round(ancho_pantalla * 0.98); //1450
            int alto_panel1 = (int)Math.Round(alto_pantalla * 0.95); //750
            panel1.Size = new Size(ancho_panel1, alto_panel1);
            int x_panel1 = (ancho_pantalla - ancho_panel1) / 2;
            int y_panel1 = (alto_pantalla - alto_panel1) / 2;
            panel1.Location = new Point(x_panel1, y_panel1);

            /* Fin Panel 1 */

            /* Inicio LlblMenu */

            lblMenu.TextAlign = ContentAlignment.MiddleCenter;
            lblMenu.Font = new Font(lblMenu.Font.FontFamily, 34, FontStyle.Regular); 
            int x_lblMenu = (ancho_panel1 - lblMenu.Size.Width) / 2;
            lblMenu.Location = new Point(x_lblMenu, 30);

            /* Inicio logoCasa242 */

            int ancho_logoCasa242 = 350;
            int alto_logoCasa242 = 70;
            logoCasa242.Size = new Size(ancho_logoCasa242, alto_logoCasa242);
            int x_logoCasa242 = ancho_panel1 - ancho_logoCasa242;
            int y_logoCasa242 = 0;
            logoCasa242.Location = new Point(x_logoCasa242, y_logoCasa242);

            /* Fin logoCasa242 */

            /* Inicio pnlSalon */

            int ancho_pnlSalon = (int)Math.Round(ancho_panel1 * 0.38);
            int alto_pnlSalon = (int)Math.Round(alto_panel1 * 0.38);
            pnlSalon.Size = new Size(ancho_pnlSalon, alto_pnlSalon);
            int x_pnlSalon = 100;
            int y_pnlSalon = 120;
            pnlSalon.Location = new Point(x_pnlSalon, y_pnlSalon);
            pnlSalon.BorderColor = color;

            /* Fin pnlSalon */

            /* Inicio imgSalon */

            int ancho_imgSalon = 121;
            int alto_imgSalon = 132;
            imgSalon.Size = new Size(ancho_imgSalon, alto_imgSalon);
            int x_imgSalon = (ancho_pnlSalon - ancho_imgSalon) / 2;
            imgSalon.Location = new Point(x_imgSalon, 40);

            /* Fin imgSalon */

            /* Inicio lblSalon */

            lblSalon.TextAlign = ContentAlignment.MiddleCenter;
            lblSalon.Font = new Font(lblSalon.Font.FontFamily, 28, FontStyle.Regular);
            int x_lblSalon = (ancho_pnlSalon - lblSalon.Size.Width) / 2;
            lblSalon.Location = new Point(x_lblSalon, 220);

            /* Fin lblSalon */

            /* Inicio pnlTransmision */

            int ancho_pnlTransmision = (int)Math.Round(ancho_panel1 * 0.38);
            int alto_pnlTransmision = (int)Math.Round(alto_panel1 * 0.38);
            pnlTransmision.Size = new Size(ancho_pnlTransmision, alto_pnlTransmision);
            int x_pnlTransmision = ancho_panel1 - ancho_pnlTransmision - 100;
            int y_pnlTransmision = 120;
            pnlTransmision.Location = new Point(x_pnlTransmision, y_pnlTransmision);
            pnlTransmision.BorderColor = color;

            /* Fin pnlTransmision */

            /* Inicio imgTransmision */

            int ancho_imgTransmision = 134;
            int alto_imgTransmision = 134;
            imgTransmision.Size = new Size(ancho_imgTransmision, alto_imgTransmision);
            int x_imgTransmision = (ancho_pnlTransmision - ancho_imgTransmision) / 2;
            imgTransmision.Location = new Point(x_imgTransmision, 40);

            /* Fin imgTransmision */

            /* Inicio lblTransmision */

            lblTransmision.TextAlign = ContentAlignment.MiddleCenter;
            lblTransmision.Font = new Font(lblTransmision.Font.FontFamily, 28, FontStyle.Regular);
            int x_lblTransmision = (ancho_pnlSalon - lblTransmision.Size.Width) / 2;
            lblTransmision.Location = new Point(x_lblTransmision, 220);

            /* Fin lblTransmision */

            /* Inicio pnlBitacora */

            int ancho_pnlBitacora = (int)Math.Round(ancho_panel1 * 0.38);
            int alto_pnlBitacora = (int)Math.Round(alto_panel1 * 0.38);
            pnlBitacora.Size = new Size(ancho_pnlBitacora, alto_pnlBitacora);
            int x_pnlBitacora = 100;
            int y_pnBitacoran = 460;
            pnlBitacora.Location = new Point(x_pnlBitacora, y_pnBitacoran);
            pnlBitacora.BorderColor = color;

            /* Fin pnlBitacora */

            /* Inicio imgBitacora */

            int ancho_imgBitacora = 107;
            int alto_imgBitacora = 129;
            imgBitacora.Size = new Size(ancho_imgBitacora, alto_imgBitacora);
            int x_imgBitacora = (ancho_pnlBitacora - ancho_imgBitacora) / 2;
            imgBitacora.Location = new Point(x_imgBitacora, 40);

            /* Fin imgBitacora */

            /* Inicio lblBitacora */

            lblBitacora.TextAlign = ContentAlignment.MiddleCenter;
            lblBitacora.Font = new Font(lblBitacora.Font.FontFamily, 28, FontStyle.Regular);
            int x_lblBitacora = (ancho_pnlSalon - lblBitacora.Size.Width) / 2;
            lblBitacora.Location = new Point(x_lblBitacora, 220); 

            /* Fin lblBitacora */

            /* Inicio pnlHistorial */

            int ancho_pnlHistorial = (int)Math.Round(ancho_panel1 * 0.38);
            int alto_pnlHistorial = (int)Math.Round(alto_panel1 * 0.38);
            pnlHistorial.Size = new Size(ancho_pnlHistorial, alto_pnlHistorial);
            int x_pnlHistorial = ancho_panel1 - ancho_pnlHistorial - 100;
            int y_pnlHistorial = 460;
            pnlHistorial.Location = new Point(x_pnlHistorial, y_pnlHistorial);
            pnlHistorial.BorderColor = color;

            /* Fin pnlHistorial */

            /* Inicio imgHistorial */

            int ancho_imgHistorial = 155;
            int alto_imgHistorial = 132;
            imgHistorial.Size = new Size(ancho_imgHistorial, alto_imgHistorial);
            int x_imgHistorial = (ancho_pnlHistorial - ancho_imgHistorial) / 2;
            imgHistorial.Location = new Point(x_imgHistorial, 40);

            /* Fin imgHistorial */

            /* Inicio lblHistorial */

            lblHistorial.TextAlign = ContentAlignment.MiddleCenter;
            lblHistorial.Font = new Font(lblHistorial.Font.FontFamily, 28, FontStyle.Regular);
            int x_lblHistorial = (ancho_pnlHistorial - lblHistorial.Size.Width) / 2;
            lblHistorial.Location = new Point(x_lblHistorial, 220);

            /* Fin lblHistorial */
        }

        /* Entrar al apartado de Gestión Salón Principal */

        private void pnlSalon_Click(object sender, EventArgs e)
        {
            SalonPrincipal salon = new SalonPrincipal(_configuration);
            salon.Show();
            this.Hide();
        }

        /* Entrar al apartado de Gestión Transmisión en vivo */

        private void pnlTransmision_Click(object sender, EventArgs e)
        {
            Transmision transmision = new Transmision(_configuration);
            transmision.Show();
            this.Hide();
        }

        /* Entrar al apartado de Bitácora */

        private void pnlBitacora_Click(object sender, EventArgs e)
        {
            Bitacora bitacora = new Bitacora(_configuration);
            bitacora.Show();
            this.Hide();
        }

        /* Entrar al apartado de Historial de Reservas */

        private void pnlHistorial_Click(object sender, EventArgs e)
        {
            Historial historial = new Historial(_configuration);
            historial.Show();
            this.Hide();
        }
    }
}
