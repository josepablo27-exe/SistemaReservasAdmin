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
    public partial class TituloBitacora : Form
    {
        private readonly IConfiguration _configuration;

        public TituloBitacora(IConfiguration configuration)
        {
            InitializeComponent();
            panel1.Paint += Panel1_Paint;
            _configuration = configuration;
        }

        /* Instancia del cuadro para la alerta */
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

        private void TituloBitacora_Load(object sender, EventArgs e)
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

            label1.Font = new Font(label1.Font.FontFamily, 34, FontStyle.Regular);
            label1.Location = new Point(150, 50);

            /* Fin Label 1 */

            /* Inicio textBox 1 */

            int ancho_textBox1 = 500;
            int alto_textBox1 = 200;
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.Font = new Font(label1.Font.FontFamily, 24, FontStyle.Regular);
            textBox1.Size = new Size(ancho_textBox1, alto_textBox1);
            int x_textBox1 = (ancho_panel1 - ancho_textBox1) / 2;
            textBox1.Location = new Point(x_textBox1, 175);

            /* Fin textBox 1 */

            /* Inicio btnCancelar */

            Color color = ColorTranslator.FromHtml("#ED4F49");
            btnCancelar.BorderColor = color;
            btnCancelar.TextColor = color;
            btnCancelar.Size = new Size(250, 50);
            btnCancelar.Location = new Point(200, 300);
            btnCancelar.Font = new Font(btnCancelar.Font.FontFamily, 26, FontStyle.Regular);

            /* Fin btnCancelar */

            /* Inicio btnGuardar */

            btnGuardar.BackColor = color;
            btnGuardar.Size = new Size(250, 50);
            btnGuardar.Location = new Point(550, 300);
            btnGuardar.Font = new Font(btnGuardar.Font.FontFamily, 26, FontStyle.Regular);

            /* Fin btnGuardar */
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

        /* Obtener la cantidad de asientos reservados en el Salón Principal */

        private int ContarAsientosReservadosSalon()
        {
            string connectionString = _configuration.GetConnectionString("DefaultConnection");
            int cantidadReservados = 0;
            string consulta = "SELECT COUNT(*) FROM asientos_salon WHERE RESERVADO = true";

            using (MySqlConnection conexion = new MySqlConnection(connectionString))
            {
                using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                {
                    try
                    {
                        conexion.Open();
                        object resultado = comando.ExecuteScalar();
                        if (resultado != null)
                        {
                            cantidadReservados = Convert.ToInt32(resultado);
                        }
                    }
                    catch (MySqlException)
                    {
                        CuadroAlerta(Color.LightPink, Color.DarkRed, "Error", "Ocurrió un error de conexión con la base de datos", Properties.Resources.Error);
                    }
                }
            }

            return cantidadReservados;
        }

        /* Obteneener la cantidad de asientos reservados en Transmisión en vivo */

        private int ContarAsientosReservadosTransmision()
        {
            string connectionString = _configuration.GetConnectionString("DefaultConnection");
            int cantidadReservados = 0;
            string consulta = "SELECT COUNT(*) FROM asientos_transmision WHERE RESERVADO = true";

            using (MySqlConnection conexion = new MySqlConnection(connectionString))
            {
                using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                {
                    try
                    {
                        conexion.Open();
                        object resultado = comando.ExecuteScalar();
                        if (resultado != null)
                        {
                            cantidadReservados = Convert.ToInt32(resultado);
                        }
                    }
                    catch (MySqlException)
                    {
                        CuadroAlerta(Color.LightPink, Color.DarkRed, "Error", "Ocurrió un error de conexión con la base de datos", Properties.Resources.Error);
                    }
                }
            }

            return cantidadReservados;
        }

        /* Guardar el nuevo registro dentro de la base de datos */

        private void GuardarRegistro()
        {
            string connectionString = _configuration.GetConnectionString("DefaultConnection");
            // Consulta SQL para insertar los datos en la tabla RESERVAS
            string consulta = "INSERT INTO BITACORA (TITULO, SALON_PRINCIPAL, TRANSMISION, TOTAL) VALUES (@titulo, @salon_principal, @transmision, @total)";

            string titulo = textBox1.Text;
            int salon_principal = ContarAsientosReservadosSalon();
            int transmision = ContarAsientosReservadosTransmision();
            int total = salon_principal + transmision;

            using (MySqlConnection conexion = new MySqlConnection(connectionString))
            {
                using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                {
                    // Agrega los parámetros a la consulta
                    comando.Parameters.AddWithValue("@titulo", titulo);
                    comando.Parameters.AddWithValue("@salon_principal", salon_principal);
                    comando.Parameters.AddWithValue("@transmision", transmision);
                    comando.Parameters.AddWithValue("@total", total);
                    try
                    {
                        // Abre la conexión y ejecuta la consulta
                        conexion.Open();
                        comando.ExecuteNonQuery();
                    }
                    catch (MySqlException)
                    {
                        CuadroAlerta(Color.LightPink, Color.DarkRed, "Error", "Ocurrió un error de conexión con la base de datos", Properties.Resources.Error);
                    }
                }
            }
        }

        /* Reiniciar la cantidad de asientos reservados dentro de la base de datos */

        private void ReiniciarReservados()
        {
            string connectionString = _configuration.GetConnectionString("DefaultConnection");
            string consulta = "UPDATE asientos_salon\r\nSET RESERVADO = 0;";
            string consulta2 = "UPDATE asientos_transmision\r\nSET RESERVADO = 0;";

            try
            {
                using (MySqlConnection conexion = new MySqlConnection(connectionString))
                {
                    conexion.Open();

                    using (MySqlCommand cmd1 = new MySqlCommand(consulta, conexion))
                    {
                        cmd1.ExecuteNonQuery();
                    }

                    using (MySqlCommand cmd2 = new MySqlCommand(consulta2, conexion))
                    {
                        cmd2.ExecuteNonQuery();
                    }
                }

            }
            catch (MySqlException)
            {
                CuadroAlerta(Color.LightPink, Color.DarkRed, "Error", "Ocurrió un error de conexión con la base de datos", Properties.Resources.Error);
            }
        }

        /* Cancelar el nuevo registro */

        private void botonPrimario1_Click(object sender, EventArgs e)
        {
            Bitacora bitacora = new Bitacora(_configuration);
            bitacora.Show();
            this.Close();
        }

        /* Ejecutar la función de guardar el regisro y reiniciar los reservados */

        private void botonPrimario2_Click(object sender, EventArgs e)
        {
            GuardarRegistro();
            ReiniciarReservados();
            Bitacora bitacora = new Bitacora(_configuration);
            bitacora.Show();
            this.Close();
        }
    }
}
