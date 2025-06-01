using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BusReservationSystem
{
    public partial class TripListForm : Form
    {
        public TripListForm()
        {
            InitializeComponent();
            this.Load += TripListForm_Load; // Attach the Load event
        }

        private void TripListForm_Load(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;user=root;password=your_password;database=BusReservationDB;";
            string query = "SELECT TripID, BusID, RouteID, DepartureTime, Price FROM Trips";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    dataGridView1.DataSource = table;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading trips: " + ex.Message);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
