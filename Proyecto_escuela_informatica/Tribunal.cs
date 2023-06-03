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
    public partial class Tribunal : Form
    {
        public Tribunal()
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Menu form = new Menu();
            this.Hide();
            form.Show();
        }

        private void Tribunal_Load(object sender, EventArgs e)
        {
            cargar.DgvTribunal(dgvTribunal);
        }

        public bool ValidaCampos()
        {
            bool aux = false;
            if (txtNumeroTribunal.Text == "" || txtLugarExamen.Text == "" || txtNumeroComponentes.Value == 0)
            {
                aux = true;
            }
            return aux;
        }

        public void Consultas()
        {
            try
            {
                conexion = conexionDB.AbrirConexion();
                string query = "Select * From Tribunal Where (" + cboTribunal.Text + ") Like ('%" + txtConsulta.Text + "%')";
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

        public bool ConsultaExistencia()
        {
            bool aux = false;
            try
            {
                conexion = conexionDB.AbrirConexion();
                string query = "Select * From Tribunal Where Numero_tribunal = ('" + txtNumeroTribunal.Text + "') ";
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
                string query = "Select * From Tribunal Where Numero_tribunal = ('" + txtNumeroTribunal.Text + "')" +
                    "and Lugar_examen = ('" + txtLugarExamen.Text + "') and Numero_componentes = (" + txtNumeroComponentes.Value + ")";
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

        public void Limpiar()
        {
            txtNumeroTribunal.Clear();
            txtLugarExamen.Clear();
            txtNumeroComponentes.Value = 0;
            txtEstatus.Clear();
            txtNumeroTribunal.Focus();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidaCampos())
            {
                MessageBox.Show("Existen campos vacios", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (ConsultaExistencia())
            {
                MessageBox.Show("Tribunal ya existente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                conexion = conexionDB.AbrirConexion();
                cmd = new SqlCommand("AddTribunal", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter Numero_tribunal = new SqlParameter("@Numero_tribunal", SqlDbType.Char, 5);
                Numero_tribunal.Value = txtNumeroTribunal.Text.Trim();
                cmd.Parameters.Add(Numero_tribunal);

                SqlParameter Lugar_examen = new SqlParameter("@Lugar_examen", SqlDbType.VarChar, 100);
                Lugar_examen.Value = txtLugarExamen.Text.Trim();
                cmd.Parameters.Add(Lugar_examen);

                SqlParameter Numero_componentes = new SqlParameter("@Numero_componentes", SqlDbType.Int);
                Numero_componentes.Value = txtNumeroComponentes.Value;
                cmd.Parameters.Add(Numero_componentes);

                cmd.ExecuteNonQuery();
                Limpiar();
                cargar.DgvTribunal(dgvTribunal);
                MessageBox.Show("Tribunal agregado");

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
            if (txtNumeroTribunal.Text == "")
            {
                MessageBox.Show("Ingrese el numero de tribunal", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    cmd = new SqlCommand("DeleteTribunal", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter Numero_tribunal = new SqlParameter("@Numero_tribunal", SqlDbType.Char, 5);
                    Numero_tribunal.Value = txtNumeroTribunal.Text.Trim();
                    cmd.Parameters.Add(Numero_tribunal);

                    SqlParameter Estatus = new SqlParameter("@Estatus", SqlDbType.VarChar, 50);
                    Estatus.Value = txtEstatus.Text;
                    cmd.Parameters.Add(Estatus);

                    cmd.ExecuteNonQuery();
                    Limpiar();
                    cargar.DgvTribunal(dgvTribunal);
                    MessageBox.Show("Tribunal habilitado/deshabilitado");
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
                    cmd = new SqlCommand("UpdateTribunal", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter Numero_tribunal = new SqlParameter("@Numero_tribunal", SqlDbType.Char, 5);
                    Numero_tribunal.Value = txtNumeroTribunal.Text.Trim();
                    cmd.Parameters.Add(Numero_tribunal);

                    SqlParameter Lugar_examen = new SqlParameter("@Lugar_examen", SqlDbType.VarChar, 100);
                    Lugar_examen.Value = txtLugarExamen.Text.Trim();
                    cmd.Parameters.Add(Lugar_examen);

                    SqlParameter Numero_componentes = new SqlParameter("@Numero_componentes", SqlDbType.Int);
                    Numero_componentes.Value = txtNumeroComponentes.Value;
                    cmd.Parameters.Add(Numero_componentes);

                    cmd.ExecuteNonQuery();
                    Limpiar();
                    cargar.DgvTribunal(dgvTribunal);
                    MessageBox.Show("Tribunal agregado");
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
                MessageBox.Show("Tribunal no existente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void dgvTribunal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTribunal.SelectedRows.Count > 0)
            {
                txtNumeroTribunal.Text = dgvTribunal.SelectedCells[0].Value.ToString();
                txtLugarExamen.Text = dgvTribunal.SelectedCells[1].Value.ToString();
                txtNumeroComponentes.Value = Convert.ToInt32(dgvTribunal.SelectedCells[2].Value.ToString());
                txtEstatus.Text = dgvTribunal.SelectedCells[3].Value.ToString();
                dgvTribunal.ClearSelection();
            }
        }

        private void txtConsulta_Click(object sender, EventArgs e)
        {
            
        }

        private void txtConsulta_KeyUp(object sender, KeyEventArgs e)
        {
            if (cboTribunal.SelectedIndex == -1)
            {
                MessageBox.Show("Elige porque tipo de dato quieres consultar ", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                Consultas();
            }
        }

        private void generarArchivoCSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Archivos form = new Archivos();
            this.Hide();
            form.Show();
        }

        private void cargarArchivoCsvToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cargar_archivo form  = new Cargar_archivo();   
            this.Hide();
            form.Show();  
        }

        private void txtNumeroTribunal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros, sin espacio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
                return;
            }
        }

        private void txtLugarExamen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33) && (e.KeyChar <= 64) || (e.KeyChar >= 91) && (e.KeyChar <= 96) || (e.KeyChar >= 123) && (e.KeyChar <= 255))
            {
                MessageBox.Show("Caracter no permitido", "aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
                return;
            }

        }
    }
}
