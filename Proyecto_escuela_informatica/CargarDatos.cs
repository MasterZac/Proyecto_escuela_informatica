using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_escuela_informatica
{
    internal class CargarDatos
    {
        ConexionDB conexionDB = new ConexionDB(GlobalVariables.Usuario, GlobalVariables.Contraseña);
        SqlDataAdapter da;
        SqlConnection conexion = new SqlConnection();
        DataTable dt;
        
        public void DgvGrupo(DataGridView dgv)
        {
            conexion = conexionDB.AbrirConexion();
            try
            {
                da = new SqlDataAdapter("cargarGrupo", conexion);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
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

        public void DgvProfesor(DataGridView dgv)
        {
            conexion = conexionDB.AbrirConexion();
            try
            {
                da = new SqlDataAdapter("cargarProfesor", conexion);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
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
}
