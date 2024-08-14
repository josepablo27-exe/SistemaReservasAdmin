using Sistema_Reservas.Botones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Threading;
using Microsoft.Extensions.Configuration;

namespace Sistema_Reservas_Admin
{
    public partial class SalonPrincipal : Form
    {
        private readonly IConfiguration _configuration;

        public SalonPrincipal(IConfiguration configuration)
        {
            InitializeComponent();
            Escenario.Paint += Escenario_Paint;
            foreach (var panel in GetAllPanels(this).Where(p => p.Name != "panel1" && p.Name != "panel2"))
            {
                panel.Click += Panel_Click;
            }
            _configuration = configuration;
        }

        // Función para obtener todos los paneles
        private IEnumerable<Panel> GetAllPanels(Control control)
        {
            var panels = control.Controls.OfType<Panel>();
            return panels.SelectMany(GetAllPanels).Concat(panels);
        }

        // Colores para los paneles
        Color colorCoches = ColorTranslator.FromHtml("#CD0000");
        Color colorAC = ColorTranslator.FromHtml("#003CFF");

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

        PantallaCarga pantallaCarga;

        private async void SalonPrincipal_Load(object sender, EventArgs e)
        {
            // Muestra la pantalla de carga
            pantallaCarga = new PantallaCarga();
            pantallaCarga.Show();

            // Cargar y configurar el formulario principal en un hilo separado
            await Task.Run(() => CargarFormulario());

            // Oculta la pantalla de carga
            pantallaCarga.Close();
        }

        private void CargarFormulario()
        {
            this.Invoke((MethodInvoker)delegate
            {
                this.WindowState = FormWindowState.Maximized;

                int ancho_pantalla = Screen.PrimaryScreen.WorkingArea.Width;
                int alto_pantalla = Screen.PrimaryScreen.WorkingArea.Height;

                /* Inicio Panel 2 */

                int ancho_panel2 = (int)Math.Round(ancho_pantalla * 0.12);
                int alto_panel2 = (int)Math.Round(alto_pantalla * 0.83);
                panel2.Size = new Size(ancho_panel2, alto_panel2);
                int x_panel2 = 20;
                int y_panel2 = (int)Math.Round(alto_pantalla * 0.12);
                panel2.Location = new Point(x_panel2, y_panel2);

                /* Fin Panel 2 */

                /* Inicio Panel 1 */

                int px_panel1 = ancho_panel2 + x_panel2;
                int ancho_panel1 = (int)Math.Round(ancho_pantalla * 0.85);
                int alto_panel1 = (int)Math.Round(alto_pantalla * 0.83);
                panel1.Size = new Size(ancho_panel1, alto_panel1);
                int x_panel1 = ((ancho_pantalla - px_panel1) - ancho_panel1) / 2 + px_panel1;
                int y_panel1 = y_panel2;
                panel1.Location = new Point(x_panel1, y_panel1);

                /* Fin Panel 1 */

                /* Inicio lblSalon */

                lblSalon.TextAlign = ContentAlignment.MiddleCenter;
                lblSalon.Font = new Font(lblSalon.Font.FontFamily, 34, FontStyle.Regular);
                int x_lblSalon = (ancho_pantalla - lblSalon.Size.Width) / 2;
                lblSalon.Location = new Point(x_lblSalon, 20);

                /* Fin lblSalon */

                /* Inicio pnlDisponible */

                pnlDisponible.Location = new Point(20, 50);
                pnlDisponible.BorderRadius = 7;

                /* Fin pnlDisponible */

                /* Inicio lblDisponible */

                lblDisponible.AutoSize = false; ;
                lblDisponible.Size = new Size(110, 30);
                lblDisponible.Font = new Font(lblDisponible.Font.FontFamily, 14, FontStyle.Regular);
                lblDisponible.Location = new Point(60, 55);

                /* Fin lblDisponible */

                /* Inicio pnlReservado */

                pnlInhabilitado.Location = new Point(20, 150);
                pnlInhabilitado.BorderRadius = 7;

                /* Fin pnlReservado */

                /* Inicio lblInhabilitado */

                lblInhabilitado.AutoSize = false;
                lblInhabilitado.Size = new Size(115, 30);
                lblInhabilitado.Font = new Font(lblInhabilitado.Font.FontFamily, 13, FontStyle.Regular);
                lblInhabilitado.Location = new Point(60, 155);

                /* Fin lblInhabilitado */

                /* Inicio pnlAC */

                pnlAC.Location = new Point(20, 250);
                pnlAC.BorderRadius = 7;

                /* Fin pnlAC */

                /* Inicio lblAC */

                lblAC.AutoSize = false;
                lblAC.Size = new Size(45, 30);
                lblAC.Font = new Font(lblAC.Font.FontFamily, 14, FontStyle.Regular);
                lblAC.Location = new Point(60, 255);

                /* Fin lblAC */

                /* Inicio pnlCoches */

                pnlCoches.Location = new Point(20, 350);
                pnlCoches.BorderRadius = 7;

                /* Fin pnlAC */

                /* Inicio lblCoches */

                lblCoches.AutoSize = false;
                lblCoches.Size = new Size(75, 30);
                lblCoches.Font = new Font(lblCoches.Font.FontFamily, 14, FontStyle.Regular);
                lblCoches.Location = new Point(60, 355);

                /* Fin lblCoches */

                /* Inicio Escenario */

                Escenario.AutoSize = false;
                Escenario.TextAlign = ContentAlignment.MiddleCenter;
                Escenario.Size = new Size(600, 150);
                Escenario.Font = new Font(lblSalon.Font.FontFamily, 30, FontStyle.Bold);
                Escenario.Location = new Point(330, 5);

                /* Fin Escenario */

                Asignacion();
            }
            );
        }

