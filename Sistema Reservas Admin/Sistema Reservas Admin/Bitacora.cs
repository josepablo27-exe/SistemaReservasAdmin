using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using OfficeOpenXml;
using Microsoft.Extensions.Configuration;

namespace Sistema_Reservas_Admin
{
    public partial class Bitacora : Form
    {
        private readonly IConfiguration _configuration;

        public Bitacora(IConfiguration configuration)
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

        private void Bitacora_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            int ancho_pantalla = Screen.PrimaryScreen.WorkingArea.Width;
            int alto_pantalla = Screen.PrimaryScreen.WorkingArea.Height;

            // COMPONENTES DE LA PANTALLA: 

            /* Inicio Panel 1 */

            int ancho_panel1 = (int)Math.Round(ancho_pantalla * 0.88); 
            int alto_panel1 = (int)Math.Round(alto_pantalla * 0.93); 
            panel1.Size = new Size(ancho_panel1, alto_panel1);
            int x_panel1 = (ancho_pantalla - ancho_panel1) / 2;
            int y_panel1 = (alto_pantalla - alto_panel1) / 2;
            panel1.Location = new Point(x_panel1, y_panel1);

            /* Fin Panel 1 */

            /* Inicio lblBitacora */

            lblBitacora.TextAlign = ContentAlignment.MiddleCenter;
            lblBitacora.Font = new Font(lblBitacora.Font.FontFamily, 34, FontStyle.Regular);
            int x_lblBitacora = (ancho_panel1 - lblBitacora.Size.Width) / 2;
            lblBitacora.Location = new Point(x_lblBitacora, 10);

            /* Fin lblBitacora */

            /* Inicio btnAgregar */

            Color colorbtnAgregar = ColorTranslator.FromHtml("#ED4F49");
            btnAgregar.BackColor = colorbtnAgregar;
            btnAgregar.Size = new Size(250, 50);
            btnAgregar.Location = new Point(225, 125);
            btnAgregar.Font = new Font(btnAgregar.Font.FontFamily, 22, FontStyle.Regular);

            /* Fin btnAgregar */

            /* Inicio btnExportar */

            Color colorbtnExportar = ColorTranslator.FromHtml("#009629");
            btnExportar.BackColor = colorbtnExportar;
            int ancho_btnExportar = 250;
            btnExportar.Size = new Size(ancho_btnExportar, 50);
            int x_btnExportar = ancho_panel1 - ancho_btnExportar - 250;
            btnExportar.Location = new Point(x_btnExportar, 125);
            btnExportar.Font = new Font(btnExportar.Font.FontFamily, 22, FontStyle.Regular);
            btnExportar.Padding = new Padding(0, 0, 20, 0);

            /* Fin btnExportar */

            /* Inicio tablaBitacora */

            int ancho_tablaBitacora = 1308;
            tablaBitacora.Size = new Size(ancho_tablaBitacora, 530);

            // Llenar la tablaBitacora con los datos dentro de la BD
            RellenarGrid();

            // Verificar si las columnas existen y definirles un ancho
            if (tablaBitacora.Columns.Count > 0)
            {
                tablaBitacora.Columns[0].Width = 50;
                tablaBitacora.Columns[1].Width = 500;
                tablaBitacora.Columns[2].Width = 230;
                tablaBitacora.Columns[3].Width = 230;
                tablaBitacora.Columns[4].Width = 230;
            }
            int x_tablaBitacora = (ancho_panel1 - ancho_tablaBitacora) / 2;
            tablaBitacora.Location = new Point(x_tablaBitacora, 230);

            // Verificar si las columnas existen y definirlas como solo lectura
            if (tablaBitacora.Columns.Contains("ID"))
            {
                tablaBitacora.Columns["ID"].ReadOnly = true;
            }
            if (tablaBitacora.Columns.Contains("Salón Principal"))
            {
                tablaBitacora.Columns["Salón Principal"].ReadOnly = true;
            }
            if (tablaBitacora.Columns.Contains("Transmisión en vivo"))
            {
                tablaBitacora.Columns["Transmisión en vivo"].ReadOnly = true;
            }
            if (tablaBitacora.Columns.Contains("Total"))
            {
                tablaBitacora.Columns["Total"].ReadOnly = true;
            }

            /* Fin tablaBitacora */
        }

        // FUNCIONES:

        /* Llenar la tablaBitacora con los datos dentro de la BD */

