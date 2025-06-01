using System;
using System.Windows.Forms;

namespace BusReservationSystem
{
    public partial class UserDashboard : Form
    {
        private int userId;
        private string userName;

        // ✅ Only ONE constructor now — pass both userId and userName from LoginForm
        public UserDashboard(int userIdFromLogin, string userNameFromLogin)
        {
            InitializeComponent();
            userId = userIdFromLogin;
            userName = userNameFromLogin;
            lblWelcome.Text = $"Welcome, {userName}!";
        }


        private void btnViewTrips_Click(object sender, EventArgs e)
        {
            TripListForm tripForm = new TripListForm();
            tripForm.ShowDialog();
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            BookTicketForm form = new BookTicketForm(userId, userName);  // ✅ Pass both values
            form.ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            // Can leave this empty or remove
        }

        private void btnTickets_Click(object sender, EventArgs e)
        {
            ViewTicketsForm form = new ViewTicketsForm(userId); // Pass stored userId
            form.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                this.Hide();
                StartForm form = new StartForm();
                form.Show();
            }

        }
    }
}
