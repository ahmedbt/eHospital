using MySql.Data.MySqlClient;
using System;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace eHospital
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
        public String hashing(string pass)
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

        /* Done by Amila Zimic and Ahmed Botonjic */
        /* Save inputs for editing profile */
        private void saveEditButton_Click(object sender, EventArgs e)
        {
            string r = ((LoginForm)f).usernameTextBox.Text;

            /* Done by Ahmed Botonjic */
            /* Cheching which radio button is clicked */
            string gender;
            if (radioButton1.Checked)
                gender = radioButton1.Text;
            else
                gender = radioButton2.Text;

            /* Done by Amila Zimic*/
            /* Connecting to database ehospital */
            string connectionString = "server=localhost;uid=root;pwd=;database=ehospital";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                /* Done by Ahmed Botonjic */
                /* Query that selects logged doctor's id */
                String query0 = "SELECT id FROM doctors WHERE username = '" + r + "'";
                String id;

                MySqlCommand cmd = new MySqlCommand(query0, conn);
                MySqlDataReader reader2 = cmd.ExecuteReader();
                reader2.Read();
                id = reader2.GetString(reader2.GetOrdinal("id"));
                reader2.Close();

                /* Done by Amila Zimic*/
                /* Query that updates table */
                String query = "UPDATE doctors SET name = '" + textBox1.Text + "', lastname = '" + textBox2.Text + "', age = '" + textBox3.Text + "', education = '" + textBox4.Text + "', specialization = '" + textBox5.Text + "', experience = '" + textBox6.Text + "', skills = '" + textBox7.Text + "', gender = '" + gender + "' WHERE id = " + id;
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
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();

            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }
    }
}