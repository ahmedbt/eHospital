using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;

namespace eHospital
{
    public partial class DoctorForm : Form
    {
        
        public DoctorForm()
        {
            InitializeComponent();
            acceptButton.Visible = false;
            rejectButton.Visible = false;
        }

        System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["LoginForm"];
        /* Done by Ahmed Botonjic */
        /* Getting doctor's id from login */
        public String doctorid()
        {
            string r = ((LoginForm)f).usernameTextBox.Text;
            String id;
            string connectionString = "server=localhost;uid=root;pwd=;database=eHospital";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                String query0 = "SELECT id FROM doctors WHERE username = '" + r + "'";


                MySqlCommand cmd = new MySqlCommand(query0, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                id = reader.GetString(reader.GetOrdinal("id"));
                reader.Close();
            }
            return id;
        }

        /* Done by Amila Zimic */
        /* Open EditProfileForm */
        private void editDocProfileButton_Click(object sender, EventArgs e)
        {
            var edit_profile = new EditProfileForm();
            edit_profile.Show();
            acceptButton.Visible = false;
            rejectButton.Visible = false;
        }

        /* Done by Amila Zimic */
        /* Show list of all patients in dataGridView */
        private void listPatientsButton_Click(object sender, EventArgs e)
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
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Visible = true;

                acceptButton.Visible = false;
                rejectButton.Visible = false;
            }
        }

        /* Done by Amila Zimic */
        /* Show list of patients in dataGridView who request appointmnet with accept and reject button */
        public void appointmentRequestsButton_Click(object sender, EventArgs e)       
       {
            /* Connecting to database ehospital */
            string connectionString = "server=localhost;uid=root;pwd=;database=eHospital";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string id = doctorid();

                /* Query that selects id, patientid, time and date from table appointments for logged doctor */
                String query = "SELECT id, patientid, time, date FROM appointments WHERE doctorid = "+id;       

                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);

                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Visible = true;

                acceptButton.Visible = true;
                rejectButton.Visible = true;
            }
         }

        /* Done by Ahmed Botonjic */
        /* Send accepting email to patient */
        private void acceptButton_Click(object sender, EventArgs e)      
        {
            /* Connecting to database ehospital */
            string connectionString = "server=localhost;uid=root;pwd=;database=ehospital";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                /* Select patient from dataGridView */
                if (dataGridView1.SelectedRows.Count != 0)
                {
                    DataGridViewRow row1 = this.dataGridView1.SelectedRows[0];
                    string patientid1 = row1.Cells["patientid"].Value.ToString();

                    /* Query that selects email from table patients for selected patient */
                    string query2 = "SELECT email FROM patients WHERE id = " + patientid1;
                    String emailAddress;

                    MySqlCommand cmd = new MySqlCommand(query2, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();
                    emailAddress = reader.GetString(reader.GetOrdinal("email"));

                    /* Setting the smtp protocol */
                    SmtpClient client = new SmtpClient();
                    client.Port = 587;
                    client.Host = "smtp.gmail.com";
                    client.EnableSsl = true;
                    client.Timeout = 10000;
                    client.DeliveryMethod = SmtpDeliveryMethod.Network;
                    client.UseDefaultCredentials = false;
                    client.Credentials = new System.Net.NetworkCredential("doctorehospital@gmail.com", "ehospital");

                    /* Making and sending the message */
                    MailMessage mm = new MailMessage("doctorehospital@gmail.com", emailAddress, "eHospital Appointment", "Dear,\n\n Your appointment request is accepted! See You soon!\n\n Regards,\n eHospital Team");
                    mm.BodyEncoding = UTF8Encoding.UTF8;
                    mm.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;

                    client.Send(mm);
                    MessageBox.Show("You have sent mail successfully");
                    reader.Close();

                    DataGridViewRow row11 = this.dataGridView1.SelectedRows[0];
                    string appointmentid1 = row11.Cells["id"].Value.ToString();

                    /* Query that updates column approven when appointmnet is accepted or rejected */
                    string query4 = "UPDATE appointments SET approven = 1 WHERE id = " + appointmentid1;

                    MySqlCommand cmd4 = new MySqlCommand(query4, conn);
                    MySqlDataReader reader4 = cmd4.ExecuteReader();
                    reader4.Read();
                }
            }
        }

        /* Done by Ahmed Botonjic */
        /* Send rejecting email to patient */
        private void rejectButton_Click(object sender, EventArgs e)      
        {
            /* Connecting to database ehospital */
            string doctorId = doctorid();
            string connectionString = "server=localhost;uid=root;pwd=;database=eHospital";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                /* Select patient from dataGridView */
                if (dataGridView1.SelectedRows.Count != 0)
                {
                    DataGridViewRow row1 = this.dataGridView1.SelectedRows[0];
                    string patientid1 = row1.Cells["patientid"].Value.ToString();
                    dataGridView1.Rows.RemoveAt(row1.Index);

                    /* Query that selects email from table patients for selected patient */
                    string query2 = "SELECT email FROM patients WHERE id = " + patientid1;
                    String emailAddress;

                    MySqlCommand cmd = new MySqlCommand(query2, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();
                    emailAddress = reader.GetString(reader.GetOrdinal("email"));

                    /* Setting the smtp protocol */
                    SmtpClient client = new SmtpClient();
                    client.Port = 587;
                    client.Host = "smtp.gmail.com";
                    client.EnableSsl = true;
                    client.Timeout = 10000;
                    client.DeliveryMethod = SmtpDeliveryMethod.Network;
                    client.UseDefaultCredentials = false;
                    client.Credentials = new System.Net.NetworkCredential("doctorehospital@gmail.com", "ehospital");

                    /* Making and sending the message */
                    MailMessage mm = new MailMessage("doctorehospital@gmail.com", emailAddress, "eHospital Appointment", "Dear,\n\n Your appointment request is not accepted! Please, try again!\n\n Regards,\n eHospital Team");
                    mm.BodyEncoding = UTF8Encoding.UTF8;
                    mm.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;

                    client.Send(mm);
                    MessageBox.Show("You have sent mail successfully");

                    reader.Close();

                    /* Query that deletes rejected patient's appoitnment */
                    string query3 = "DELETE FROM `appointments` WHERE `patientid`=" + patientid1 + " AND doctorid = " + doctorId;
                    MySqlCommand cmd3 = new MySqlCommand(query3, conn);
                    cmd3.ExecuteNonQuery();
                }
            }
        }

        /* Done by Ahmed Botonjic and Adnan Talic */
        /* Show all appointments that doctor accepted */
        private void checkScheduleButton_Click(object sender, EventArgs e) 
        {
            /* Connecting to database ehospital */
            string connectionString = "server=localhost;uid=root;pwd=;database=eHospital";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string id = doctorid();

                /* Query that selects patientid, time and date from table appointments that doctor accepted for logged doctor */
                String query = "SELECT patientid, time, date FROM appointments WHERE approven = 1 AND doctorid = " + id;

                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);

                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Visible = true;

                acceptButton.Visible = false;
                rejectButton.Visible = false;
            }
        }

        /* Done by Amila Zimic */
        /* Logout */
        private void logoutDoctorButton_Click(object sender, EventArgs e)
        {
            var logout = new LoginForm();                 
            logout.Show();
            this.Hide();
        }
    }
}
