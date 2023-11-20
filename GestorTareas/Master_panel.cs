using GestorTareas.Controller;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
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
using System.Xml.Linq;

namespace GestorTareas
{
    public partial class Master_panel : Form
    {
        private int userId;

        public Master_panel()
        {
            InitializeComponent();
            // Asigna el manejador de eventos al evento CellContentClick del DataGridView
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;


        }

        public void SetUserId(int id)
        {
            userId = id;
            labelUserId.Text = id.ToString();
            CargarDatosDataGridView2();
            CargarDatosDataGridView();
            CargarDatosDataGridView3();
            textBox5.Multiline = true;  // Asegúrate de que el TextBox es de varias líneas
            textBox5.ScrollBars = ScrollBars.Vertical;  // Puedes agregar barras de desplazamiento vertical si es necesario

            // Establecer la altura del TextBox en píxeles
            textBox5.Height = 100;  // Ajusta el valor según tus necesidades

            // Opcional: Establecer el ancho del TextBox en píxeles
            textBox5.Width = 200;  // Ajusta el valor según tus necesidades
        }

        private void Master_panel_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            seeTask.SelectedTab = tabPage2;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            String users = textChangeUser.Text;
            String pass = textChangePass.Text;
            String user_id = labelUserId.Text;
            String sql = "UPDATE user SET pass='" + pass + "', name='" + users + "' WHERE id='" + user_id + "'";

