using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;
using MySql.Data.MySqlClient;

namespace GestorTareas
{
    internal class Conexion
    {
        public static MySqlConnection Connection()
        {
            string servidor = "localhost";
            string db = "gestor_tareas";
            string usuario = "root";
            string password = "";
            
            string cadenaConexion = "Database=" + db + "; Data Source=" +
            servidor + "; User Id=" + usuario + "; Password=" + password + "";

            try 
            { 
                MySqlConnection conexionDB = new MySqlConnection(cadenaConexion);
                return conexionDB;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: "+ex.Message);
                return null;
            }  

  }
    
    }
}
