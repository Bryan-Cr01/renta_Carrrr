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

namespace Primera_fachada
{
    public partial class Form1 : Form
    {
        MySqlConnection conexion = new MySqlConnection("Server=localhost;Database=renta_car; Uid=root;Pwd=;");
        cliente mycliente = new cliente();//instancia de la clase   

        public Form1()
        {
            InitializeComponent();
            int i;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String id = txtid.Text;
            MySqlDataReader reader = null;
            string sql = "SELECT * FROM clientes WHERE Cedula like '"+id+"' LIMIT 1 ";
            MySqlConnection conexion_bd = Conexion.conexion();
            conexion_bd.Open();
            try
            {
            MySqlCommand comando = new MySqlCommand(sql, conexion_bd);
            reader = comando.ExecuteReader();
        if (reader.HasRows)
            {
                while (reader.Read())
                {
                        mycliente.Nombre = reader.GetString(2);
                        mycliente.Direccion = reader.GetString(5);
                        mycliente.Telefono = reader.GetString(3);
                        mycliente.Correo = reader.GetString(4);
                    }
                    label4.Visible = true;
                    pic1.Visible = true;
                    lblnombre.Visible = true;
                    lbltelefono.Visible = true;
                    lbldireccion.Visible = true;
                    lblcorreo.Visible = true;
                    txtnombre.Visible = true;
                    txttelefono.Visible = true;
                    txtdireccion.Visible = true;
                    txtcorreo.Visible = true;
                    txttarjeta.Visible= true;
                    btntarjeta.Visible = true;
                    txtnombre.Text = mycliente.Nombre;
                    txtdireccion.Text = mycliente.Direccion;
                    txttelefono.Text = mycliente.Telefono;
                    txtcorreo.Text = mycliente.Correo;
                  
                }
            else
            {
                MessageBox.Show("No se encontraron registros");
            }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al buscar" + ex.Message);
            }
            finally
            {
                conexion_bd.Close();
            }
        }
        
        
        
        
        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btntarjeta_Click(object sender, EventArgs e)
        {
            mycliente.Numero_Tarjeta = txttarjeta.Text;

        }

        private void btntarjeta1_Click(object sender, EventArgs e)
        {
            mycliente.Numero_Tarjeta = txttarjeta1.Text;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form2 i = new Form2();
            i.Show();  
        }
    }
}
 