        // FUNCIONES:

        /* Establecer bordes al Escenario */

        private void Escenario_Paint(object sender, PaintEventArgs e)
        {
            // Obtener el control Label
            System.Windows.Forms.Label label = sender as System.Windows.Forms.Label;

            // Dibujar un borde adicional alrededor del control Label
            ControlPaint.DrawBorder(e.Graphics, label.ClientRectangle,
                                    Color.Black, 4, ButtonBorderStyle.Solid,
                                    Color.Black, 4, ButtonBorderStyle.Solid,
                                    Color.Black, 4, ButtonBorderStyle.Solid,
                                    Color.Black, 4, ButtonBorderStyle.Solid);
        }

        /* Asignar la categoría del asiento a los paneles */
        private void Asignacion()
        {
            string connectionString = _configuration.GetConnectionString("DefaultConnection");

            string consulta = "SELECT ID_ASIENTO, CATEGORIA, RESERVADO, ASIENTO FROM asientos_salon";

            using (MySqlConnection conexion = new MySqlConnection(connectionString))
            {
                try
                {
                    MySqlCommand comando = new MySqlCommand(consulta, conexion);
                    conexion.Open();

                    using (MySqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int idAsiento = reader.GetInt32(0);
                            string categoria = reader.GetString(1);
                            bool reservado = reader.GetBoolean(2);
                            string asiento = "";
                            if (!reader.IsDBNull(3))
                            {
                                asiento = reader.GetString(3);
                            }


                            // Busca el panel correspondiente según el ID de asiento y asigna los datos
                            PanelInicio panelAsiento = FindPanelInicioById(idAsiento, this.Controls);
                            if (panelAsiento != null)
                            {
                                panelAsiento.Asiento = asiento; // Asigna el número de asiento al panel

                                if (categoria.Equals("Inhabilitado"))
                                {
                                    panelAsiento.BackColor = Color.Gray;
                                    panelAsiento.BorderColor = Color.Black;
                                    panelAsiento.BorderRadius = 7;
                                    panelAsiento.Cursor = Cursors.Hand;
                                }
                                else if (categoria.Equals("Disponible"))
                                {
                                    panelAsiento.BackColor = Color.White;
                                    panelAsiento.BorderColor = Color.Black;
                                    panelAsiento.BorderRadius = 7;
                                    panelAsiento.Cursor = Cursors.Hand;
                                }
                                else if (categoria.Equals("Coches"))
                                {
                                    panelAsiento.BorderColor = colorCoches;
                                    panelAsiento.BorderRadius = 7;
                                    panelAsiento.Cursor = Cursors.Hand;
                                    panelAsiento.BackColor = Color.White;
                                }
                                else if (categoria.Equals("A/C"))
                                {
                                    panelAsiento.BorderColor = colorAC;
                                    panelAsiento.BorderRadius = 7;
                                    panelAsiento.Cursor = Cursors.Hand;
                                    panelAsiento.BackColor = Color.White;
                                }
                            }
                        }
                    }
                }
                catch (MySqlException)
                {
                    CuadroAlerta(Color.LightPink, Color.DarkRed, "Error", "Ocurrió un error de conexión con la base de datos", Properties.Resources.Error);
                }

            }
        }

