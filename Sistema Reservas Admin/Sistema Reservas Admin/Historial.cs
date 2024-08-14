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
    public partial class Historial : Form
    {
        private readonly IConfiguration _configuration;
        public Historial(IConfiguration configuration)
        {
            InitializeComponent();
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

        private void Historial_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            int ancho_pantalla = Screen.PrimaryScreen.WorkingArea.Width;
            int alto_pantalla = Screen.PrimaryScreen.WorkingArea.Height;

            /* Inicio Panel 1 */

            int ancho_panel1 = (int)Math.Round(ancho_pantalla * 0.88);
            int alto_panel1 = (int)Math.Round(alto_pantalla * 0.93);
            panel1.Size = new Size(ancho_panel1, alto_panel1);
            int x_panel1 = (ancho_pantalla - ancho_panel1) / 2;
            int y_panel1 = (alto_pantalla - alto_panel1) / 2;
            panel1.Location = new Point(x_panel1, y_panel1);

            /* Fin Panel 1 */

            /* Inicio lblHistorial */

            lblHistorial.TextAlign = ContentAlignment.MiddleCenter;
            lblHistorial.Font = new Font(lblHistorial.Font.FontFamily, 34, FontStyle.Regular);
            int x_lblHistorial = (ancho_panel1 - lblHistorial.Size.Width) / 2;
            lblHistorial.Location = new Point(x_lblHistorial, 10);

            /* Fin lblHistorial */

            /* Inicio panel 2 */

            int ancho_panel2 = 575;
            int alto_panel2 = 70;
            panel2.Size = new Size(ancho_panel2, alto_panel2);
            int x_panel2 = (ancho_panel1 - ancho_panel2) / 2;
            panel2.Location = new Point(x_panel2, 125);

            /* Fin panel 2 */

            /* Inicio lblTelefono */

            lblTelefono.TextAlign = ContentAlignment.MiddleCenter;
            lblTelefono.Font = new Font(lblTelefono.Font.FontFamily, 26, FontStyle.Regular);
            lblTelefono.Location = new Point(5, 5);

            /* Fin lblTelefono */

            /* Inicio textBox 1 */

            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.Font = new Font(lblHistorial.Font.FontFamily, 24, FontStyle.Regular);
            textBox1.Size = new Size(200, 125);
            textBox1.Location = new Point(285 ,5);

            /* Fin textBox 1 */

            /* Inicio btnBuscar */

            btnBuscar.Size = new Size(55, 55);
            btnBuscar.Location = new Point(500, 0);

            /* Fin btnBuscar */

            /* Inicio tablaHistorial */

            int ancho_tablaHistorial = 1308;
            tablaHistorial.Size = new Size(ancho_tablaHistorial, 530);
            RellenarGrid();
            if (tablaHistorial.Columns.Count > 0)
            {
                tablaHistorial.Columns[0].Width = 325;
                tablaHistorial.Columns[1].Width = 325;
                tablaHistorial.Columns[2].Width = 325;
                tablaHistorial.Columns[3].Width = 325;
            }
            int x_tablaHistorial = (ancho_panel1 - ancho_tablaHistorial) / 2;

            tablaHistorial.Location = new Point(x_tablaHistorial, 230);
            if (tablaHistorial.Columns.Contains("Teléfono"))
            {
                tablaHistorial.Columns["Teléfono"].ReadOnly = true;
            }
            if (tablaHistorial.Columns.Contains("Asientos"))
            {
                tablaHistorial.Columns["Asientos"].ReadOnly = true;
            }
            if (tablaHistorial.Columns.Contains("Salón"))
            {
                tablaHistorial.Columns["Salón"].ReadOnly = true;
            }
            if (tablaHistorial.Columns.Contains("Fecha"))
            {
            tablaHistorial.Columns["Fecha"].ReadOnly = true;
            }

            /* Fin tablaHistorial */
        }

        // FUNCIONES:

        /* Llenar la tablaHistorial con los datos dentro de la BD */

        public void RellenarGrid()
        {
            string connectionString = _configuration.GetConnectionString("DefaultConnection");

            using (MySqlConnection conexion = new MySqlConnection(connectionString))
            {

                string consulta = "SELECT TELEFONO AS \"Teléfono\", ASIENTO AS \"Asientos\", SALON AS \"Salón\", FECHA AS \"Fecha\" FROM HISTORIAL";

                // Crear un adaptador de datos para ejecutar la consulta y llenar un DataTable
                using (MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta, conexion))
                {
                    // Crear un DataTable para almacenar los resultados de la consulta
                    DataTable tabla = new DataTable();

                    try
                    {
                        // Llenar el DataTable con los resultados de la consulta
                        adaptador.Fill(tabla);
                    }
                    catch (MySqlException)
                    {
                        CuadroAlerta(Color.LightPink, Color.DarkRed, "Error", "Ocurrió un error de conexión con la base de datos", Properties.Resources.Error);
                    }
                    
                    // Asignar el DataTable como origen de datos del DataGridView
                    tablaHistorial.DataSource = tabla;
                }
            }
        }

        /* Buscar el teléfono dentro de la BD y mostrandolo en la tablaHistorial */

        private void BuscarTelefono()
        {
            if (textBox1.Text != "")
            {
                string telefono_buscar = textBox1.Text;

                string connectionString = _configuration.GetConnectionString("DefaultConnection");

                using (MySqlConnection conexion = new MySqlConnection(connectionString))
                {
                    // Abrir la conexión
                    conexion.Open();

                    string consulta = "SELECT TELEFONO AS \"Teléfono\", ASIENTO AS \"Asientos\", SALON AS \"Salón\", FECHA AS \"Fecha\" FROM HISTORIAL WHERE TELEFONO LIKE @telefono_buscar";

                    using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                    {
                        // Agregar el parámetro con los caracteres comodín
                        comando.Parameters.AddWithValue("@telefono_buscar", "%" + telefono_buscar + "%");

                        using (MySqlDataAdapter adaptador = new MySqlDataAdapter(comando))
                        {
                            DataTable tabla = new DataTable();

                            // Llenar el DataTable con los resultados de la consulta
                            adaptador.Fill(tabla);

                            if (tabla.Rows.Count > 0)
                            {
                                // Asignar el DataTable como origen de datos del DataGridView
                                tablaHistorial.DataSource = tabla;
                                textBox1.Text = string.Empty;
                            }
                            else
                            {
                                // Mostrar mensaje si no se encuentran resultados
                                CuadroAlerta(Color.LightGoldenrodYellow, Color.Goldenrod, "Advertencia", "No se encontró el número telefónico", Properties.Resources.Warning);
                            }
                        }
                    }

                    // Cerrar la conexión
                    conexion.Close();
                }
            }
            else
            {
                RellenarGrid();
            }
        }


        /* Volver a la página anterior */

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio(_configuration);
            inicio.Show();
            this.Close();
        }

        /* Ejecutar la función para buscar el número telefónico */

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarTelefono();
        }
    }
}
