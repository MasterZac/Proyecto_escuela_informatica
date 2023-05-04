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
        CargarDatos cargar = new CargarDatos();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
       


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
            if (TxtNumeroGrupo.Text == "" || txtNombre.Text == "" || txtNumeroComponentes.Value == 0 || txtEstatus.Text == "")
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
            SqlConnection conexion = conexionDB.AbrirConexion();
            try
            {
                cmd = new SqlCommand("ValidaActuaGrupo", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter Numero_grupo = new SqlParameter("@Numero_grupo", SqlDbType.Char, 10);
                Numero_grupo.Value = TxtNumeroGrupo.Text;
                cmd.Parameters.Add(Numero_grupo);

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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
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

            SqlConnection conexion = conexionDB.AbrirConexion();
            try
            {
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

                cmd.ExecuteNonQuery();
                Limpiar();
                MessageBox.Show("¡Grupo agregado!");

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

                SqlConnection conexion = conexionDB.AbrirConexion();
                try
                {
                    cmd = new SqlCommand("DeleteGrupo", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter Numero_grupo = new SqlParameter("@Numero_grupo", SqlDbType.Char, 10);
                    Numero_grupo.Value = TxtNumeroGrupo.Text;
                    cmd.Parameters.Add(Numero_grupo);

                    SqlParameter Estatus = new SqlParameter("@ID_estatus", SqlDbType.Int);
                    if (txtEstatus.Text == "Activo")
                        Estatus.Value = 1;
                    else
                        Estatus.Value = 2;
                    cmd.Parameters.Add(Estatus);

                    cmd.ExecuteNonQuery();
                    Limpiar();
                    MessageBox.Show("Grupo " + txtEstatus.Text);
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
                SqlConnection conexion = conexionDB.AbrirConexion();
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
        }
    }
}
