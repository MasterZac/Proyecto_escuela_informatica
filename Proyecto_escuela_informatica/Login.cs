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
            bool VerifyConection = true;

            string servidor = "DESKTOP-T35PUJQ\\SQLEXPRESS";
            string bd = "Escuela_informatica";
            string usuario = TxtUsuario.Text;
            string password = TxtConstraseña.Text;
            string cadenaConexion = "data source = " + servidor + ";" + " initial catalog = " + bd + ";" + " user id = " + usuario + ";" + " password = " + password + ";";
            conexion.ConnectionString = cadenaConexion;
            GlobalVariables.Usuario = TxtUsuario.Text;
            GlobalVariables.Contraseña = TxtConstraseña.Text;

            try
            {
                conexion.Open();
                VerifyConection = true;
                MessageBox.Show("Usuario conectado");
            }
            catch (Exception)
            {
                MessageBox.Show("Usuario o contraseña incorrecta!");
                VerifyConection=false;
            }
            finally
            {
                conexion.Close();
            }

            if (VerifyConection == true)
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
