using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace Proyecto_escuela_informatica
{
    internal class Conexion
    {
        SqlConnection conexion = new SqlConnection();

        static string servidor = "DESKTOP-T35PUJQ\\SQLEXPRESS";
        static string bd = "Escuela_informatica";
        static string usuario = "Usuario1";
        static string puerto = "";
        static string password = "root";

        string cadenaConexion = "data source = " + servidor + ";" + " initial catalog = " + bd + ";" + " user id = " + usuario + ";" + " password = " + password + ";";

        public SqlConnection establecerConexion()
        {
            try
            {
                conexion.ConnectionString = cadenaConexion;
                conexion.Open();
                MessageBox.Show("Se conecto correctamente a la base de datos");
            }
            catch (Exception ex) 
            {
                MessageBox.Show("No se logro conectar a la base de datos " + ex.ToString());
            }
            finally
            {
                conexion.Close();
            }
            return conexion;
        }
    }
}
