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
    public partial class Examina : Form
    {
        public Examina()
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

        private void Examina_Load(object sender, EventArgs e)
        {
            CargarDgvAlumno();
            CargarDgvTribunal();
            CargarDgvExamina();
            txtFecha.Text = Convert.ToString(DateTime.Now.ToString("d"));
        } 

        public bool ValidaCampos()
        {
            bool aux = false;
            if (txtNumeroTribunal.Text == "" || txtLugarExamen.Text == "" || txtNumeroComponentes.Value == 0
                || txtMatricula.Text == "" || txtNombre.Text == "" || txtNumeroOrden.Text == "" || txtTema.Text == ""
                || txtFecha.Text == "")
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
                string query = "Select * From Examina Where Matricula_alumno = ('" + txtMatricula.Text + "')";
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

        public void ConsultasAlumno()
        {
            try
            {
                conexion = conexionDB.AbrirConexion();
                string query = "select Alumno.Matricula, Alumno.Nombre, TFC.Numero_orden, TFC.Tema From Alumno, TFC " +
                    "Where Alumno.Numero_orden_tfc = TFC.Numero_orden and Alumno.Estatus = 'Activo' and Alumno." + cboAlumno.Text + " Like ('%" + txtBuscarAlumno.Text + "%')";
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

        public void ConsultasTribunal()
        {
            try
            {
                conexion = conexionDB.AbrirConexion();
                string query = "select Numero_tribunal, Lugar_examen, Numero_componentes from tribunal Where Estatus = 'Activo' and (" + cboTribunal.Text + ") Like ('%" + txtBuscarTribunal.Text + "%')";
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

        public void CargarDgvAlumno()
        {
            conexion = conexionDB.AbrirConexion();
            try
            {
                string query = "select Alumno.Matricula, Alumno.Nombre, TFC.Numero_orden, TFC.Tema From Alumno, TFC " +
                    "Where Alumno.Numero_orden_tfc = TFC.Numero_orden and Alumno.Estatus = 'Activo'";
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

        public void CargarDgvTribunal()
        {
            conexion = conexionDB.AbrirConexion();
            try
            {
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

        public void CargarDgvExamina()
        {
            conexion = conexionDB.AbrirConexion();
            try
            {
                string query = "Select Examina.Num_Tribunal, tribunal.Lugar_examen, Examina.Matricula_alumno, " +
                    "Alumno.Nombre, Examina.Numero_orden_tfc, TFC.Tema, Examina.Fecha from Examina, tribunal, Alumno, TFC " +
                    "Where Examina.Num_Tribunal = tribunal.Numero_tribunal and Examina.Matricula_alumno = Alumno.Matricula and " +
                    "Examina.Numero_orden_tfc = TFC.Numero_orden";
                da = new SqlDataAdapter(query, conexion);
                dt = new DataTable();
                da.Fill(dt);
                dgvExamina.DataSource = dt;
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

        public void NuevoTribunal()
        {
            txtNumeroTribunal.Clear();
            txtLugarExamen.Clear();
            txtNumeroComponentes.Value = 0;
        }

        public void NuevoAlumno()
        {
            txtMatricula.Clear();
            txtNombre.Clear();
            txtNumeroOrden.Clear();
            txtTema.Clear();
            txtFecha.Clear();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (ValidaCampos())
            {
                MessageBox.Show("Existen campos vacios", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (ConsultaExistencia())
            {
                MessageBox.Show("El alumno seleccionado ya realizo un trabajo final de carrera", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                try
                {
                    conexion = conexionDB.AbrirConexion();
                    cmd = new SqlCommand("AddExamina", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter num_tribunal = new SqlParameter("@Num_tribunal", SqlDbType.Char, 5);
                    num_tribunal.Value = txtNumeroTribunal.Text;
                    cmd.Parameters.Add(num_tribunal);

                    SqlParameter Matricula_alumno = new SqlParameter("@Matricula_alumno", SqlDbType.Char, 10);
                    Matricula_alumno.Value = txtMatricula.Text;
                    cmd.Parameters.Add(Matricula_alumno);

                    SqlParameter Numero_orden = new SqlParameter("@Numero_orden", SqlDbType.Char, 10);
                    Numero_orden.Value = txtNumeroOrden.Text;
                    cmd.Parameters.Add(Numero_orden);

                    SqlParameter Fecha = new SqlParameter("@Fecha", SqlDbType.Date);
                    Fecha.Value = Convert.ToDateTime(txtFecha.Text);
                    cmd.Parameters.Add(Fecha);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registro exitoso: el alumno " + txtNombre.Text + " ha defendido el TFC " + txtTema.Text + " en la fecha " + txtFecha.Text);
                    CargarDgvExamina();
                    NuevoTribunal();
                    NuevoAlumno();
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
            NuevoAlumno();
        }

        private void btnSeleccion1_Click(object sender, EventArgs e)
        {
            if (dgvAlumno.SelectedRows.Count > 0)
            {
                txtMatricula.Text = dgvAlumno.SelectedCells[0].Value.ToString();
                txtNombre.Text = dgvAlumno.SelectedCells[1].Value.ToString();
                txtNumeroOrden.Text = dgvAlumno.SelectedCells[2].Value.ToString();
                txtTema.Text = dgvAlumno.SelectedCells[3].Value.ToString();
                dgvAlumno.ClearSelection();
                MessageBox.Show("Alumno seleccionado");
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

        private void btnSelecciona2_Click(object sender, EventArgs e)
        {
            if (dgvTribunal.SelectedRows.Count > 0)
            {
                txtNumeroTribunal.Text = dgvTribunal.SelectedCells[0].Value.ToString();
                txtLugarExamen.Text = dgvTribunal.SelectedCells[1].Value.ToString();
                txtNumeroComponentes.Value = Convert.ToUInt32(dgvTribunal.SelectedCells[2].Value.ToString());
                dgvTribunal.ClearSelection();
                MessageBox.Show("Tribunal Seleccionado");
            }
        }

        private void txtBuscarAlumno_KeyUp(object sender, KeyEventArgs e)
        {
            if (cboAlumno.SelectedIndex == -1)
            {
                MessageBox.Show("Elige porque tipo de dato quieres consultar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                ConsultasAlumno();
            }
        }

        private void txtBuscarTribunal_KeyUp(object sender, KeyEventArgs e)
        {
            if (cboTribunal.SelectedIndex == -1)
            {
                MessageBox.Show("Elige porque tipo de datos quieres consultar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                ConsultasTribunal();
            }
        }
    }
}
