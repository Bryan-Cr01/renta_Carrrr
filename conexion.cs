using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primera_fachada
{
    class Conexion
    {
public static  MySqlConnection conexion()
        {
            string servidor = "localhost";
            string bd = "renta_car";
            string usuario = "root";
            string password = "";
            string cadena = "Database=" + bd + ";Data Source=" + servidor + ";User ID=" + usuario + ";Password=" + password + "";
            try
            {
                MySqlConnection conexion_bd = new MySqlConnection(cadena);
                return conexion_bd;
            }
            catch(MySqlException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return null;
            }
        }
    }
}
