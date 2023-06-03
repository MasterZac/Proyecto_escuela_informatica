using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proyecto_escuela_informatica
{
    public partial class Cargar_archivo : Form
    {
        public Cargar_archivo()
        {
            InitializeComponent();
        }
        ConexionDB conexionDB = new ConexionDB(GlobalVariables.Usuario, GlobalVariables.Contraseña);
        SqlConnection conexion = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da;
        SqlDataReader dr;
        DataTable dt;

        private void Cargar_archivo_Load(object sender, EventArgs e)
        {

        }

        private void BtnCargar_Click(object sender, EventArgs e)
        {
            string filePath = txtRuta.Text;

            if (string.IsNullOrWhiteSpace(filePath))
            {
                MessageBox.Show("Por favor, ingresa una ruta de archivo válida.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                return;
            }

            try
            {
                DataTable csvData = GetDataTableFromCSV(filePath);
                dgvCargar.DataSource = csvData;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el archivo CSV: " + ex.Message);
            }
        }

        private DataTable GetDataTableFromCSV(string filePath)
        {
            DataTable csvDataTable = new DataTable();

            using (StreamReader sr = new StreamReader(filePath))
            {
                string[] headers = sr.ReadLine().Split(',');
                foreach (string header in headers)
                {
                    csvDataTable.Columns.Add(header);
                }

                while (!sr.EndOfStream)
                {
                    string[] rows = sr.ReadLine().Split(',');
                    DataRow dataRow = csvDataTable.NewRow();
                    for (int i = 0; i < headers.Length; i++)
                    {
                        dataRow[i] = rows[i];
                    }
                    csvDataTable.Rows.Add(dataRow);
                }
            }

            return csvDataTable;
        }

        private void InsertDatos()
        {
            bool aux = false;
            int filas_afectadas = 0;
            try
            {
                DataTable dataTable = (DataTable)dgvCargar.DataSource;
                DataTable existingData = ConsultaExistencia();
                conexion = conexionDB.AbrirConexion();

                foreach (DataRow row in dataTable.Rows)
                {
                    string numeroTribunal = row["Numero_tribunal"].ToString();
                    string lugarExamen = row["Lugar_examen"].ToString();
                    int numeroComponentes = Convert.ToInt32(row["Numero_componentes"]);
                    string Estatus = row["Estatus"].ToString();

                    // Verificar si los datos ya existen en la tabla de SQL Server
                    DataRow[] existingRows = existingData.Select($"Numero_tribunal = '{numeroTribunal}'");
                    if (existingRows.Length == 0)
                    {
                        // Los datos no existen, insertar en la tabla
                        
                        cmd.Connection = conexion;
                        cmd.CommandText = "INSERT INTO Tribunal (Numero_tribunal, Lugar_examen, Numero_componentes, Estatus) VALUES (@Numero_tribunal, @Lugar_examen, @Numero_componentes, @Estatus)";
                        cmd.Parameters.AddWithValue("@Numero_tribunal", numeroTribunal);
                        cmd.Parameters.AddWithValue("@Lugar_examen", lugarExamen);
                        cmd.Parameters.AddWithValue("@Numero_componentes", numeroComponentes);
                        cmd.Parameters.AddWithValue("@Estatus", Estatus);
                        filas_afectadas = cmd.ExecuteNonQuery();
                        if (filas_afectadas  > 0)
                        {
                            aux = true;
                        }
                    }
                    else
                    {
                        int rowIndex = dataTable.Rows.IndexOf(row);
                        MessageBox.Show($"La fila {rowIndex + 1} del DataGridView ya existe en la tabla de la base de datos.");
                    }
                }
                if (aux == true)
                {
                    MessageBox.Show("Se insertaron " + filas_afectadas +" filas");
                }
                else
                {
                    MessageBox.Show("No se realizo ninguna inserción");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexionDB.CerrarConexion(conexion);
            }
        }


        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.ShowDialog();
            txtRuta.Text = dlg.FileName;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            Tribunal form = new Tribunal();
            this.Hide();
            form.Show();

        }

        public DataTable ConsultaExistencia()
        {
            conexion = conexionDB.AbrirConexion();
            cmd = new SqlCommand("SELECT * FROM Tribunal", conexion);
            cmd.CommandType = CommandType.Text;
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            conexionDB.CerrarConexion(conexion);
            return dt;
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                InsertDatos();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar los datos en SQL Server: " + ex.Message);
            }
            
        }
    }
}
