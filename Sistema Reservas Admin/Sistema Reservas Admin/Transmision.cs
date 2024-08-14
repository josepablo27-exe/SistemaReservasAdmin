using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using Sistema_Reservas.Botones;
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
    public partial class Transmision : Form
    {
        private readonly IConfiguration _configuration;

        public Transmision(IConfiguration configuration)
        {
            InitializeComponent();
            Pantalla.Paint += Pantalla_Paint;
            foreach (var panel in GetAllPanels(this).Where(p => p.Name != "panel1" && p.Name != "panel2" && p.Name != "panel3"))
            {
                panel.Click += Panel_Click;
            }
            _configuration = configuration;
        }

        // Conseguir todos los paneles
        private IEnumerable<Panel> GetAllPanels(Control control)
        {
            var panels = control.Controls.OfType<Panel>();
            return panels.SelectMany(GetAllPanels).Concat(panels);
        }

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

        private void Transmision_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            int ancho_pantalla = Screen.PrimaryScreen.WorkingArea.Width;
            int alto_pantalla = Screen.PrimaryScreen.WorkingArea.Height;

            /* Inicio Panel 1 */

            int ancho_panel1 = (int)Math.Round(ancho_pantalla * 0.30);
            int alto_panel1 = (int)Math.Round(alto_pantalla * 0.83);
            panel1.Size = new Size(ancho_panel1, alto_panel1);
            int x_panel1 = (ancho_pantalla - ancho_panel1) / 2;
            int y_panel1 = (int)Math.Round(alto_pantalla * 0.12);
            panel1.Location = new Point(x_panel1, y_panel1);

            /* Fin Panel 1 */

            /* Inicio Panel 2 */

            int ancho_panel2 = (int)Math.Round(ancho_pantalla * 0.15);
            int alto_panel2 = (int)Math.Round(alto_pantalla * 0.83);
            panel2.Size = new Size(ancho_panel2, alto_panel2);
            int x_panel2 = 20;
            int y_panel2 = (int)Math.Round(alto_pantalla * 0.12);
            panel2.Location = new Point(x_panel2, y_panel2);

            /* Fin Panel 2 */

            /* Inicio Panel 3 */

            int x_panel3 = (ancho_panel1 - panel3.Size.Width) / 2;
            int y_panel3 = (alto_panel1 - panel3.Size.Height) / 2;
            panel3.Location = new Point(x_panel3, y_panel3);

            /* Fin Panel 3 */

            /* Inicio lblTransmision */

            lblTransmision.TextAlign = ContentAlignment.MiddleCenter;
            lblTransmision.Font = new Font(lblTransmision.Font.FontFamily, 34, FontStyle.Regular); 
            int x_lblTransmision = (ancho_pantalla - lblTransmision.Size.Width) / 2;
            lblTransmision.Location = new Point(x_lblTransmision, 20);

            /* Fin lblTransmision */

            /* Inicio pnlDisponible */

            pnlDisponible.Location = new Point(20, 50);
            pnlDisponible.BorderRadius = 7;

            /* Fin pnlDisponible */

            /* Inicio lblDisponible */

            lblDisponible.Font = new Font(lblDisponible.Font.FontFamily, 18, FontStyle.Regular);
            lblDisponible.Location = new Point(60, 55);

            /* FinlblDisponible */

            /* Inicio pnlReservado */

            pnlReservado.Location = new Point(20, 150);
            pnlReservado.BorderRadius = 7;

            /* Fin pnlReservado */

            /* Inicio lblInhabilitado */

            lblInhabilitado.Font = new Font(lblInhabilitado.Font.FontFamily, 18, FontStyle.Regular);
            lblInhabilitado.Location = new Point(60, 155);

            /* Fin lblInhabilitado */


            /* Inicio Pantalla */

            int ancho_lblpantalla = 300;
            int alto_lblpantalla = 70;
            Pantalla.AutoSize = false;
            Pantalla.TextAlign = ContentAlignment.MiddleCenter;
            Pantalla.Size = new Size(ancho_lblpantalla, alto_lblpantalla); 
            Pantalla.Font = new Font(Pantalla.Font.FontFamily, 24, FontStyle.Bold); 
            int x_lblpantalla = (ancho_panel1 - ancho_lblpantalla) / 2;
            Pantalla.Location = new Point(x_lblpantalla, 20); 

            /* Fin Pantalla */

            Asignacion();
        }

        /* Definir bordes a la Pantalla */

        private void Pantalla_Paint(object sender, PaintEventArgs e)
        {
            // Obtener el control Label
            Label label = sender as Label;

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
            string consulta = "SELECT ID_ASIENTO, CATEGORIA, RESERVADO, ASIENTO FROM asientos_transmision";

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

                            panelAsiento.Asiento = asiento; // Asigna el número de asiento al panel

                            if (panelAsiento != null)
                            {
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
            string consulta = "SELECT CATEGORIA FROM asientos_transmision WHERE ID_ASIENTO = @idAsiento";

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
            string consulta = "UPDATE asientos_transmision SET CATEGORIA = \"Inhabilitado\", RESERVADO = false, ASIENTO = null WHERE ID_ASIENTO = @idAsiento";

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

        /* Inhabilitar o habilitar un asiento (según su categoría) */

        private void Panel_Click(object sender, EventArgs e)
        {
            PanelInicio panel = (PanelInicio)sender;
            int id = int.Parse((string)panel.Tag);
            string categoria = VerificarCategoria(id);
            if (categoria.Equals("Inhabilitado"))
            {
                NumeroAsientoTransmision numeroAsientoTransmision = new NumeroAsientoTransmision(id, _configuration);
                numeroAsientoTransmision.Show();
                this.Close();
            }
            else
            {
                panel.BackColor = Color.Gray;
                panel.BorderColor = Color.Black;
                Inhabilitar(id);
            }
        }

        /* Volver a la página anterior */

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio(_configuration);
            inicio.Show();
            this.Close();
        }
    }
}