            MySqlConnection conexionBD = Conexion.Connection();
            conexionBD.Open();
            try
            {
                MySqlCommand commando = new MySqlCommand(sql, conexionBD);
                commando.ExecuteNonQuery();
                MessageBox.Show("Registro actualizado");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.Message);
            }
            finally
            {
                conexionBD.Close();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        private async void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Obtener el valor de la celda clicada
                object cellValue = dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

                // Muestra un mensaje con el valor de la celda
                MessageBox.Show("Valor de la celda: " + cellValue, "Celda Clicada");

                // Inicia una tarea (en este caso, usando Task.Delay como ejemplo)
                await RealizarAlgunaTareaAsync();

                // Puedes agregar más lógica aquí si es necesario
            }
        }

        private async Task RealizarAlgunaTareaAsync()
        {
            // Simula una tarea que toma algún tiempo en completarse
            Console.WriteLine("Iniciando tarea...");
            await Task.Delay(2000); // Espera 2 segundos (puedes reemplazar esto con tu lógica específica)

            Console.WriteLine("Tarea completada.");
        }
        //crear una categoria
        private void button5_Click(object sender, EventArgs e)
        {
            String user_id = labelUserId.Text;
            String title = textTitle.Text;
            String sql = "INSERT INTO categories (name, id_user) VALUES ('" + title + "'," +
                "'" + user_id + "' )";
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
            CargarDatosDataGridView2();
            CargarDatosDataGridView();
            CargarDatosDataGridView3();
        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void CargarDatosDataGridView()
        {
            string user_id = labelUserId.Text;
            // Tu conexión a la base de datos (asegúrate de tenerla configurada previamente)
            MySqlConnection conexionBD = Conexion.Connection();

            // La consulta SQL para seleccionar todos los registros de la tabla "categories"
            string sql = "SELECT * FROM `categories` WHERE `id_user`  = @userId";

            // Crear un DataTable para almacenar los resultados de la consulta
            DataTable dt = new DataTable();

            // Abrir la conexión a la base de datos
            conexionBD.Open();

            try
            {
                // Crear un adaptador de datos para ejecutar la consulta y llenar el DataTable
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conexionBD))
                {
                    // Agregar parámetro
                    adapter.SelectCommand.Parameters.AddWithValue("@userId", userId);
                    adapter.Fill(dt);
                }

                // Asignar el DataTable al DataGridView
                dataGridView1.DataSource = dt;

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }
            finally
            {
                // Cerrar la conexión a la base de datos
                conexionBD.Close();
            }
        }

        private void CargarDatosDataGridView3()
        {
            // Utilizar using para gestionar la conexión
            using (MySqlConnection conexionBD = Conexion.Connection())
            {
                // La consulta SQL para seleccionar todos los registros de la tabla "categories"
                string sql = "SELECT * FROM `categories` WHERE `id_user` = @userId";

                // Crear un DataTable para almacenar los resultados de la consulta
                DataTable dt = new DataTable();

                // Abrir la conexión a la base de datos
                conexionBD.Open();

                try
                {
                    // Crear un adaptador de datos para ejecutar la consulta y llenar el DataTable
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conexionBD))
                    {
                        // Agregar parámetro
                        adapter.SelectCommand.Parameters.AddWithValue("@userId", userId);

                        adapter.Fill(dt);
                    }

                    // Asignar el DataTable al DataGridView
                    dataGridView3.DataSource = dt;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al cargar datos: " + ex.Message);
                }
            } // La conexión se cerrará automáticamente al salir del bloque using
        }
        private void CargarDatosDataGridView2()
        {
            // Utilizar using para gestionar la conexión
            using (MySqlConnection conexionBD = Conexion.Connection())
            {
                // La consulta SQL para seleccionar los campos específicos de la tabla "task" con formato de fecha y nombre de categoría
                string sql = "SELECT t.id, c.name AS category_name, t.title, t.description, DATE_FORMAT(t.date, '%Y-%m-%d %H:%i:%s') AS date " +
                             "FROM `task` t " +
                             "JOIN `categories` c ON t.id_categories = c.id " +
                             "WHERE t.`id_user` = @userId";

                // Crear un DataTable para almacenar los resultados de la consulta
                DataTable dt = new DataTable();

                // Abrir la conexión a la base de datos
                conexionBD.Open();

                try
                {
                    // Crear un adaptador de datos para ejecutar la consulta y llenar el DataTable
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conexionBD))
                    {
                        // Agregar parámetro
                        adapter.SelectCommand.Parameters.AddWithValue("@userId", userId);

                        adapter.Fill(dt);
                    }

                    // Asignar el DataTable al DataGridView
                    dataGridView2.DataSource = dt;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al cargar datos: " + ex.Message);
                }
            } // La conexión se cerrará automáticamente al salir del bloque using
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }
        //eliminar una categoria
        private void button6_Click(object sender, EventArgs e)
        {
            String user_id = labelUserId.Text;
            String categories_id = textBox3.Text;

            // SELECT para verificar la existencia de la fila
            String selectQuery = "SELECT * FROM categories WHERE id = " + categories_id + " AND id_user = " + user_id + ";";

            // DELETE si la fila existe
            String deleteQuery = "DELETE FROM categories WHERE id = " + categories_id + " AND id_user = " + user_id + ";";

            MySqlConnection conexionBD = Conexion.Connection();
            conexionBD.Open();

            try
            {
                // Verificar si la fila existe
                MySqlCommand selectCommand = new MySqlCommand(selectQuery, conexionBD);
                MySqlDataReader reader = selectCommand.ExecuteReader();

                if (reader.Read())
                {
                    reader.Close(); // Cerrar el lector antes de ejecutar otra consulta

                    // Ejecutar la consulta DELETE si la fila existe
                    MySqlCommand deleteCommand = new MySqlCommand(deleteQuery, conexionBD);
                    deleteCommand.ExecuteNonQuery();
                    MessageBox.Show("Eliminación exitosa");
                }
                else
                {
                    MessageBox.Show("La categoría no existe para el usuario especificado");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conexionBD.Close();
            }

            CargarDatosDataGridView();
            CargarDatosDataGridView3();
        }
        //actualizar una categoria
        private void button7_Click(object sender, EventArgs e)
        {
            String title = textTitle.Text;
            String user_id = labelUserId.Text;
            String categories_id = textBox3.Text;

            // SELECT para verificar la existencia de la fila
            String selectQuery = "SELECT * FROM categories WHERE id = " + categories_id + " AND id_user = " + user_id + ";";

            // UPDATE si la fila existe
            String updateQuery = "UPDATE categories SET name='" + title + "' WHERE id='" + categories_id + "' AND id_user = " + user_id + ";";

            MySqlConnection conexionBD = Conexion.Connection();
            conexionBD.Open();

            try
            {
                // Verificar si la fila existe
                MySqlCommand selectCommand = new MySqlCommand(selectQuery, conexionBD);
                MySqlDataReader reader = selectCommand.ExecuteReader();

                if (reader.Read())
                {
                    reader.Close(); // Cerrar el lector antes de ejecutar otra consulta

                    // Ejecutar la consulta UPDATE si la fila existe
                    MySqlCommand updateCommand = new MySqlCommand(updateQuery, conexionBD);
                    updateCommand.ExecuteNonQuery();
                    MessageBox.Show("Registro actualizado");
                }
                else
                {
                    MessageBox.Show("La categoría no existe para el usuario especificado");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.Message);
            }
            finally
            {
                conexionBD.Close();
            }
            CargarDatosDataGridView();
            CargarDatosDataGridView2();
            CargarDatosDataGridView3(); ;
        }

        private void textTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void c_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        //crear una tarea
        private void button10_Click(object sender, EventArgs e)
        {
            String user_id = labelUserId.Text;
            String category_id = textBox7.Text;  // Assuming you have the category ID
            String title = textBox4.Text;
            String description = textBox5.Text;
            DateTime date = dateTimePicker1.Value;
            string formattedDate = date.ToString("yyyy-MM-dd HH:mm:ss");

            String sql = "INSERT INTO task (id_user, id_categories, title, description, date) VALUES ('" + user_id + "', '" + category_id + "', '" + title + "', '" + description + "', '" + formattedDate + "')";

            MySqlConnection conexionBD = Conexion.Connection();
            conexionBD.Open();
            try
            {
                MySqlCommand commando = new MySqlCommand(sql, conexionBD);
                commando.ExecuteNonQuery();
                MessageBox.Show("Registro guardado en la tabla 'task'");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
            finally
            {
                conexionBD.Close();
            }
            CargarDatosDataGridView2();
            CargarDatosDataGridView();
            CargarDatosDataGridView3();


        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            textBox5.Multiline = true;  // Asegúrate de que el TextBox es de varias líneas
            textBox5.ScrollBars = ScrollBars.Vertical;  // Puedes agregar barras de desplazamiento vertical si es necesario

            // Establecer la altura del TextBox en píxeles
            textBox5.Height = 100;  // Ajusta el valor según tus necesidades

            // Opcional: Establecer el ancho del TextBox en píxeles
            textBox5.Width = 200;  // Ajusta el valor según tus necesidades


        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
        //actualizar una tarea
        private void button11_Click(object sender, EventArgs e)
        {

            String user_id = labelUserId.Text;
            String category_id = textBox7.Text;
            String title = textBox4.Text;
            String description = textBox5.Text;
            String id_task = textBox6.Text;
            DateTime date = dateTimePicker1.Value;
            string formattedDate = date.ToString("yyyy-MM-dd HH:mm:ss");

            String selectQuery = "SELECT * FROM task WHERE id = " + id_task + " AND id_user = " + user_id + ";";

            string updateQuery = "UPDATE `task` SET `id_categories` = '" + category_id + "', `title` = '" + title + "', `description` = '" + description + "', `date` = '" + formattedDate + "' WHERE `task`.`id` = " + id_task + ";";
            ; ;

            MySqlConnection conexionBD = Conexion.Connection();
            conexionBD.Open();

            try
            {
                // Verificar si la fila existe
                MySqlCommand selectCommand = new MySqlCommand(selectQuery, conexionBD);
                MySqlDataReader reader = selectCommand.ExecuteReader();

                if (reader.Read())
                {
                    reader.Close(); // Cerrar el lector antes de ejecutar otra consulta

                    // Ejecutar la consulta UPDATE si la fila existe
                    MySqlCommand updateCommand = new MySqlCommand(updateQuery, conexionBD);
                    updateCommand.ExecuteNonQuery();
                    MessageBox.Show("Registro actualizado");
                }
                else
                {
                    MessageBox.Show("La tarea no existe para el usuario especificado");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.Message);
            }
            finally
            {
                conexionBD.Close();
            }
            CargarDatosDataGridView();
            CargarDatosDataGridView2();
            CargarDatosDataGridView3();

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
        //eliminar una tarea
        private void button9_Click(object sender, EventArgs e)
        {
            String user_id = labelUserId.Text;
            String task_id = textBox6.Text;

            // SELECT para verificar la existencia de la fila
            String selectQuery = "SELECT * FROM task WHERE id = " + task_id + " AND id_user = " + user_id + ";";

            // DELETE si la fila existe
            String deleteQuery = "DELETE FROM task WHERE id = " + task_id + " AND id_user = " + user_id + ";";

            MySqlConnection conexionBD = Conexion.Connection();
            conexionBD.Open();

            try
            {
                // Verificar si la fila existe
                MySqlCommand selectCommand = new MySqlCommand(selectQuery, conexionBD);
                MySqlDataReader reader = selectCommand.ExecuteReader();

                if (reader.Read())
                {
                    reader.Close(); // Cerrar el lector antes de ejecutar otra consulta

                    // Ejecutar la consulta DELETE si la fila existe
                    MySqlCommand deleteCommand = new MySqlCommand(deleteQuery, conexionBD);
                    deleteCommand.ExecuteNonQuery();
                    MessageBox.Show("Eliminación exitosa");
                }
                else
                {
                    MessageBox.Show("La tarea no existe para el usuario especificado");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conexionBD.Close();
            }

            CargarDatosDataGridView();
            CargarDatosDataGridView2();
            CargarDatosDataGridView3();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            seeTask.SelectedTab = tabPage1;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            seeTask.SelectedTab = tabPage3;
        }

        private void textChangeUser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
