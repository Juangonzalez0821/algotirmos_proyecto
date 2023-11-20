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
using MySql.Data.MySqlClient;
using MySqlConnection = MySql.Data.MySqlClient.MySqlConnection;

namespace GestorTareas
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String user = textUser.Text;
            String pass = textPass.Text;

            MySqlDataReader reader = null;
            String sql = "SELECT * FROM user WHERE name=@user AND pass=@pass";
            MySqlConnection conexionBD = Conexion.Connection();
            conexionBD.Open();

            try
            {
                MySqlCommand commando = new MySqlCommand(sql, conexionBD);
                commando.Parameters.AddWithValue("@user", user);
                commando.Parameters.AddWithValue("@pass", pass);

                reader = commando.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read(); // Avanza al primer resultado
                    int userId = reader.GetInt32("id"); // Asegúrate de ajustar el tipo de dato según tu base de datos
                    Master_panel newForm = new Master_panel();
                    newForm.SetUserId(userId);
                    newForm.Show();
                }
                else
                {
                    MessageBox.Show("Datos incorrecta");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error del sistema: " + ex.Message);
            }
            finally
            {
                conexionBD.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String user = textUser.Text;
            String pass = textPass.Text;
            String sql = "INSERT INTO user (name, pass) VALUES ('" + user + "'," +
                "'" + pass + "' )";
            MySqlConnection conexionBD = Conexion.Connection();
            conexionBD.Open();
            try
            {
                MySqlCommand commando = new MySqlCommand(sql, conexionBD);
                commando.ExecuteNonQuery();
                MessageBox.Show("Registro guardado");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
            finally
            {
                conexionBD.Close();
            }
        }

        private void textPass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
