using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BusReservationSystem
{
    public partial class ManageTripsForm : Form
    {
        string connectionString = "server=localhost;user=root;password=your_password;database=BusReservationDB;";
        int selectedTripId = -1;

        public ManageTripsForm()
        {
            InitializeComponent();
            LoadRoutes();
            LoadBuses();
            LoadTrips();
        }

        private void LoadRoutes()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT RouteID, CONCAT(Source, ' → ', Destination) AS Route FROM Routes";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);

                cmbRoute.DataSource = dt;
                cmbRoute.DisplayMember = "Route";
                cmbRoute.ValueMember = "RouteID";
            }
        }

        private void LoadBuses()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT BusID, BusNumber FROM Buses";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);

                cmbBus.DataSource = dt;
                cmbBus.DisplayMember = "BusNumber";
                cmbBus.ValueMember = "BusID";
            }
        }

        private void LoadTrips()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = @"SELECT T.TripID, 
                                        CONCAT(R.Source, ' → ', R.Destination) AS Route,
                                        B.BusNumber, 
                                        T.TripDate, 
                                        T.DepartureTime, 
                                        T.ArrivalTime, 
                                        T.Price
                                 FROM Trips T
                                 JOIN Routes R ON T.RouteID = R.RouteID
                                 JOIN Buses B ON T.BusID = B.BusID";

                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvTrips.DataSource = dt;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int routeId = Convert.ToInt32(cmbRoute.SelectedValue);
            int busId = Convert.ToInt32(cmbBus.SelectedValue);
            DateTime tripDate = dtpTripDate.Value.Date;
            string departureTime = dtpDepartureTime.Value.ToString("HH:mm:ss");
            string arrivalTime = dtpArrivalTime.Value.ToString("HH:mm:ss");

            decimal price;
            if (!decimal.TryParse(txtPrice.Text.Trim(), out price))
            {
                MessageBox.Show("Please enter a valid numeric value for price.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = @"INSERT INTO Trips (RouteID, BusID, TripDate, DepartureTime, ArrivalTime, Price)
                                 VALUES (@routeId, @busId, @tripDate, @departureTime, @arrivalTime, @price)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@routeId", routeId);
                cmd.Parameters.AddWithValue("@busId", busId);
                cmd.Parameters.AddWithValue("@tripDate", tripDate);
                cmd.Parameters.AddWithValue("@departureTime", departureTime);
                cmd.Parameters.AddWithValue("@arrivalTime", arrivalTime);
                cmd.Parameters.AddWithValue("@price", price);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Trip added successfully!");
                LoadTrips();
            }
        }

        private void dgvTrips_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedTripId = Convert.ToInt32(dgvTrips.Rows[e.RowIndex].Cells["TripID"].Value);
                cmbRoute.Text = dgvTrips.Rows[e.RowIndex].Cells["Route"].Value.ToString();
                cmbBus.Text = dgvTrips.Rows[e.RowIndex].Cells["BusNumber"].Value.ToString();
                dtpTripDate.Value = Convert.ToDateTime(dgvTrips.Rows[e.RowIndex].Cells["TripDate"].Value);
                dtpDepartureTime.Value = DateTime.Today.Add(TimeSpan.Parse(dgvTrips.Rows[e.RowIndex].Cells["DepartureTime"].Value.ToString()));
                dtpArrivalTime.Value = DateTime.Today.Add(TimeSpan.Parse(dgvTrips.Rows[e.RowIndex].Cells["ArrivalTime"].Value.ToString()));
                txtPrice.Text = dgvTrips.Rows[e.RowIndex].Cells["Price"].Value.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedTripId == -1)
            {
                MessageBox.Show("Please select a trip to update.");
                return;
            }

            int routeId = Convert.ToInt32(cmbRoute.SelectedValue);
            int busId = Convert.ToInt32(cmbBus.SelectedValue);
            DateTime tripDate = dtpTripDate.Value.Date;
            TimeSpan departureTime = dtpDepartureTime.Value.TimeOfDay;
            TimeSpan arrivalTime = dtpArrivalTime.Value.TimeOfDay;

            decimal price;
            if (!decimal.TryParse(txtPrice.Text.Trim(), out price))
            {
                MessageBox.Show("Please enter a valid price.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = @"UPDATE Trips SET RouteID=@routeId, BusID=@busId, TripDate=@tripDate, 
                                 DepartureTime=@departureTime, ArrivalTime=@arrivalTime, Price=@price
                                 WHERE TripID=@tripId";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@routeId", routeId);
                cmd.Parameters.AddWithValue("@busId", busId);
                cmd.Parameters.AddWithValue("@tripDate", tripDate);
                cmd.Parameters.AddWithValue("@departureTime", departureTime);
                cmd.Parameters.AddWithValue("@arrivalTime", arrivalTime);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@tripId", selectedTripId);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Trip updated successfully!");
                LoadTrips();
                selectedTripId = -1;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvTrips.CurrentRow == null || dgvTrips.CurrentRow.Cells["TripID"].Value == null)
            {
                MessageBox.Show("Please select a trip to delete.");
                return;
            }

            int tripId;
            if (!int.TryParse(dgvTrips.CurrentRow.Cells["TripID"].Value.ToString(), out tripId))
            {
                MessageBox.Show("Invalid trip selection.");
                return;
            }

            selectedTripId = tripId;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                // Check for existing tickets
                string checkQuery = "SELECT COUNT(*) FROM Tickets WHERE TripID = @tripId";
                MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn);
                checkCmd.Parameters.AddWithValue("@tripId", selectedTripId);

                int ticketCount = Convert.ToInt32(checkCmd.ExecuteScalar());

                if (ticketCount > 0)
                {
                    MessageBox.Show("Cannot delete this trip because there are existing tickets associated with it.",
                                    "Deletion Blocked", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult result = MessageBox.Show("Are you sure you want to delete this trip?",
                                                      "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result != DialogResult.Yes)
                    return;

                string deleteQuery = "DELETE FROM Trips WHERE TripID = @tripId";
                MySqlCommand deleteCmd = new MySqlCommand(deleteQuery, conn);
                deleteCmd.Parameters.AddWithValue("@tripId", selectedTripId);
                deleteCmd.ExecuteNonQuery();

                MessageBox.Show("Trip deleted successfully!");
                LoadTrips();
                selectedTripId = -1;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}






