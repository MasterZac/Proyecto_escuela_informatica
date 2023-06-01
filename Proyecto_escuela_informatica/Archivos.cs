using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proyecto_escuela_informatica
{
    public partial class Archivos : Form
    {
        public Archivos()
        {
            InitializeComponent();
        }

        ConexionDB conexionDB = new ConexionDB(GlobalVariables.Usuario, GlobalVariables.Contraseña);
        CargarDatos cargar = new CargarDatos();
        SqlConnection conexion = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da;
        SqlDataReader dr;
        DataTable dt;

        private void BtnAbrir_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog() 
            { Filter = "Archivo CSV|*.csv"};
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                txtRuta.Text = sfd.FileName;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Tribunal form = new Tribunal();
            this.Hide();
            form.Show();
        }

        private void BtnExportar_Click(object sender, EventArgs e)
        {
            if (txtRuta.Text == "")
            {
                MessageBox.Show("Busca un lugar donde guardaras el archivo csv", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                conexion = conexionDB.AbrirConexion();
                string query = "Select * From Tribunal";
                da = new SqlDataAdapter(query, conexion);
                dt = new DataTable();
                da.Fill(dt);

                List<string> lineas = new List<string>(), columnas = new List<string>();
                foreach (DataColumn col in dt.Columns) columnas.Add(col.ColumnName);

                lineas.Add(string.Join(txtsep.Text, columnas));
                foreach (DataRow fila in dt.Rows)
                {
                    List<string> celdas = new List<string>();
                    foreach (object celda in fila.ItemArray) celdas.Add(celda.ToString());

                    lineas.Add(string.Join(txtsep.Text, celdas));
                }
                File.WriteAllLines(txtRuta.Text, lineas);
                MessageBox.Show("Tabla tribunal exportada a csv");
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

        private void BtnVerArchivo_Click(object sender, EventArgs e)
        {
            if (txtRuta.Text == "")
            {
                MessageBox.Show("Ingresa una ruta valida para guardar el archivo csv", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                System.Diagnostics.Process.Start(txtRuta.Text);
            }

        }

        private void Archivos_Load(object sender, EventArgs e)
        {

        }
    }
}
