using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BusReservationSystem
{
    public partial class ViewUsersForm : Form
    {
        string connectionString = "server=localhost;user=root;password=your_password;database=BusReservationDB;";
        int selectedUserId = -1;

        public ViewUsersForm()
        {
            InitializeComponent();
            LoadUsers();
            dgvUsers.CellClick += dgvUsers_CellClick; // make sure event is hooked
        }

        private void LoadUsers(string searchTerm = "")
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT UserID, FullName, Email, Phone FROM Users";

                if (!string.IsNullOrEmpty(searchTerm))
                {
                    query += " WHERE FullName LIKE @search OR Email LIKE @search";
                }

                MySqlCommand cmd = new MySqlCommand(query, conn);
                if (!string.IsNullOrEmpty(searchTerm))
                    cmd.Parameters.AddWithValue("@search", "%" + searchTerm + "%");

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvUsers.DataSource = dt;

                // Debug: show columns
                Console.WriteLine("Loaded columns:");
                foreach (DataColumn col in dt.Columns)
                {
                    Console.WriteLine(col.ColumnName);
                }
            }
        }

        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dgvUsers.Columns.Contains("UserID"))
                {
                    selectedUserId = Convert.ToInt32(dgvUsers.Rows[e.RowIndex].Cells["UserID"].Value);
                    Console.WriteLine("Selected UserID: " + selectedUserId);
                }
                else
                {
                    MessageBox.Show("UserID column not found in DataGridView.");
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedUserId == -1)
            {
                MessageBox.Show("Please select a user to delete.");
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this user?",
                                                  "Confirm", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM Users WHERE UserID = @userId";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@userId", selectedUserId);

                    try
                    {
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("User deleted successfully!");
                        }
                        else
                        {
                            MessageBox.Show("User not found or already deleted.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting user: " + ex.Message);
                    }

                    LoadUsers();
                    selectedUserId = -1;
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim();
            Console.WriteLine("Searching for: " + searchText);
            LoadUsers(searchText);
        }

        // Add this for a Close button
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
