using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;

namespace Proyecto_escuela_informatica
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        SqlConnection conexion = new SqlConnection();

        private void button1_Click(object sender, EventArgs e)
        {

            bool verifiConnection = true;
            string usuario = TxtUsuario.Text;
            string password = TxtConstraseña.Text;
            GlobalVariables.Usuario = usuario;
            GlobalVariables.Contraseña = password;
            ConexionDB conexionDB = new ConexionDB(usuario, password);
            try
            {
                SqlConnection conexion = conexionDB.AbrirConexion();
                MessageBox.Show("Datos correctos");
                verifiConnection = true;
            }
            catch (SqlException)
            {
                verifiConnection=false;
                MessageBox.Show("¡Usuario o contraseña incorrecta!");
                
            }
            finally
            {
                conexionDB.CerrarConexion(conexion);
            }

            if (verifiConnection == true)
            {
                Menu form = new Menu();
                this.Hide();
                form.Show();
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
