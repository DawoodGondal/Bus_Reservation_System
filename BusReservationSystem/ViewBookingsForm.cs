using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BusReservationSystem
{
    public partial class ViewBookingsForm : Form
    {
        string connectionString = "server=localhost;user=root;password=your_password;database=BusReservationDB;";

        public ViewBookingsForm()
        {
            InitializeComponent();
            LoadBookings();
        }

        private void LoadBookings(string search = "", DateTime? filterDate = null)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
                    SELECT 
                        t.TicketID,
                        u.FullName AS UserName,
                        r.Source,
                        r.Destination,
                        tr.TripDate,
                        tr.DepartureTime,
                        tr.ArrivalTime,
                        b.BusNumber,
                        t.SeatNumber,
                        tr.Price,
                        t.BookingDate
                    FROM Tickets t
                    JOIN Users u ON t.UserID = u.UserID
                    JOIN Trips tr ON t.TripID = tr.TripID
                    JOIN Routes r ON tr.RouteID = r.RouteID
                    JOIN Buses b ON tr.BusID = b.BusID
                    WHERE 1=1";

                if (!string.IsNullOrEmpty(search))
                    query += " AND (u.FullName LIKE @search OR u.Email LIKE @search)";

                if (filterDate.HasValue)
                    query += " AND tr.TripDate = @date";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                if (!string.IsNullOrEmpty(search))
                    cmd.Parameters.AddWithValue("@search", "%" + search + "%");

                if (filterDate.HasValue)
                    cmd.Parameters.AddWithValue("@date", filterDate.Value.Date);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvBookings.DataSource = dt;
            }
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            LoadBookings(txtUser.Text.Trim(), dtpDate.Value);
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            LoadBookings(txtUser.Text.Trim(), dtpDate.Value);
        }

        private void dgvBookings_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ViewBookingsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
