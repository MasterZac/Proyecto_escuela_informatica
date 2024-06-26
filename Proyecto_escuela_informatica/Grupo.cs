﻿using System;
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
        CargarDatos cargar = new CargarDatos();
        SqlConnection conexion = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da;
        SqlDataReader dr;
        DataTable dt;

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Grupo_Load(object sender, EventArgs e)
        {
            cargar.DgvGrupo(dgvGrupo);
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
            if (TxtNumeroGrupo.Text == string.Empty|| txtNombre.Text == string.Empty || txtNumeroComponentes.Value == 0)
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
                string query = "Select * From Grupo Where Numero_grupo = ('" + TxtNumeroGrupo.Text + "') ";
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

        public bool ValidarActualizacion()
        {
            bool aux = false;
            try
            {
                conexion = conexionDB.AbrirConexion();
                string query = "Select * From Grupo Where Numero_grupo = ('" + TxtNumeroGrupo.Text + "') and Nombre = ('" + txtNombre.Text + "') and Numero_componentes = (" + txtNumeroComponentes.Value + ")";
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
            TxtNumeroGrupo.Clear();
            txtNombre.Clear();
            txtNumeroComponentes.Value = 0;
            txtEstatus.Clear();
            TxtNumeroGrupo.Focus();
        }

        public void Consultas()
        {
            try
            {
                conexion = conexionDB.AbrirConexion();
                string query = "Select * From Grupo Where (" + cboConsultaPor.Text + ") Like ('" + txtBuscar.Text + "%')";
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int filas_afectadas = 0;
            if (ValidarCampos())
            {
                MessageBox.Show("Los campos estan vacios", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (ConsultarExistencia())
            {
                MessageBox.Show("Grupo ya existente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                conexion = conexionDB.AbrirConexion();
                cmd = new SqlCommand("AddGrupo", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter Numero_grupo = new SqlParameter("@Numero_grupo", SqlDbType.Char, 10);
                Numero_grupo.Value = TxtNumeroGrupo.Text;
                cmd.Parameters.Add(Numero_grupo);

                SqlParameter Nombre = new SqlParameter("@Nombre", SqlDbType.VarChar, 100);
                Nombre.Value = txtNombre.Text;
                cmd.Parameters.Add(Nombre);

                SqlParameter Numero_componentes = new SqlParameter("@Numero_componentes", SqlDbType.Int);
                Numero_componentes.Value = txtNumeroComponentes.Value;
                cmd.Parameters.Add(Numero_componentes);

                filas_afectadas = cmd.ExecuteNonQuery();
                if (filas_afectadas > 0)
                {
                    Limpiar();
                    cargar.DgvGrupo(dgvGrupo);
                    MessageBox.Show("¡Grupo agregado!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro al agregar el grupo: " + ex.Message);
            }
            finally
            {
             
                conexionDB.CerrarConexion(conexion);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int filas_afectadas = 0;
            if (TxtNumeroGrupo.Text == "")
            {
                MessageBox.Show("Ingrese el Numero del grupo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (ConsultarExistencia())
            {
                if (txtEstatus.Text == "Activo")
                {
                    txtEstatus.Text = "Inactivo";
                }
                else
                {
                    txtEstatus.Text = "Activo";
                }

                conexion = conexionDB.AbrirConexion();
                try
                {
                    cmd = new SqlCommand("DeleteGrupo", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter Numero_grupo = new SqlParameter("@Numero_grupo", SqlDbType.Char, 10);
                    Numero_grupo.Value = TxtNumeroGrupo.Text;
                    cmd.Parameters.Add(Numero_grupo);

                    SqlParameter Estatus = new SqlParameter("@Estatus", SqlDbType.VarChar, 50);
                    Estatus.Value = txtEstatus.Text;
                    cmd.Parameters.Add(Estatus);

                    filas_afectadas = cmd.ExecuteNonQuery();

                    if (filas_afectadas > 0)
                    {
                        cargar.DgvGrupo(dgvGrupo);
                        Limpiar();
                        MessageBox.Show("Grupo habilitado o Deshabilitado");
                    }
                }
                catch (SqlException ex) 
                {
                    Limpiar();
                    MessageBox.Show("Error al habilitar o deshabilidar el grupo: " + ex.Message);
                }
                finally
                {
                    conexionDB.CerrarConexion(conexion);
                }
            }
            else
            {
                MessageBox.Show("Grupo no existente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                MessageBox.Show("Existen campos vacios", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (ValidarActualizacion())
            {
                MessageBox.Show("No se realizo ninguna actualizacion", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (ConsultarExistencia())
            {
                conexion = conexionDB.AbrirConexion();
                try
                {
                    cmd = new SqlCommand("UpdateGrupo", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter Numero_grupo = new SqlParameter("@Numero_grupo", SqlDbType.Char, 10);
                    Numero_grupo.Value = TxtNumeroGrupo.Text;
                    cmd.Parameters.Add(Numero_grupo);

                    SqlParameter Nombre = new SqlParameter("@Nombre", SqlDbType.VarChar, 100);
                    Nombre.Value = txtNombre.Text;
                    cmd.Parameters.Add(Nombre);

                    SqlParameter Numero_componentes = new SqlParameter("@Numero_componentes", SqlDbType.Int);
                    Numero_componentes.Value = txtNumeroComponentes.Value;
                    cmd.Parameters.Add(Numero_componentes);

                    cmd.ExecuteNonQuery();
                    Limpiar();
                    MessageBox.Show("Grupo actualizado");
                    cargar.DgvGrupo(dgvGrupo);
                }
                catch(Exception ex)
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
                MessageBox.Show("Grupo no existente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            if (cboConsultaPor.Text == "")
            {
                MessageBox.Show("Elige por que tipo de dato quieres consultar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                Consultas();
            }
        }

        private void dgvGrupo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvGrupo.SelectedRows.Count > 0)
            {
                TxtNumeroGrupo.Text = dgvGrupo.SelectedCells[0].Value.ToString();
                txtNombre.Text = dgvGrupo.SelectedCells[1].Value.ToString();
                txtNumeroComponentes.Value = Convert.ToInt32(dgvGrupo.SelectedCells[2].Value.ToString());
                txtEstatus.Text = dgvGrupo.SelectedCells[3].Value.ToString();
                dgvGrupo.ClearSelection();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void TxtNumeroGrupo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros, sin espacio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
                return;
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33) && (e.KeyChar <= 47) || (e.KeyChar >= 58) && (e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros y letras", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
                return;
            }
        }
    }
}
