using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BusReservationSystem
{
    public partial class AdminLoginForm : Form
    {
        public AdminLoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text;

            string connectionString = "server=localhost;user=root;password=your_password;database=BusReservationDB;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT * FROM Admin WHERE Email = @email AND Password = @password";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@password", password);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();
                        int adminId = Convert.ToInt32(reader["AdminID"]);
                        string adminName = reader["username"].ToString();

                        MessageBox.Show("Admin login successful!");
                        AdminDashboard dashboard = new AdminDashboard(adminId, adminName);
                        dashboard.Show();
                        this.Hide();
                    }
                    else
                    {
                        lblMessage.Text = "Invalid admin credentials.";
                        lblMessage.ForeColor = Color.Red;
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
