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
    public partial class Se_conforma : Form
    {
        public Se_conforma()
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

        private void Se_conforma_Load(object sender, EventArgs e)
        {
            CargarDgvProfesor();
            CargarTribunal();
            CargarDgvSeConforma();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        public void CargarDgvSeConforma()
        {
            conexion = conexionDB.AbrirConexion();
            try
            {
                string query = "select Se_conforma.Numero_tribunal, tribunal.Lugar_examen, Se_conforma.CI_profesor, Profesor.Nombre from " +
                    "Se_conforma, tribunal, Profesor Where Se_conforma.Numero_tribunal = tribunal.Numero_tribunal and " +
                    "Se_conforma.CI_profesor = Profesor.CI";
                da = new SqlDataAdapter(query, conexion);
                dt = new DataTable();
                da.Fill(dt);
                dgvRegistros.DataSource = dt;
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

        public void CargarDgvProfesor()
        {
            conexion = conexionDB.AbrirConexion();
            try
            {
                string query = "Select CI, Nombre, Domicilio From Profesor Where Estatus = 'Activo'";
                da = new SqlDataAdapter(query, conexion);
                dt = new DataTable();
                da.Fill(dt);
                dgvProfesor.DataSource = dt;
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

        public void ConsultasTribunal()
        {
            try
            {
                conexion = conexionDB.AbrirConexion();
                string query = "Select Numero_tribunal, Lugar_examen, Numero_componentes From Tribunal Where (" + cboTribunal.Text + ") Like ('%" + txtBuscarTribunal.Text + "%') and Estatus = 'Activo'";
                da = new SqlDataAdapter(query, conexion);
                dt = new DataTable();
                da.Fill(dt);
                dgvTribunal.DataSource = dt;
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

        public void ConsultasProfesor()
        {
            try
            {
                conexion = conexionDB.AbrirConexion();
                string query = "Select CI, Nombre, Domicilio From Profesor Where (" + cboProfesor.Text + ") like ('%" + txtBuscarProfesor.Text + "%') and Estatus = 'Activo'";
                da = new SqlDataAdapter(query, conexion);
                dt = new DataTable();
                da.Fill(dt);
                dgvProfesor.DataSource = dt;
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

        public void CargarTribunal()
        {
            try
            {
                conexion = conexionDB.AbrirConexion();
                string query = "select Numero_tribunal, Lugar_examen, Numero_componentes from tribunal Where Estatus = 'Activo'";
                da = new SqlDataAdapter(query, conexion);
                dt = new DataTable();
                da.Fill(dt);
                dgvTribunal.DataSource = dt;
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

        private void consultaDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabControl1.Visible == false)
            {
                tabControl1.Visible = true;
            }
            else
            {
                tabControl1.Visible = false;
            }
        }

        public void NuevoTribunal()
        {
            txtNumeroTribunal.Clear();
            txtLugarExamen.Clear();
            txtNumeroComponentes.Value = 0;
        }

        public void NuevoProfesor()
        {
            txtCI.Clear();
            txtNombre.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Menu form = new Menu();
            this.Hide();
            form.Show();
        }

        private void BtnSeleccion1_Click(object sender, EventArgs e)
        {
            if (dgvTribunal.SelectedRows.Count > 0)
            {
                txtNumeroTribunal.Text = dgvTribunal.SelectedCells[0].Value.ToString();
                txtLugarExamen.Text = dgvTribunal.SelectedCells[1].Value.ToString();
                txtNumeroComponentes.Value = Convert.ToInt32(dgvTribunal.SelectedCells[2].Value.ToString());
                dgvTribunal.ClearSelection();
                MessageBox.Show("Tribunal seleccionado");
            }
        }

        private void btnSelecciona2_Click(object sender, EventArgs e)
        {
            if (dgvProfesor.SelectedRows.Count > 0)
            {
                txtCI.Text = dgvProfesor.SelectedCells[0].Value.ToString();
                txtNombre.Text = dgvProfesor.SelectedCells[1].Value.ToString();
                dgvProfesor.ClearSelection();
                MessageBox.Show("Profesor seleccoionado");
            }
        }

        public bool ValidaCampos()
        {
            bool aux = false;
            if (txtNumeroTribunal.Text == "" || txtLugarExamen.Text == "" || txtNumeroComponentes.Value == 0
                || txtCI.Text == "" || txtNombre.Text == "")
            {
                aux = true;
            }
            return aux;
        }

        public bool ConsultarExistencia()
        {
            bool aux = false;
            try
            {
                conexion = conexionDB.AbrirConexion();
                string query = "Select * From Se_conforma Where Numero_tribunal = ('" + txtNumeroTribunal.Text + "') and CI_profesor = ('" + txtCI.Text + "')";
                cmd = new SqlCommand(query, conexion);
                cmd.CommandType = CommandType.Text;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    aux = true;
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
            return aux;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidaCampos())
            {
                MessageBox.Show("Existen campos vacios", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (ConsultarExistencia())
            {
                MessageBox.Show("Ese profesor ya es parte del tribunal seleccionado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                try
                {
                    conexion = conexionDB.AbrirConexion();
                    cmd = new SqlCommand("AddSeConforma", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter Numero_tribunal = new SqlParameter("@Numero_tribunal", SqlDbType.Char, 5);
                    Numero_tribunal.Value = txtNumeroTribunal.Text;
                    cmd.Parameters.Add(Numero_tribunal);

                    SqlParameter CI_profesor = new SqlParameter("@CI_profesor", SqlDbType.VarChar, 5);
                    CI_profesor.Value = txtCI.Text;
                    cmd.Parameters.Add(CI_profesor);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registro exitoso: el profesor" + txtNombre.Text + " ahora pertenece al tribunal con el numero de orden: " + txtNumeroTribunal.Text);
                    NuevoTribunal();
                    NuevoProfesor();
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
        }

        private void btnNuevo1_Click(object sender, EventArgs e)
        {
            NuevoTribunal();
        }

        private void btnNuevo2_Click(object sender, EventArgs e)
        {
            NuevoProfesor();
        }

        private void txtBuscarTribunal_KeyUp(object sender, KeyEventArgs e)
        {
            if (cboTribunal.SelectedIndex == -1)
            {
                MessageBox.Show("Elige porque tipo de datos quieres consultar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBuscarTribunal.Clear();
            }
            else
            {
                ConsultasTribunal();
            }

        }

        private void txtBuscarProfesor_KeyUp(object sender, KeyEventArgs e)
        {
            if (cboProfesor.SelectedIndex == -1)
            {
                MessageBox.Show("Elige porque tipo de dato quieres consultar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBuscarProfesor.Clear();
            }
            else
            {
                ConsultasProfesor();
            }
        }
    }
}
