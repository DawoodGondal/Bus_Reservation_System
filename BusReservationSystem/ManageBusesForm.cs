using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BusReservationSystem
{
    public partial class ManageBusesForm : Form
    {
        string connectionString = "server=localhost;user=root;password=your_password;database=BusReservationDB;";

        public ManageBusesForm()
        {
            InitializeComponent();
            LoadBuses();
        }

        private void LoadBuses()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Buses";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dgvBuses.DataSource = table;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string number = txtBusNumber.Text.Trim();
            string type = cmbBusType.Text;
            int capacity;

            if (!int.TryParse(txtCapacity.Text, out capacity))
            {
                MessageBox.Show("Enter a valid number for Capacity.");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Buses (BusNumber, BusType, Capacity) VALUES (@number, @type, @capacity)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@number", number);
                cmd.Parameters.AddWithValue("@type", type);
                cmd.Parameters.AddWithValue("@capacity", capacity);
                cmd.ExecuteNonQuery();
            }

            LoadBuses();
            ClearInputs();
            MessageBox.Show("Bus added successfully.");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvBuses.CurrentRow == null || dgvBuses.CurrentRow.Index < 0)
            {
                MessageBox.Show("Please select a bus to update.");
                return;
            }

            int id = Convert.ToInt32(dgvBuses.CurrentRow.Cells["BusID"].Value);
            string number = txtBusNumber.Text.Trim();
            string type = cmbBusType.Text;
            int capacity;

            if (!int.TryParse(txtCapacity.Text, out capacity))
            {
                MessageBox.Show("Invalid Capacity.");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE Buses SET BusNumber=@number, BusType=@type, Capacity=@capacity WHERE BusID=@id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@number", number);
                cmd.Parameters.AddWithValue("@type", type);
                cmd.Parameters.AddWithValue("@capacity", capacity);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }

            LoadBuses();
            ClearInputs();
            MessageBox.Show("Bus updated successfully.");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvBuses.CurrentRow == null || dgvBuses.CurrentRow.Index < 0)
            {
                MessageBox.Show("Please select a bus to delete.");
                return;
            }

            int id = Convert.ToInt32(dgvBuses.CurrentRow.Cells["BusID"].Value);

            var confirm = MessageBox.Show("Are you sure you want to delete this bus?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM Buses WHERE BusID=@id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();

                    LoadBuses();
                    ClearInputs();
                    MessageBox.Show("Bus deleted successfully.");
                }
                catch (MySqlException ex)
                {
                    if (ex.Message.Contains("Cannot delete or update a parent row"))
                    {
                        MessageBox.Show("This bus is linked to existing trips and cannot be deleted.", "Deletion Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }



        private void ClearInputs()
        {
            txtBusNumber.Clear();
            cmbBusType.SelectedIndex = -1;
            txtCapacity.Clear();
        }
    }
}
