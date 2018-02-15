using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace eHospitalPatients
{
    public partial class PatientForm : Form
    {
        public PatientForm()
        {
            InitializeComponent();        
        }

        /* Done by Amila Zimic */
        /* Open EditProfileForm */
        private void editProfileButton_Click(object sender, EventArgs e)      
        {
            var edit_profile = new EditProfileForm();
            edit_profile.Show();        
        }

        /* Done by Amila Zimic */
        /* Show list of doctors in dataGridView */
        private void listDoctorsButton_Click(object sender, EventArgs e)
        {
            /* Connecting to database ehospital */
            string connectionString = "server=localhost;uid=root;pwd=;database=ehospital";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                /* Query that selects id, name, lastname and education from table doctors */
                String query = "SELECT id, name, lastname, education FROM doctors";       

                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);

                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Visible = true;
            }
           
        }

        /* Done by Ahmed Botonjic and Amila Zimic */
        /* Show all appointment requests for logged doctor */
        public void checkScheduleButton_Click(object sender, EventArgs e)      
        {
            /* Connecting to database ehospital */
            string connectionString = "server=localhost;uid=root;pwd=;database=ehospital";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                /* Done by Ahmed Botonjic*/
                System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["LoginForm"];
                string r = ((LoginForm)f).usernameTextBox.Text;

                /* Query that selects logged patient's id */
                String query0 = "SELECT id FROM patients WHERE username = '" + r + "'";
                String id;
                MySqlCommand cmd = new MySqlCommand(query0, conn);
                MySqlDataReader reader2 = cmd.ExecuteReader();
                reader2.Read();
                id = reader2.GetString(reader2.GetOrdinal("id"));

                /* Done by Amila Zimic */
                String query = "SELECT * FROM appointments WHERE patientid=" + id;              

                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                reader2.Close();
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Visible = true;
                label1.Visible = false;           
            }
        }

        /* Done by Adnan Talic */
        /* Open MakeAppointmentForm */
        private void makeAppointmnetButton_Click(object sender, EventArgs e)      
        {
            var make_appointment = new makeAppointment();
            make_appointment.Show();        
        }

        /* Done by Amila Zimic */
        /* Logout */
        private void logoutButton_Click(object sender, EventArgs e)     
        {
            this.Close();
        } 
    }
} 
