using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
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
            cargar.DgvProfesor(dgvProfesor);
        }

        public bool ValidaCampos()
        {
            bool aux = false;
            if (txtCI.Text == "" || txtNombre.Text == "" || txtDomicilio.Text == "" || txtDomicilio.Text == "")
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
                string query = "Select * From Profesor Where (" + cboProfesor.Text + ") like ('%" + txtBuscar.Text + "%')";
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

        public bool ConsultaExistencia()
        {
            bool aux = false;
            try
            {
                conexion = conexionDB.AbrirConexion();
                string query = "Select * From Profesor Where CI = ('" + txtCI.Text + "') ";
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
                string query = "Select * From Profesor Where CI = ('" + txtCI.Text + "') and Nombre = ('" + txtNombre.Text + "')" +
                    "and Domicilio = ('" + txtDomicilio.Text + "')";
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
            txtCI.Clear();
            txtNombre.Clear();
            txtDomicilio.Clear();
            txtEstatus.Clear();
            txtCI.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidaCampos())
            {
                MessageBox.Show("Los campos estan vacios", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (ConsultaExistencia())
            {
                MessageBox.Show("Profesor ya existente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                conexion = conexionDB.AbrirConexion();
                cmd = new SqlCommand("AddProfesor", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter CI = new SqlParameter("@CI", SqlDbType.VarChar, 5);
                CI.Value = txtCI.Text;
                cmd.Parameters.Add(CI);

                SqlParameter Nombre = new SqlParameter("@Nombre", SqlDbType.VarChar, 100);
                Nombre.Value = txtNombre.Text;
                cmd.Parameters.Add(Nombre);

                SqlParameter Domicilio = new SqlParameter("@Domicilio", SqlDbType.VarChar, 100);
                Domicilio.Value = txtDomicilio.Text;
                cmd.Parameters.Add(Domicilio);

                cmd.ExecuteNonQuery();
                Limpiar();
                cargar.DgvProfesor(dgvProfesor);
                MessageBox.Show("Profesor Agregado!");
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtCI.Text == "")
            {
                MessageBox.Show("Ingresa el CI del profesor", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    cmd = new SqlCommand("DeleteProfesor", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter CI = new SqlParameter("@CI", SqlDbType.VarChar, 5);
                    CI.Value = txtCI.Text;
                    cmd.Parameters.Add(CI);

                    SqlParameter Estatus = new SqlParameter("@Estatus", SqlDbType.VarChar, 50);
                    Estatus.Value = txtEstatus.Text;
                    cmd.Parameters.Add(Estatus);

                    cmd.ExecuteNonQuery();
                    cargar.DgvProfesor(dgvProfesor);
                    Limpiar();
                    MessageBox.Show("Profesor habilitado y/o deshabilitado");

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
                MessageBox.Show("Profesor no existente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    cmd = new SqlCommand("UpdateProfesor", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter CI = new SqlParameter("@CI", SqlDbType.VarChar, 5);
                    CI.Value = txtCI.Text;
                    cmd.Parameters.Add(CI);

                    SqlParameter Nombre = new SqlParameter("@Nombre", SqlDbType.VarChar, 100);
                    Nombre.Value = txtNombre.Text;
                    cmd.Parameters.Add(Nombre);

                    SqlParameter Domicilio = new SqlParameter("@Domicilio", SqlDbType.VarChar, 100);
                    Domicilio.Value = txtDomicilio.Text;
                    cmd.Parameters.Add(Domicilio);

                    cmd.ExecuteNonQuery();
                    Limpiar();
                    cargar.DgvProfesor(dgvProfesor);
                    MessageBox.Show("Profesor Actualizado!");
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
                MessageBox.Show("Profesor no existente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void dgvProfesor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProfesor.SelectedRows.Count > 0)
            {
                txtCI.Text = dgvProfesor.SelectedCells[0].Value.ToString();
                txtNombre.Text = dgvProfesor.SelectedCells[1].Value.ToString();
                txtDomicilio.Text = dgvProfesor.SelectedCells[2].Value.ToString();
                txtEstatus.Text = dgvProfesor.SelectedCells[3].Value.ToString();
                dgvProfesor.ClearSelection();
            }
        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            if (cboProfesor.SelectedIndex == -1)
            {
                MessageBox.Show("Elige por que tipo de dato quieres consultas", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                Consultas();
            }
        }

        private void txtCI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32) && (e.KeyChar <= 47) || (e.KeyChar >= 58) && (e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros y letras", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
                return;
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33) && (e.KeyChar <= 47) || (e.KeyChar >= 58) && (e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Caracter no permitido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
                return;
            }
        }

        private void txtDomicilio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33) && (e.KeyChar <= 47) || (e.KeyChar >= 58) && (e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Caracter no permitido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
                return;
            }
        }
    }
}
