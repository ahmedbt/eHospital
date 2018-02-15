using MySql.Data.MySqlClient;
using System;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace eHospital
{
    public partial class AddNewPatientForm : Form
    {
        public AddNewPatientForm()
        {
            InitializeComponent();
        }

        /* Done by Amila Zimic */
        /* Add new patient into database */
        private void saveNewPatient_Click(object sender, EventArgs e)
        {
            /* Connecting to database ehospital */
            string connectionString = "server=localhost;uid=root;pwd=;database=eHospital";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                /* Done by Ahmed Botonjic */
                /* Hashing password */
                byte[] salt;
                new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);

                var pbkdf2 = new Rfc2898DeriveBytes(textBox2.Text, salt, 10000);
                byte[] hash = pbkdf2.GetBytes(20);

                byte[] hashBytes = new byte[36];
                Array.Copy(salt, 0, hashBytes, 0, 16);
                Array.Copy(hash, 0, hashBytes, 16, 20);

                string savedPasswordHash = Convert.ToBase64String(hashBytes);

                /* Done by Amila Zimic */
                /* Query that inserts values into doctors table */
                String query = "INSERT INTO patients (username, password, name, lastname, gender) VALUES (@username,@password, @name, @lastname, @gender)";

                MySqlCommand command = new MySqlCommand(query, conn);

                command.Parameters.AddWithValue("@username", textBox1.Text);
                command.Parameters.AddWithValue("@password", savedPasswordHash);
                command.Parameters.AddWithValue("@name", textBox3.Text);
                command.Parameters.AddWithValue("@lastname", textBox4.Text);

                /* Done by Amila Zimic */
                /* Cheching which radio button is clicked */
                if (radioButton1.Checked)
                    command.Parameters.AddWithValue("@gender", "female");
                else
                    command.Parameters.AddWithValue("@gender", "male");

                MessageBox.Show("New patient has been added!");

                command.ExecuteNonQuery();
            }
        }

        /* Done by Amila Zimic */
        /* Clear inputs */
        private void cancelNewPatient_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();

            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }
    }
}
