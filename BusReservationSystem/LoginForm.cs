using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BusReservationSystem
{
    public partial class LoginForm : Form



    {


        public LoginForm()
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

                    string query = "SELECT * FROM Users WHERE Email = @email AND Password = @password";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@password", password);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read(); // moves to the first row

                        int userId = Convert.ToInt32(reader["UserID"]);
                        string userName = reader["FullName"].ToString(); // or "UserName" based on your DB

                        MessageBox.Show("Login successful!");
                        UserDashboard dashboard = new UserDashboard(userId, userName);
                        dashboard.Show();
                        this.Hide();
                    }
                    else
                    {
                        lblMessage.Text = "Invalid email or password.";
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
