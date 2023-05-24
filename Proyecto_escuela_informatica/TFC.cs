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
    public partial class TFC : Form
    {
        public TFC()
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

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void TFC_Load(object sender, EventArgs e)
        {
            cargar.DgvTFC(dgvTFC);
        }

        public void Consultas()
        {
            try
            {
                conexion = conexionDB.AbrirConexion();
                string query = "Select * From TFC (" + cboTFC.Text + ") like ('" + txtBuscar.Text + "')";
                da = new SqlDataAdapter(query, conexion);
                dt = new DataTable();
                da.Fill(dt);
                dgvTFC.DataSource = dt;
            }
            catch (Exception ex )
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
            if (txtNumeroOrden.Text == "" || txtFecha.Text == "" || txtTema.Text == "")
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
                string query = "Select * From TFC Where Numero_orden = ('" + txtNumeroOrden.Text + "')";
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
            conexion = conexionDB.AbrirConexion();
            try
            {
                string query = "Select * From TFC Where Numero_orden = ('" + txtNumeroOrden.Text + "') and Fecha_comienzo = ('" + txtFecha.Text + "') and " +
                    "Tema = ('" + txtTema.Text + "')";
                cmd = new SqlCommand(query, conexion);
                cmd.CommandType = CommandType.Text;
                dr = cmd.ExecuteReader();
                if(dr.Read())
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
            txtNumeroOrden.Clear();
            txtFecha.Clear();
            txtTema.Clear();
            txtEstatus.Clear();
            txtNumeroOrden.Focus();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidaCampos())
            {
                MessageBox.Show("Hay campos vacios", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (ConsultaExistencia())
            {
                MessageBox.Show("TFC ya existente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                conexion = conexionDB.AbrirConexion();
                cmd = new SqlCommand("AddTFC", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter Numero_orden = new SqlParameter("@Numero_orden", SqlDbType.Char, 10);
                Numero_orden.Value = txtNumeroOrden.Text.Trim();
                cmd.Parameters.Add(Numero_orden);

                SqlParameter Fecha = new SqlParameter("@Fecha_comienzo", SqlDbType.Date);
                Fecha.Value = Convert.ToDateTime(txtFecha.Text);
                cmd.Parameters.Add(Fecha);

                SqlParameter Tema = new SqlParameter("@Tema", SqlDbType.VarChar, 100);
                Tema.Value = txtTema.Text.Trim();
                cmd.Parameters.Add(Tema);

                cmd.ExecuteNonQuery();
                Limpiar();
                cargar.DgvTFC(dgvTFC);
                MessageBox.Show("TFC Agregado!");
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

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            if (ValidaCampos())
            {
                MessageBox.Show("Hay campos vacios", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if(ValidaActualizacion())
            {
                MessageBox.Show("No realizo ningun cambio", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (ConsultaExistencia())
            {
                try
                {
                    conexion = conexionDB.AbrirConexion();
                    cmd = new SqlCommand("UpdateTFC", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter Numero_orden = new SqlParameter("@Numero_orden", SqlDbType.Char, 10);
                    Numero_orden.Value = txtNumeroOrden.Text;
                    cmd.Parameters.Add(Numero_orden);

                    SqlParameter Fecha = new SqlParameter("@Fecha_comienzo", SqlDbType.Date);
                    Fecha.Value = Convert.ToDateTime(txtFecha.Text);
                    cmd.Parameters.Add(Fecha);

                    SqlParameter Tema = new SqlParameter("@Tema", SqlDbType.VarChar, 100);
                    Tema.Value = txtTema.Text;
                    cmd.Parameters.Add(Tema);

                    cmd.ExecuteNonQuery();
                    cargar.DgvTFC(dgvTFC);
                    Limpiar();
                    MessageBox.Show("TFC Actualizado");
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
                MessageBox.Show("TFC no existente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtNumeroOrden.Text == "")
            {
                MessageBox.Show("Ingresa el numero de orden del TFC", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    cmd = new SqlCommand("DeleteTFC", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter Numero_orden = new SqlParameter("@Numero_orden", SqlDbType.Char, 10);
                    Numero_orden.Value = txtNumeroOrden.Text;
                    cmd.Parameters.Add(Numero_orden);

                    SqlParameter Estatus = new SqlParameter("@Estatus", SqlDbType.VarChar, 50);
                    Estatus.Value = txtEstatus.Text;
                    cmd.Parameters.Add(Estatus);

                    cmd.ExecuteNonQuery();
                    cargar.DgvTFC(dgvTFC);
                    Limpiar();
                    MessageBox.Show("TFC habilitado y/0 deshabilitado");

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
                MessageBox.Show("TFC no existente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            if (cboTFC.SelectedIndex == -1)
            {
                MessageBox.Show("Eliga un por que tipo de dato quieres consultar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                Consultas();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Menu form = new Menu();
            this.Hide();
            form.Show();
        }

        private void dgvTFC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvTFC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTFC.SelectedRows.Count > 0)
            {
                txtNumeroOrden.Text = dgvTFC.SelectedCells[0].Value.ToString();
                txtFecha.Text = dgvTFC.SelectedCells[1].Value.ToString();
                txtTema.Text = dgvTFC.SelectedCells[2].Value.ToString();
                txtEstatus.Text = dgvTFC.SelectedCells[3].Value.ToString();
                dgvTFC.ClearSelection();
            }
        }
    }
}
