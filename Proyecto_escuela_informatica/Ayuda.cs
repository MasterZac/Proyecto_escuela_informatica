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
    public partial class Ayuda : Form
    {
        public Ayuda()
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

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void consultarDatosToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void dgvProfesor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Ayuda_Load(object sender, EventArgs e)
        {
            CargarDgvAlumno();
            CargarDgvProfesor();
            CargarRegistros();
        }

        public void CargarRegistros()
        {
            conexion = conexionDB.AbrirConexion();
            try
            {
                string query = "Select Ayuda.CI_profesor, Profesor.Nombre, Ayuda.Matricula_alumno, Alumno.Nombre, TFC.Numero_orden,TFC.Tema  From " +
                    "TFC, Ayuda, Alumno, Profesor Where Ayuda.Matricula_alumno = Alumno.Matricula and " +
                    "Ayuda.CI_profesor = Profesor.CI and Alumno.Numero_orden_tfc = TFC.Numero_orden";
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

        public void CargarDgvAlumno()
        {
            conexion = conexionDB.AbrirConexion();
            try
            {
                string query = "select Alumno.Matricula, Alumno.Nombre, Grupo.Nombre  as 'Grupo al que pertence',Profesor.Nombre " +
                    "as 'Profesor que lo dirige' , TFC.Numero_orden, TFC.Tema From Grupo, Profesor, Alumno, TFC " +
                    "Where Alumno.Numero_grupo = Grupo.Numero_grupo and Alumno.CI_profesor = Profesor.CI and " +
                    "Alumno.Numero_orden_tfc = TFC.Numero_orden and Alumno.Estatus = 'Activo'";
                da = new SqlDataAdapter(query, conexion);
                dt = new DataTable();
                da.Fill(dt);
                dgvAlumno.DataSource = dt;
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

        public bool ConsultarAyuda()
        {
            bool aux = false;
            try
            {
                conexion = conexionDB.AbrirConexion();
                string query = "Select * From Ayuda Where CI_profesor = ('" + txtCI.Text + "') and Matricula_alumno = ('" + txtMatricula.Text + "')";
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

        public void ConsultasAlumno()
        {
            try
            {
                conexion = conexionDB.AbrirConexion();
                string query = "select Alumno.Matricula, Alumno.Nombre, Grupo.Nombre  as 'Grupo al que pertence',Profesor.Nombre " +
                    "as 'Profesor que lo dirige' , TFC.Numero_orden, TFC.Tema From Grupo, Profesor, Alumno, TFC " +
                    "Where Alumno.Numero_grupo = Grupo.Numero_grupo and Alumno.CI_profesor = Profesor.CI and " +
                    "Alumno.Numero_orden_tfc = TFC.Numero_orden and Alumno.Estatus = 'Activo' and Alumno." + cboAlumno.Text + " Like ('%" + txtBuscarAlumno.Text + "%')";
                da = new SqlDataAdapter(query, conexion);
                dt = new DataTable();
                da.Fill(dt);
                dgvAlumno.DataSource = dt;
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Menu form = new Menu();
            this.Hide();
            form.Show();
        }

        public void LimpiarDatosAlumno()
        {
            txtMatricula.Clear();
            txtNombre.Clear();
            txtGrupo.Clear();
            txtProfesor.Clear();
            txtTFC.Clear();
            txtTema.Clear();
        }

        public void LimpiarDatosProfesor()
        {
            txtCI.Clear();
            txtPprofesor.Clear();
            txtDomicilio.Clear();
        }

        private void btnNuevo1_Click(object sender, EventArgs e)
        {
            LimpiarDatosAlumno();
        }

        private void btnNuevo2_Click(object sender, EventArgs e)
        {
            LimpiarDatosProfesor();
        }

        private void BtnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgvAlumno.SelectedRows.Count > 0)
            {
                txtMatricula.Text = dgvAlumno.SelectedCells[0].Value.ToString();
                txtNombre.Text = dgvAlumno.SelectedCells[1].Value.ToString();
                txtGrupo.Text = dgvAlumno.SelectedCells[2].Value.ToString();
                txtProfesor.Text = dgvAlumno.SelectedCells[3].Value.ToString();
                txtTFC.Text = dgvAlumno.SelectedCells[4].Value.ToString();
                txtTema.Text = dgvAlumno.SelectedCells[5].Value.ToString();
            }
        }

        private void btnSeleccionarProfesor_Click(object sender, EventArgs e)
        {
            if (dgvProfesor.SelectedRows.Count > 0)
            {
                txtCI.Text = dgvProfesor.SelectedCells[0].Value.ToString();
                txtPprofesor.Text = dgvProfesor.SelectedCells[1].Value.ToString();
                txtDomicilio.Text = dgvProfesor.SelectedCells[2].Value.ToString();
            }
        }

        public bool ValidarCampos()
        {
            bool aux = false;
            if (txtMatricula.Text == "" || txtNombre.Text == "" || txtGrupo.Text == ""
                || txtProfesor.Text == "" || txtTFC.Text == "" || txtCI.Text == "" || txtPprofesor.Text == ""
                || txtDomicilio.Text == "")
            {
                aux = true;
            }
            return aux;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                MessageBox.Show("Existen campos vacios", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (ConsultarAyuda())
            {
                MessageBox.Show("Ese profesor ya esta ayudando al alumno seleccionado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                conexion = conexionDB.AbrirConexion();
                cmd = new SqlCommand("AddAyuda", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter Matricula = new SqlParameter("@Matricula_alumno", SqlDbType.Char, 10);
                Matricula.Value = txtMatricula.Text;
                cmd.Parameters.Add(Matricula);

                SqlParameter CI = new SqlParameter("@CI_profesor", SqlDbType.VarChar, 10);
                CI.Value = txtCI.Text;
                cmd.Parameters.Add(CI);

                cmd.ExecuteNonQuery();
                CargarRegistros();
                MessageBox.Show("Registro exitoso: el profesor " + txtPprofesor.Text + " ayudara al alumno " + txtNombre.Text + " en el trabajo de carrera final " + txtTema.Text );
                LimpiarDatosAlumno();
                LimpiarDatosProfesor();
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtBuscarProfesor_KeyUp(object sender, KeyEventArgs e)
        {
            if (cboProfesor.SelectedIndex == -1)
            {
                MessageBox.Show("Elige porque tipo de datos quieres consultar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBuscarProfesor.Clear();
            }
            else
            {
                ConsultasProfesor();
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txtBuscarAlumno_KeyUp(object sender, KeyEventArgs e)
        {
            if (cboAlumno.SelectedIndex == -1)
            {
                MessageBox.Show("Elige porqué tipo de dato quieres consultar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBuscarAlumno.Clear();
            }
            else
            {
                ConsultasAlumno();
            }
        }
    }
}