        /* Buscar el panel por su tag */
        private PanelInicio FindPanelInicioById(int idAsiento, Control.ControlCollection controls)
        {
            // Recorrer todos los controles en la colección
            foreach (Control control in controls)
            {
                // Verificar si el control es un PanelInicio y si su Tag es igual al ID de asiento
                if (control is PanelInicio panelInicio && panelInicio.Tag != null && int.Parse((string)panelInicio.Tag) == idAsiento)
                {
                    // Si se encuentra un panelInicio con el ID de asiento especificado, devolverlo
                    return panelInicio;
                }

                // Si el control tiene controles secundarios, realizar una búsqueda recursiva en ellos
                if (control.HasChildren)
                {
                    PanelInicio panelEncontrado = FindPanelInicioById(idAsiento, control.Controls);
                    if (panelEncontrado != null)
                    {
                        return panelEncontrado;
                    }
                }
            }
            // Si no se encuentra ningún panelInicio con el ID de asiento especificado, devolver null
            return null;
        }

        /* Verificar la categoria dentro de la base de datos */
        private string VerificarCategoria(int id)
        {
            string connectionString = _configuration.GetConnectionString("DefaultConnection");
            string categoria = "";
            string consulta = "SELECT CATEGORIA FROM asientos_salon WHERE ID_ASIENTO = @idAsiento";

            using (MySqlConnection conexion = new MySqlConnection(connectionString))
            {
                using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@idAsiento", id);

                    try
                    {
                        conexion.Open();
                        object resultado = comando.ExecuteScalar();
                        if (resultado != null)
                        {
                            categoria = resultado.ToString();
                        }
                    }
                    catch (MySqlException)
                    {
                        CuadroAlerta(Color.LightPink, Color.DarkRed, "Error", "Ocurrió un error de conexión con la base de datos", Properties.Resources.Error);
                    }
                }
            }

            return categoria;
        }

        /* Inhabilitar un asiento dentro de la base de datos */
        private void Inhabilitar(int id)
        {
            string connectionString = _configuration.GetConnectionString("DefaultConnection");
            string consulta = "UPDATE asientos_salon SET CATEGORIA = \"Inhabilitado\", RESERVADO = false, ASIENTO = null WHERE ID_ASIENTO = @idAsiento";

            using (MySqlConnection conexion = new MySqlConnection(connectionString))
            {
                using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@idAsiento", id);

                    try
                    {
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

        /* Volver a la página anterior */

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio(_configuration);
            inicio.Show();
            this.Close();
        }

        /* Inhabilitar o habilitar un asiento (según su categoría) */

        private void Panel_Click(object sender, EventArgs e)
        {
            PanelInicio panel = (PanelInicio)sender;
            int id = int.Parse((string)panel.Tag);
            string categoria = VerificarCategoria(id);
            if (categoria.Equals("Inhabilitado"))
            {
                Categorias categorias = new Categorias(id, _configuration);
                categorias.Show();
                this.Close();
            }
            else
            {
                panel.BackColor = Color.Gray;
                panel.BorderColor = Color.Black;
                Inhabilitar(id);
            }
        }
    }
}
