using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace eHospitalPatients
{
    public partial class makeAppointment : Form
    {
        /* Whole MakeAppointmentForm is done by Adnan Talic*/
        public makeAppointment()
        {
            InitializeComponent();
        }

        /* Show doctor's id, name, lastname from table doctors*/
        private void makeAppointment_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Time;
            dateTimePicker1.ShowUpDown = true;

            string connectionString = "server=localhost;uid=root;pwd=;database=ehospital";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                String query = "SELECT id, name, lastname FROM doctors";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);

                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Visible = true;
            }
        }

        /* Save appointment into table appointmnets*/
        private void saveAppointment_Click(object sender, EventArgs e)
        {
            DateTime date = dateTimePicker2.Value.Date;
            TimeSpan time = dateTimePicker1.Value.TimeOfDay;

            /* Connecting to database ehospital */
            string connectionString = "server=localhost;uid=root;pwd=;database=ehospital";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["LoginForm"];
                string r = ((LoginForm)f).usernameTextBox.Text;

                /* Query that selects id of logged patient */
                String query0 = "SELECT id FROM patients WHERE username = '" + r + "'";
                String id;

                MySqlCommand cmd = new MySqlCommand(query0, conn);
                MySqlDataReader reader2 = cmd.ExecuteReader();
                reader2.Read();
                id = reader2.GetString(reader2.GetOrdinal("id"));

                /* Query that inserts picked value into appointmnets table */
                String query = "INSERT INTO appointments (doctorid, patientid, time, date, approven) VALUES (@doctorid, @patientid, @time, @date, @approven)";

                MySqlCommand command = new MySqlCommand(query, conn);

                var index = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

                command.Parameters.AddWithValue("@doctorid", index);
                command.Parameters.AddWithValue("@patientid", id);
                command.Parameters.AddWithValue("@time", time);
                command.Parameters.AddWithValue("@date", date);
                command.Parameters.AddWithValue("@approven", "0");

                reader2.Close();

                MessageBox.Show("New appointment has been added!");

                command.ExecuteNonQuery();

            }
        }
    }
}
