using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Primera_fachada
{
    public partial class Form2 : Form
    {
        MySqlConnection conexion = new MySqlConnection("Server=localhost;Database=renta_car; Uid=root;Pwd=;");
        vehiculo myvehiculo = new vehiculo();//instancia de la clase
        DataGridView grid = new DataGridView();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dtvehiculos.DataSource = GetDtvehiculos();

        }
        private DataTable GetDtvehiculos()
        {
            DataTable tabla_vehiculos = new DataTable();
            string Con = ConfigurationManager.ConnectionStrings["db"].ConnectionString;
            using (MySqlConnection con  = new MySqlConnection(Con))
            {
                using (MySqlCommand cmd = new MySqlCommand ("SELECT * FROM perfil_vehiculos", con))
                {
                    con.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    tabla_vehiculos.Load(reader);
                }
            }
            return tabla_vehiculos;
        }
    }
}
