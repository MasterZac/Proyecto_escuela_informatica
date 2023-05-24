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
    public partial class Alumno : Form
    {
        public Alumno()
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



        private void Alumno_Load(object sender, EventArgs e)
        {
            cargar.DgvAlumno(dgvAlumno);
            CargarDgvTFC();
            CargarDgvGrupo();
            CargarDgvProfesor();
        }

        public void CargarDgvTFC()
        {
            conexion = conexionDB.AbrirConexion();
            try
            {
                string query = "Select * From TFC Where Estatus = 'Activo'";
                da = new SqlDataAdapter(query, conexion);
                dt = new DataTable();
                da.Fill(dt);
                dgvTFC.DataSource = dt;
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

        public void CargarDgvGrupo()
        {
            conexion = conexionDB.AbrirConexion();
            try
            {
                string query = "Select * From Grupo Where Estatus = 'Activo'";
                da = new SqlDataAdapter(query, conexion);
                dt = new DataTable();
                da.Fill(dt);
                dgvGrupo.DataSource = dt;
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
                string query = "Select * From Profesor Where Estatus = 'Activo'";
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


        public bool ValidaCampos()
        {
            bool aux = false;
            if (txtMatricula.Text == "" || txtCI.Text == "" || txtNombre.Text == "" || txtNumeroGrupo.Text == "" || 
                txtCIProfesor.Text == "" || txtNumeroOrden.Text == "" || txtEstatus.Text == "")
            {
                aux = true;
            }
            return aux;
        }

        public bool ConsultaExistencia()
        {
            bool aux = false;
            try
            {
                conexion = conexionDB.AbrirConexion();
                string query = "Select * From Alumno Where Matricula = ('" + txtMatricula.Text + "') ";
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

        public bool ValidaActualizacion()
        {
            bool aux = false;
            try
            {
                conexion = conexionDB.AbrirConexion();
                string query = "Select * From Alumno Where Matricula = ('" + txtMatricula.Text + "') and CI = ('" + txtCI.Text + "') and " +
                    "Nombre = ('" + txtNombre.Text + "') and Numero_grupo = ('" + txtNumeroGrupo.Text + "') and CI_profesor = ('" + txtCIProfesor.Text + "') and " +
                    "Numero_orden_tfc = ('" + txtNumeroOrden.Text + "') and Estatus = ('" + txtEstatus.Text + "')";
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

        public void Consultas()
        {
            try
            {
                conexion = conexionDB.AbrirConexion();
                string query = "Select * From Alumno Where (" + cboAlumno.Text + ") Like ('" + txtBuscar.Text + "')";
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

        public void Limpiar()
        {
            txtMatricula.Clear();
            txtCI.Clear(); 
            txtNombre.Clear();
            txtNumeroGrupo.Clear();
            txtCIProfesor.Clear();
            txtNumeroOrden.Clear();
            txtEstatus.Clear();
            txtMatricula.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Menu form = new Menu();
            this.Hide();
            form.Show();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidaCampos())
            {
                MessageBox.Show("Los campos estan vacios", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (ConsultaExistencia())
            {
                MessageBox.Show("Alumno ya existente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                conexion = conexionDB.AbrirConexion();
                cmd = new SqlCommand("AddAlumno", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter Matricula = new SqlParameter("@Matricula", SqlDbType.Char, 10);
                Matricula.Value = txtMatricula.Text;
                cmd.Parameters.Add(Matricula);

                SqlParameter CI = new SqlParameter("@CI", SqlDbType.VarChar, 5);
                CI.Value = txtCI.Text;
                cmd.Parameters.Add(CI);

                SqlParameter Nombre = new SqlParameter("@Nombre", SqlDbType.VarChar, 100);
                Nombre.Value = txtNombre.Text;
                cmd.Parameters.Add(Nombre);

                SqlParameter Numero_grupo = new SqlParameter("@Numero_grupo", SqlDbType.Char, 10);
                Numero_grupo.Value = txtNumeroGrupo.Text;
                cmd.Parameters.Add(Numero_grupo);

                SqlParameter CI_profesor = new SqlParameter("@CI_profesor", SqlDbType.VarChar, 50);
                CI_profesor.Value = txtCIProfesor.Text;
                cmd.Parameters.Add(CI_profesor);

                SqlParameter Numero_orden = new SqlParameter("@Numero_orden", SqlDbType.Char, 10);
                Numero_orden.Value = txtNumeroOrden.Text;
                cmd.Parameters.Add(Numero_orden);

                SqlParameter Estatus = new SqlParameter("@Estatus", SqlDbType.VarChar, 50);
                Estatus.Value = txtEstatus.Text;
                cmd.Parameters.Add(Estatus);

                cmd.ExecuteNonQuery();
                cargar.DgvAlumno(dgvAlumno);
                Limpiar();
                MessageBox.Show("Alumno agregado");
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtMatricula.Text == "")
            {
                MessageBox.Show("Ingresa la matricula del alumno", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (ConsultaExistencia())
            {
                if (txtEstatus.Text == "Activo")
                {
                    txtEstatus.Text = "Inactivo";
                }
                else
                {
                    txtEstatus.Text = "Activo";
                }

                try
                {
                    conexion = conexionDB.AbrirConexion();
                    cmd = new SqlCommand("DeleteAlumno", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter Matricula = new SqlParameter("@Matricula", SqlDbType.Char, 10);
                    Matricula.Value = txtMatricula.Text;
                    cmd.Parameters.Add(Matricula);

                    SqlParameter Estatus = new SqlParameter("@Estatus", SqlDbType.VarChar, 50);
                    Estatus.Value = txtEstatus.Text;
                    cmd.Parameters.Add(Estatus);

                    cmd.ExecuteNonQuery();
                    cargar.DgvAlumno(dgvAlumno);
                    Limpiar();
                    MessageBox.Show("Alumno Habilitado y/o Deshabilitado");

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
            else
            {
                MessageBox.Show("Alumno no existente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (ValidaCampos())
            {
                MessageBox.Show("Existen campos vacios", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (ValidaActualizacion())
            {
                MessageBox.Show("No realizo ningun cambio", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (ConsultaExistencia())
            {
                try
                {
                    conexion = conexionDB.AbrirConexion();
                    cmd = new SqlCommand("UpdateAlumno", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter Matricula = new SqlParameter("@Matricula", SqlDbType.Char, 10);
                    Matricula.Value = txtMatricula.Text;
                    cmd.Parameters.Add(Matricula);

                    SqlParameter CI = new SqlParameter("@CI", SqlDbType.VarChar, 5);
                    CI.Value = txtCI.Text;
                    cmd.Parameters.Add(CI);

                    SqlParameter Nombre = new SqlParameter("@Nombre", SqlDbType.VarChar, 100);
                    Nombre.Value = txtNombre.Text;
                    cmd.Parameters.Add(Nombre);

                    SqlParameter Numero_grupo = new SqlParameter("@Numero_grupo", SqlDbType.Char, 10);
                    Numero_grupo.Value = txtNumeroGrupo.Text;
                    cmd.Parameters.Add(Numero_grupo);

                    SqlParameter CI_profesor = new SqlParameter("@CI_profesor", SqlDbType.VarChar, 50);
                    CI_profesor.Value = txtCIProfesor.Text;
                    cmd.Parameters.Add(CI_profesor);

                    SqlParameter Numero_orden = new SqlParameter("@Numero_orden", SqlDbType.Char, 10);
                    Numero_orden.Value = txtNumeroOrden.Text;
                    cmd.Parameters.Add(Numero_orden);

                    SqlParameter Estatus = new SqlParameter("@Estatus", SqlDbType.VarChar, 50);
                    Estatus.Value = txtEstatus.Text;
                    cmd.Parameters.Add(Estatus);

                    cmd.ExecuteNonQuery();
                    cargar.DgvAlumno(dgvAlumno);
                    Limpiar();
                    MessageBox.Show("Alumno actualizado");
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
            else
            {
                MessageBox.Show("Alumno no existente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


        }

        private void dgvAlumno_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAlumno.SelectedRows.Count > 0)
            {
                txtMatricula.Text = dgvAlumno.SelectedCells[0].Value.ToString();
                txtCI.Text = dgvAlumno.SelectedCells[1].Value.ToString();
                txtNombre.Text = dgvAlumno.SelectedCells[2].Value.ToString();
                txtNumeroGrupo.Text = dgvAlumno.SelectedCells[3].Value.ToString();
                txtCIProfesor.Text = dgvAlumno.SelectedCells[4].Value.ToString();
                txtNumeroOrden.Text = dgvAlumno.SelectedCells[5].Value.ToString();
                txtEstatus.Text = dgvAlumno.SelectedCells[6].Value.ToString();
                dgvAlumno.ClearSelection();
            }
        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            if (cboAlumno.SelectedIndex == -1)
            {
                MessageBox.Show("Elige porque tipo de dato quieres consultas", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                Consultas();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void consultarGrupoToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void ConsultaGrupo()
        {
            try
            {
                conexion = conexionDB.AbrirConexion();
                string query = "Select * From Grupo Where (" + cboGrupo.Text + ") Like ('" + txtBuscarGrupo.Text + "')";
                da = new SqlDataAdapter(query, conexion);
                dt = new DataTable();
                da.Fill(dt);
                dgvGrupo.DataSource = dt;
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

        public void ConsultaProfesor()
        {
            try
            {
                conexion = conexionDB.AbrirConexion();
                string query = "Select * From Profesor Where (" + cboProfesor.Text + ") Like ('" + txtBuscarProfesor.Text + "')";
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

        public void ConsultaTFC()
        {
            try
            {
                conexion = conexionDB.AbrirConexion();
                string query = "Select * From TFC Where (" + cboTFC.Text + ") Like ('" + txtBuscarTFC.Text + "')";
                da = new SqlDataAdapter(query, conexion);
                dt = new DataTable();
                da.Fill(dt);
                dgvTFC.DataSource = dt;
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

        private void txtBuscarTFC_KeyUp(object sender, KeyEventArgs e)
        {
            if (cboTFC.SelectedIndex == -1)
            {
                MessageBox.Show("Elige por que tipo de datos quieres consultar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                ConsultaTFC();
            }
           
        }

        private void txtBuscarProfesor_KeyUp(object sender, KeyEventArgs e)
        {
            if (cboProfesor.SelectedIndex == -1)
            {
                MessageBox.Show("Elige por que tipo de datos quieres consultar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
                
            }
            else
            {
                ConsultaProfesor();
            }
            
        }

        private void txtBuscarGrupo_KeyUp(object sender, KeyEventArgs e)
        {
            if (cboGrupo.SelectedIndex == -1)
            {
                MessageBox.Show("Elige por que tipo de dato quiere consultar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
               
            }
            else
            {
                ConsultaGrupo();
            }
            
        }
    }
}
