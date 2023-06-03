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

namespace Proyecto_escuela_informatica
{
    public partial class Respaldos_Restauraciones : Form
    {
        public Respaldos_Restauraciones()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Menu form = new Menu();
            this.Hide();
            form.Show();
        }
        private void btnBuscar1_Click(object sender, EventArgs e)
        {

        }

        ConexionDB conexionDB = new ConexionDB(GlobalVariables.Usuario, GlobalVariables.Contraseña);
        SqlConnection conexion = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        private void button2_Click(object sender, EventArgs e)
        {
            string nombre_copia = (System.DateTime.Today.Day.ToString() + "-" + System.DateTime.Today.Month.ToString() + "-" + System.DateTime.Today.Year.ToString() + "-" + System.DateTime.Now.Hour.ToString() + "-" + System.DateTime.Now.Minute.ToString() + "-" + System.DateTime.Now.Second.ToString() + " Escuela_informatica.bak");

            string comando_consulta = "BACKUP DATABASE [Escuela_informatica] TO  DISK = N'C:\\Program Files\\Microsoft SQL Server\\MSSQL16.SQLEXPRESS\\MSSQL\\Backup\\ " + nombre_copia + " 'WITH NOFORMAT, NOINIT,  NAME = N'Escuela_informatica-Full Database Backup', SKIP, NOREWIND, NOUNLOAD,  STATS = 10";
            try
            {
                conexion = conexionDB.AbrirConexion();
                cmd = new SqlCommand(comando_consulta, conexion);
                cmd.ExecuteNonQuery();
                MessageBox.Show("La Copia se realizo con exito!!!!");
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

        private void btnBuscar2_Click(object sender, EventArgs e)
        {
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }
    }
}
