using MySql.Data.MySqlClient;
using System;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace eHospitalPatients
{
    public partial class EditProfileForm : Form
    {
        public EditProfileForm()
        {
            InitializeComponent();
        }

        System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["LoginForm"];

        /* Done by Ahmed Botonjic */
        /* Password hashing */
        public String hashing (string pass)
        {
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);

            var pbkdf2 = new Rfc2898DeriveBytes(pass, salt, 10000);
            byte[] hash = pbkdf2.GetBytes(20);

            byte[] hashBytes = new byte[36];
            Array.Copy(salt, 0, hashBytes, 0, 16);
            Array.Copy(hash, 0, hashBytes, 16, 20);

            string savedPasswordHash = Convert.ToBase64String(hashBytes);
            return savedPasswordHash;
        }

        /* Done by Amila Zimic */
        /* Save inputs for editing profile */
        private void saveEditButton_Click(object sender, EventArgs e)
        {
            string r = ((LoginForm)f).usernameTextBox.Text;

            /* Cheching which radio button is clicked */
            string gender;
            if (radioButton1.Checked)
                gender = radioButton1.Text;
            else
                gender = radioButton2.Text;

            /* Connecting to database ehospital */
            string connectionString = "server=localhost;uid=root;pwd=;database=ehospital";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {       
                conn.Open();
                System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["LoginForm"];
               
                /* Query that selects logged patient's id */
                String query0 = "SELECT id FROM patients WHERE username = '" + r + "'";
                String id;
                MySqlCommand cmd = new MySqlCommand(query0, conn);
                MySqlDataReader reader2 = cmd.ExecuteReader();
                reader2.Read();
                id = reader2.GetString(reader2.GetOrdinal("id"));
                reader2.Close();

                /* Query that updates table */
                String query = "UPDATE ehospital.patients SET name = '" + textBox1.Text + "', lastname = '" + textBox2.Text + "', address = '" + textBox3.Text + "', email = '" + textBox4.Text + "', gender = '" + gender + "' WHERE id = '" + id + "' ";
                MySqlCommand command = new MySqlCommand(query, conn);
                MySqlDataReader reader = command.ExecuteReader();

                /* Message for updates */
                MessageBox.Show("Update Successful!", "Success Message!", MessageBoxButtons.OK, MessageBoxIcon.None);

                reader.Close();
            }
        }

        /* Done by Amila Zimic */
        /* Clear inputs */
        private void cancelEditButton_Click(object sender, EventArgs e)
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