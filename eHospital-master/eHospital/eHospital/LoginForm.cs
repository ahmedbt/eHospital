using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace eHospital
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            passwordTextBox.PasswordChar = '*';
        }

        /* Done by Amila Zimic */
        /* Enter instead of button */
        private void textBox1_KeyDown(object sender, KeyEventArgs e)        
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginButton.PerformClick();

                /* These two lines to turn of sound */
                e.SuppressKeyPress = true;                                  
                e.Handled = true;
            }
        }

        /* Done by Amila Zimic */
        /* Accept enter as login button */
        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.AcceptButton = loginButton;                                     
        }

        /* Done by Ahmed Botonjic */
        /* Check if patient exists and open PatientForm */
        private void loginButton_Click(object sender, EventArgs e)
        {
            
            string username = usernameTextBox.Text;
            int c = 0;

            /* Checking is it admin or not */
            if (usernameTextBox.Text == "admin" & passwordTextBox.Text == "12345")      
            {
                var admin_view = new AdminForm();
                admin_view.Show();
                this.Hide();
                goto end;
            }

            /* Connecting to database ehospital */
            string connectionString = "server=localhost;uid=root;pwd=;database=ehospital";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                    /* Query that selects all patients with that username */
                    String query = "SELECT * FROM doctors WHERE username = '" + username + "'";

                     MySqlCommand command = new MySqlCommand(query, conn);
                     MySqlDataReader reader = command.ExecuteReader();

                     if (reader.Read())
                     {
                        reader.Close();

                        /* Query that selects password with that username */
                        string query2 = "SELECT password FROM doctors WHERE username = '" + username + "'";
                        String pass;

                        MySqlCommand cmd = new MySqlCommand(query2, conn);
                        MySqlDataReader reader2 = cmd.ExecuteReader();
                        reader2.Read();
                        pass = reader2.GetString(reader2.GetOrdinal("password"));
                    
                        /* Extract the bytes */
                        byte[] hashBytes = Convert.FromBase64String(pass);

                        /* Get the salt */
                        byte[] salt = new byte[16];
                        Array.Copy(hashBytes, 0, salt, 0, 16);

                        /* Compute the hash on the password the user entered */
                        var pbkdf2 = new Rfc2898DeriveBytes(passwordTextBox.Text, salt, 10000);
                        byte[] hash = pbkdf2.GetBytes(20);

                        /* Compare the results */
                        for (int i = 0; i < 20; i++)
                            if (hashBytes[i + 16] == hash[i])
                            {
                                c++;
                            }

                    /* Open DoctorForm */
                    if (c == 20)
                        {
                            var doctor_view = new DoctorForm();                             
                            doctor_view.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Login Unsuccessful!", "Error Message!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                     else
                     {
                         MessageBox.Show("Login Unsuccessful!", "Error Message!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                     }
            }
        end:
            int r;
        }

        /* Done by Amila Zimic */
        /* Clear inputs */
        private void cancelButton_Click(object sender, EventArgs e)              
        {
            usernameTextBox.Clear();   
            passwordTextBox.Clear();   
        }
    }
}