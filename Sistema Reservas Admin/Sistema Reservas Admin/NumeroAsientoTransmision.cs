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
    public partial class NumeroAsientoTransmision : Form
    {
        private readonly IConfiguration _configuration;

        public NumeroAsientoTransmision(int id, IConfiguration configuration)
        {
            InitializeComponent();
            this.id = id;
            panel1.Paint += Panel1_Paint;
            _configuration = configuration;
        }

        // Id el asiento
        int id;

        // Instancia del cuadro de alerta
        void CuadroAlerta(Color backColor, Color color, string title, string text, Image icon)
        {
            Alerta alerta = new Alerta();
            alerta.BackColor = backColor;
            alerta.ColorAlertBox = color;
            alerta.TitleAlertBox = title;
            alerta.TextAlertBox = text;
            alerta.IconAlertBox = icon;
            alerta.ShowDialog();
        }

        private void NumeroAsientoTransmision_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            /* Inicio Panel 1 */

            int ancho_panel1 = 1000;
            int alto_panel1 = 400;
            panel1.Size = new Size(ancho_panel1, alto_panel1);
            int x_panel1 = (Screen.PrimaryScreen.WorkingArea.Width - ancho_panel1) / 2;
            int y_panel1 = (Screen.PrimaryScreen.WorkingArea.Height - alto_panel1) / 2;
            panel1.Location = new Point(x_panel1, y_panel1);

            /* Fin Panel 1 */

            /* Inicio Label 1 */

            label1.AutoSize = false;
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Size = new Size(700, 65); // Ajusta el tamaño como prefieras
            label1.Font = new Font(label1.Font.FontFamily, 34, FontStyle.Regular); // 16 es el tamaño de fuente deseado
            label1.Location = new Point(150, 50); // Por ejemplo, posición X=100, Y=100

            /* Fin Label 1 */

            /* Inicio textBox 1 */

            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.Font = new Font(label1.Font.FontFamily, 24, FontStyle.Regular); // 16 es el tamaño de fuente deseado
            textBox1.Size = new Size(400, 200);
            textBox1.Location = new Point(300, 175);

            /* Fin textBox 1 */

            /* Inicio btnContinuar */

            Color color = ColorTranslator.FromHtml("#ED4F49");
            btnContinuar.BackColor = color;
            btnContinuar.Size = new Size(300, 50);
            btnContinuar.Location = new Point(350, 300);
            btnContinuar.Font = new Font(btnContinuar.Font.FontFamily, 26, FontStyle.Regular); // 16 es el tamaño de fuente deseado

            /* Fin btnContinuar */
        }

        /* Establecer bordes al panel 1 */

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

        /* Habilitar el asiento dentro de la base de datos */
        private void Habilitar(int id)
        {
            string numeroAsiento = textBox1.Text.Trim(); // Eliminar espacios en blanco alrededor del texto
            if (string.IsNullOrEmpty(numeroAsiento))
            {
                CuadroAlerta(Color.LightPink, Color.DarkRed, "Error", "Ingrese un número válido", Properties.Resources.Error);
            }
            else
            {
                string connectionString = _configuration.GetConnectionString("DefaultConnection");

                string consulta = "UPDATE asientos_transmision SET CATEGORIA = \"Disponible\", ASIENTO = @nuevoAsiento, RESERVADO = false WHERE ID_ASIENTO = @idAsiento";

                using (MySqlConnection conexion = new MySqlConnection(connectionString))
                {
                    using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@idAsiento", id);
                        comando.Parameters.AddWithValue("@nuevoAsiento", numeroAsiento);

                        try
                        {
                            conexion.Open();
                            comando.ExecuteNonQuery();
                            Transmision transmision = new Transmision(_configuration);
                            transmision.Show();
                            this.Close();
                        }
                        catch (MySqlException)
                        {
                            CuadroAlerta(Color.LightPink, Color.DarkRed, "Error", "Ocurrió un error de conexión con la base de datos", Properties.Resources.Error);
                        }
                    }
                }
            }
        }

        /* Volver a la página anterior */
        private void btnAtras_Click(object sender, EventArgs e)
        {
            Transmision transmision = new Transmision(_configuration);
            transmision.Show();
            this.Close();
        }

        /* Ejecutar la función de habilitar */

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            Habilitar(id);
        }
    }
}
