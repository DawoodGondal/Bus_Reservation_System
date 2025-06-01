using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BusReservationSystem
{
    public partial class ManageRoutesForm : Form
    {
        string connectionString = "server=localhost;user=root;password=your_password;database=BusReservationDB;";

        public ManageRoutesForm()
        {
            InitializeComponent();
            LoadRoutes();
        }

        private void LoadRoutes()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Routes";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dgvRoutes.DataSource = table;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string source = txtSource.Text.Trim();
            string destination = txtDestination.Text.Trim();

            if (source == "" || destination == "")
            {
                MessageBox.Show("Both fields are required.");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Routes (Source, Destination) VALUES (@source, @destination)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@source", source);
                cmd.Parameters.AddWithValue("@destination", destination);
                cmd.ExecuteNonQuery();
            }

            LoadRoutes();
            ClearInputs();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvRoutes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a route to update.");
                return;
            }

            int id = Convert.ToInt32(dgvRoutes.SelectedRows[0].Cells["RouteID"].Value);
            string source = txtSource.Text.Trim();
            string destination = txtDestination.Text.Trim();

            if (source == "" || destination == "")
            {
                MessageBox.Show("Both fields are required.");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE Routes SET Source=@source, Destination=@destination WHERE RouteID=@id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@source", source);
                cmd.Parameters.AddWithValue("@destination", destination);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }

            LoadRoutes();
            ClearInputs();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvRoutes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a route to delete.");
                return;
            }

            int id = Convert.ToInt32(dgvRoutes.SelectedRows[0].Cells["RouteID"].Value);

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                // Check if this route is used in any trip
                string checkQuery = "SELECT COUNT(*) FROM Trips WHERE RouteID = @id";
                MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn);
                checkCmd.Parameters.AddWithValue("@id", id);
                int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                if (count > 0)
                {
                    MessageBox.Show("Cannot delete this route because it is used in a trip.");
                    return;
                }

                var confirm = MessageBox.Show("Are you sure you want to delete this route?", "Confirm", MessageBoxButtons.YesNo);
                if (confirm != DialogResult.Yes) return;

                string deleteQuery = "DELETE FROM Routes WHERE RouteID=@id";
                MySqlCommand deleteCmd = new MySqlCommand(deleteQuery, conn);
                deleteCmd.Parameters.AddWithValue("@id", id);
                deleteCmd.ExecuteNonQuery();
            }

            LoadRoutes();
            ClearInputs();
        }


        private void dgvRoutes_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvRoutes.SelectedRows.Count > 0)
            {
                txtSource.Text = dgvRoutes.SelectedRows[0].Cells["Source"].Value.ToString();
                txtDestination.Text = dgvRoutes.SelectedRows[0].Cells["Destination"].Value.ToString();
            }
        }

        private void ClearInputs()
        {
            txtSource.Clear();
            txtDestination.Clear();
        }
    }
}
