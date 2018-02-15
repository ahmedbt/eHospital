using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace eHospital
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
            tabPage1.Text = @"Doctors";
            tabPage2.Text = @"Patients";
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox5.SizeMode = PictureBoxSizeMode.AutoSize;
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
            removeDoctorsButton.Visible = false;
            removePatientsButton.Visible = false;
        }

        /* Done by Amila Zimic */
        /* Open AddNewDoctorForm */
        private void addNewDoctor_Click(object sender, EventArgs e)     
        {
            var add_new_doctor = new AddNewDoctorForm();
            add_new_doctor.Show();
        }

        /* Done by Amila Zimic */
        /* Show list of doctors in dataGridView */
        private void listDoctorsButton_Click(object sender, EventArgs e)
        {
            /* Connecting to database ehospital */
            string connectionString = "server=localhost;uid=root;pwd=;database=eHospital";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                /* Query that selects id, name, lastname, gender and specialization from table doctors */
                String query = "SELECT id, name, lastname, gender, specialization FROM doctors";       

                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);

                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Visible = true;
                removeDoctorsButton.Visible = false;
            }
        }

        /* Done by Amila Zimic */
        /* Show list of doctors in dataGridView with button Remove */
        private void removeListDoctorsButton_Click(object sender, EventArgs e)
        {
            /* Connecting to database ehospital */
            string connectionString = "server=localhost;uid=root;pwd=;database=ehospital";
             using (MySqlConnection conn = new MySqlConnection(connectionString))
             {
                 conn.Open();

                /* Query that selects id, name, lastname, gender and specialization from table doctors */
                String query1 = "SELECT id, name, lastname, gender, specialization FROM doctors";

                 MySqlDataAdapter adapter = new MySqlDataAdapter(query1, conn);

                 DataSet ds = new DataSet();
                 adapter.Fill(ds);
                 dataGridView1.DataSource = ds.Tables[0];
                 dataGridView1.Visible = true;
                 removeDoctorsButton.Visible = true;
             } 
        }

        /* Done by Ahmed Botonjic */
        /* Remove doctors from dataGridView and database */
        private void removeDoctorsButton_Click(object sender, EventArgs e)
        {
            /* Connecting to database ehospital */
            string connectionString = "server=localhost;uid=root;pwd=;database=eHospital";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                /* Take values from selected row */
                if (dataGridView1.SelectedRows.Count != 0)
                {
                    DataGridViewRow row1 = this.dataGridView1.SelectedRows[0];
                    string doctorid1 = row1.Cells["id"].Value.ToString();
                    dataGridView1.Rows.RemoveAt(row1.Index);

                    /* Query that delete doctor from table whose id is selected */
                    String query = "DELETE FROM doctors WHERE id = " + doctorid1;
                    MySqlCommand command = new MySqlCommand(query, conn);
                    command.ExecuteNonQuery();
                }
                MessageBox.Show("The doctor has been removed!");
            }
        }
        
        /* Done by Amila Zimic */
        /* Logout from first tab*/
        private void logoutT1Button_Click(object sender, EventArgs e)     
        {
            var logout = new LoginForm();                   
            logout.Show();
            this.Hide();
        }

        /* Done by Amila Zimic */
        /* Open AddNewPatientForm */
        private void addNewPatient_Click(object sender, EventArgs e) 
        {
            var add_new_patient = new AddNewPatientForm();
            add_new_patient.Show();
            removePatientsButton.Visible = false;
        }

        /* Done by Amila Zimic */
        /* Show list of patients in dataGridView */
        private void listPatientsButton_Click(object sender, EventArgs e)      
        {
            /* Connecting to database ehospital */
            string connectionString = "server=localhost;uid=root;pwd=;database=ehospital";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                /* Query that selects id, name, lastname and gender from table patients */
                String query1 = "SELECT id, name, lastname, gender FROM patients";       

                MySqlDataAdapter adapter = new MySqlDataAdapter(query1, conn);

                DataSet ds = new DataSet();
                adapter.Fill(ds);
                
                dataGridView2.DataSource = ds.Tables[0];
                dataGridView2.Visible = true;
                removeDoctorsButton.Visible = true;
                removePatientsButton.Visible = false;
            }
        }

        /* Done by Amila Zimic */
        /* Show list of patients in dataGridView */
        private void removeListPatientsButton_Click(object sender, EventArgs e)
        {
            /* Connecting to database ehospital */
            string connectionString = "server=localhost;uid=root;pwd=;database=eHospital";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                /* Query that selects id, name, lastname and gender from table patients */
                String query = "SELECT id, name, lastname, gender FROM patients";       

                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);

                DataSet ds = new DataSet();
                adapter.Fill(ds);
               
                dataGridView2.DataSource = ds.Tables[0];
                dataGridView2.Visible = true;

                removePatientsButton.Visible = true;
            }

        }

        /* Done by Ahmed Botonjic */
        /* Remove patients from dataGridView and database */
        private void removePatientsButton_Click(object sender, EventArgs e)
        {
            /* Connecting to database ehospital */
            string connectionString = "server=localhost;uid=root;pwd=;database=eHospital";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                /* Take values from selected row */
                if (dataGridView2.SelectedRows.Count != 0)
                {
                    DataGridViewRow row1 = this.dataGridView2.SelectedRows[0];
                    string patientid1 = row1.Cells["id"].Value.ToString();
                    dataGridView2.Rows.RemoveAt(row1.Index);

                    /* Query that delete patient from table whose id is selected */
                    string query3 = "DELETE FROM patients WHERE id = " + patientid1;
                    MySqlCommand cmd3 = new MySqlCommand(query3, conn);
                    cmd3.ExecuteNonQuery();
                }

                MessageBox.Show("The patient has been removed!");
            }
        }

        /* Done by Amila Zimic */
        /* Logout from second tab*/
        private void logoutT2Button_Click(object sender, EventArgs e)
        {
            var logout = new LoginForm();
            logout.Show();
            this.Hide();
        }
    }
}

