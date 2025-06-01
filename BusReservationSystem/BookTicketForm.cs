using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BusReservationSystem
{
    public partial class BookTicketForm : Form
    {
        private int userId;

        public BookTicketForm(int loggedInUserId, string userNameFromLogin)
        {
            InitializeComponent();
            userId = loggedInUserId;
            LoadTrips(); // Load TripID list on startup
        }

        private void LoadTrips()
        {
            string connectionString = "server=localhost;user=root;password=your_password;database=BusReservationDB;";
            string query = "SELECT TripID FROM Trips";

            comboTripList.Items.Clear(); // Clear items before loading

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            comboTripList.Items.Add(reader["TripID"].ToString());
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading trips: " + ex.Message);
                }
            }
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            string passengerName = txtPassengerName.Text.Trim();
            string selectedTrip = comboTripList.SelectedItem?.ToString();
            string seatText = txtSeatNumber.Text.Trim();

            if (string.IsNullOrWhiteSpace(passengerName) || string.IsNullOrEmpty(selectedTrip) || string.IsNullOrWhiteSpace(seatText))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (!int.TryParse(seatText, out int seatNumber))
            {
                MessageBox.Show("Seat Number must be a valid number.");
                return;
            }

            string query = "INSERT INTO Tickets (TripID, PassengerName, UserID, SeatNumber) VALUES (@TripID, @PassengerName, @UserID, @SeatNumber)";
            string connectionString = "server=localhost;user=root;password=your_password;database=BusReservationDB;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@TripID", selectedTrip);
                    cmd.Parameters.AddWithValue("@PassengerName", passengerName);
                    cmd.Parameters.AddWithValue("@UserID", userId);
                    cmd.Parameters.AddWithValue("@SeatNumber", seatNumber);

                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Ticket booked successfully!");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Failed to book ticket.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
