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
    public partial class Profesor : Form
    {
        public Profesor()
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

        private void Profesor_Load(object sender, EventArgs e)
        {
            cargar.DgvProfesor(dgv);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Menu form = new Menu();
            this.Hide();
            form.Show();
        }
    }
}
