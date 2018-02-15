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

namespace eHospital
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;uid=root;pwd=;database=eHospital";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                String query = "INSERT INTO doctors (username, password, name, lastname, gender, specialization) VALUES (@username,@password, @name, @lastname, @gender, @specialization)";

                MySqlCommand command = new MySqlCommand(query, conn);

                command.Parameters.AddWithValue("@username", textBox1.Text);
                command.Parameters.AddWithValue("@password", textBox2.Text);
                command.Parameters.AddWithValue("@name", textBox3.Text);
                command.Parameters.AddWithValue("@lastname", textBox4.Text);
                command.Parameters.AddWithValue("@specialization", textBox5.Text);

                if (radioButton1.Checked)
                    command.Parameters.AddWithValue("@gender", "female");
                else
                    command.Parameters.AddWithValue("@gender", "male");

                MessageBox.Show("New doctor has been added!");

                command.ExecuteNonQuery();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //clear inputs

            textBox1.Clear();   
            textBox2.Clear();   
            textBox3.Clear();   
            textBox4.Clear();  
            textBox5.Clear();   

            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }
    }
}