        public void RellenarGrid()
        {
            string connectionString = _configuration.GetConnectionString("DefaultConnection");

            using (MySqlConnection conexion = new MySqlConnection(connectionString))
            {
                // Consulta para obtener los datos de la tabla en la base de datos
                string consulta = "SELECT ID_REGISTRO AS \"ID\", TITULO AS \"Título\", SALON_PRINCIPAL AS \"Salón Principal\", TRANSMISION AS \"Transmisión en vivo\", TOTAL AS \"Total\" FROM BITACORA";

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
                    tablaBitacora.DataSource = tabla;
                }
            }
        }

        /* Exportar la tablaBitacora dentro de la base de datos a Excel */
        public void ExportarBitacora()
        {
            string connectionString = _configuration.GetConnectionString("DefaultConnection");

            // Consulta SQL para seleccionar los datos de la tabla BITACORA
            string consulta = "SELECT ID_REGISTRO AS ID, TITULO AS Título, SALON_PRINCIPAL AS 'Salón Principal', TRANSMISION AS 'Transmisión en vivo', TOTAL FROM BITACORA";

            // Crear un objeto DataTable para almacenar los datos de la tabla BITACORA
            DataTable tablaBitacora = new DataTable();

            // Establecer la conexión a la base de datos y ejecutar la consulta
            using (MySqlConnection conexion = new MySqlConnection(connectionString))
            {
                using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                {
                    conexion.Open();
                    using (MySqlDataReader reader = comando.ExecuteReader())
                    {
                        // Cargar los datos del lector en el DataTable
                        tablaBitacora.Load(reader);
                    }
                }
            }

            // Crear un cuadro de diálogo para seleccionar la carpeta de destino
            using (FolderBrowserDialog dialogoCarpeta = new FolderBrowserDialog())
            {
                dialogoCarpeta.Description = "Seleccione la carpeta donde desea guardar el archivo Excel";

                if (dialogoCarpeta.ShowDialog() == DialogResult.OK)
                {
                    // Obtener la carpeta seleccionada por el usuario
                    string carpetaDestino = dialogoCarpeta.SelectedPath;

                    // Crear la ruta completa del archivo de Excel
                    string rutaArchivo = Path.Combine(carpetaDestino, "bitacora.xlsx");

                    // Crear el archivo Excel utilizando EPPlus
                    using (ExcelPackage package = new ExcelPackage(new FileInfo(rutaArchivo)))
                    {
                        // Crear una nueva hoja de trabajo en el archivo Excel
                        ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Bitacora");

                        // Llenar la hoja de trabajo con los datos de la tabla BITACORA
                        worksheet.Cells.LoadFromDataTable(tablaBitacora, true);

                        // Guardar el archivo Excel
                        package.Save();
                    }

                    MessageBox.Show("El archivo Excel se ha guardado correctamente en: " + rutaArchivo);
                }
            }
        }

        /* Evento cuando se borra una fila */

        private void tablaBitacora_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            // Obtener el valor de la clave primaria de la fila que se está eliminando
            int idFilaEliminar = Convert.ToInt32(e.Row.Cells["ID"].Value);

            string connectionString = _configuration.GetConnectionString("DefaultConnection");

            // Ejecutar una consulta SQL para eliminar la fila correspondiente en la tabla de la base de datos
            string consulta = "DELETE FROM BITACORA WHERE ID_REGISTRO = @Id";

            using (MySqlConnection conexion = new MySqlConnection(connectionString))
            {
                using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@Id", idFilaEliminar);
                    try
                    {
                        conexion.Open();
                        comando.ExecuteNonQuery();
                    }
                    catch (MySqlException)
                    {
                        CuadroAlerta(Color.LightPink, Color.DarkRed, "Error", "Ocurrió un error de conexión con la base de datos", Properties.Resources.Error);
                        e.Cancel = true; // Cancelar el evento de eliminación si ocurre un error
                    }
                }
            }
        }

        /* Evento cuando se modifica un valor */

        private void tablaBitacora_CellValueChanged_1(object sender, DataGridViewCellEventArgs e)
        {
            // Obtener el valor modificado y la fila modificada
            DataGridViewRow filaModificada = tablaBitacora.Rows[e.RowIndex];
            string nuevoValor = filaModificada.Cells[e.ColumnIndex].Value.ToString();

            // Obtener el valor de la clave primaria de la fila modificada
            int idFilaModificar = Convert.ToInt32(filaModificada.Cells["ID"].Value);

            string columnaModificar = "";

            if (e.ColumnIndex == 1)
            {
                columnaModificar = "TITULO";
            }
            else if (e.ColumnIndex == 2)
            {
                columnaModificar = "SALON_PRINCIPAL";
            }
            else if (e.ColumnIndex == 3)
            {
                columnaModificar = "TRANSMISION";
            }
            else if (e.ColumnIndex == 4)
            {
                columnaModificar = "TOTAL";
            }

            string connectionString = _configuration.GetConnectionString("DefaultConnection");

            // Ejecutar una consulta SQL para actualizar la fila correspondiente en la tabla de la base de datos
            string consulta = "UPDATE BITACORA SET " + columnaModificar + " = @NuevoValor WHERE ID_REGISTRO = @Id";

            using (MySqlConnection conexion = new MySqlConnection(connectionString))
            {
                using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@NuevoValor", nuevoValor);
                    comando.Parameters.AddWithValue("@Id", idFilaModificar);
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
            RellenarGrid();
        }

        /* Volver a la página anterior */

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio(_configuration);
            inicio.Show();
            this.Close();
        }

        /* Abrir el formulario para agreagar un registro */

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            TituloBitacora tituloBitacora = new TituloBitacora(_configuration);
            tituloBitacora.Show();
            this.Close();
        }

        /* Ejecutar la función de exportar a Excel */

        private void btnExportar_Click(object sender, EventArgs e)
        {
            ExportarBitacora();
        }
    }
}
