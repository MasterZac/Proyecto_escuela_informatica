using Microsoft.Data.SqlClient;
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

namespace Proyecto_escuela_informatica
{
    public partial class Grupo : Form
    {
        public Grupo()
        {
            InitializeComponent();
        }
        ConexionDB conexionDB = new ConexionDB(GlobalVariables.Usuario, GlobalVariables.Contraseña);
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
       


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Grupo_Load(object sender, EventArgs e)
        {

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Menu form = new Menu();
            this.Hide();
            form.Show();
        }

        public bool ValidarCampos()
        {
            bool aux = false;
            if (TxtNumeroGrupo.Text == "" || txtNombre.Text == "" || txtNumeroComponentes.Value == 0 || cboEstatus.Text == "")
            {
                aux = true;
            }
            return aux;
        }

        public bool ConsultarExistencia()
        {
            
            bool aux = false;
            SqlConnection conexion = conexionDB.AbrirConexion();


            try
            {
                string query = "Select * From Grupo Where Numero_grupo = ('" + TxtNumeroGrupo.Text + "') ";
                cmd = new SqlCommand(query, conexion);
                cmd.CommandType = CommandType.Text;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    aux = true;
                }

            }
            catch
            {

            }
            finally
            {

            }
            return aux;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                MessageBox.Show("Los campos estan vacios", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

        }
    }
}
