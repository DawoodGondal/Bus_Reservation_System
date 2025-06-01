using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BusReservationSystem
{
    public partial class ViewTicketsForm : Form
    {
        private int userId;

        public ViewTicketsForm(int loggedInUserId)
        {
            InitializeComponent();
            userId = loggedInUserId;
            LoadUserTickets();
        }

        private void LoadUserTickets()
        {
            string connectionString = "server=localhost;user=root;password=your_password;database=BusReservationDB;";
            string query = "SELECT TicketID, TripID, SeatNumber FROM Tickets WHERE UserID = @userId";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@userId", userId);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridViewTickets.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading tickets: " + ex.Message);
                }
            }
        }

        private void dataGridViewTickets_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
