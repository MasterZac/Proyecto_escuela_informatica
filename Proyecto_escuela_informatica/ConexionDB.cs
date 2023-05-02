using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using System.Security.RightsManagement;

namespace Proyecto_escuela_informatica
{
    public class ConexionDB
    {
        private string cadenaConexion;

        public ConexionDB(string usuario, string password)
        {
            cadenaConexion = $"Data source = DESKTOP-T35PUJQ\\SQLEXPRESS; initial catalog = Escuela_informatica; user id = {usuario}; password = {password}";
        }

        public SqlConnection AbrirConexion()
        {
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            conexion.Open();
            return conexion;
        }

        public void CerrarConexion(SqlConnection conexion)
        {
            conexion.Close();
        }
    }
}
