using System;
using System.Windows.Forms;

namespace BusReservationSystem
{
    public partial class AdminDashboard : Form
    {
        private int adminId;
        private string adminName;

        public AdminDashboard(int adminIdFromLogin, string adminNameFromLogin)
        {
            InitializeComponent();
            adminId = adminIdFromLogin;
            adminName = adminNameFromLogin;
            lblWelcome.Text = $"Welcome, {adminName} (Admin)";
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

        private void btnManageBuses_Click(object sender, EventArgs e)
        {
            ManageBusesForm form = new ManageBusesForm();
            form.ShowDialog();
        }

        private void btnManageRoutes_Click(object sender, EventArgs e)
        {
            ManageRoutesForm form = new ManageRoutesForm();
            form.ShowDialog();
        }

        private void btnManageTrips_Click(object sender, EventArgs e)
        {
            ManageTripsForm form = new ManageTripsForm();
            form.ShowDialog();
        }

        private void btnViewUsers_Click(object sender, EventArgs e)
        {
            ViewUsersForm form = new ViewUsersForm();
            form.ShowDialog();
        }

        private void btnViewBookings_Click(object sender, EventArgs e)
        {
            ViewBookingsForm form = new ViewBookingsForm();
            form.ShowDialog();
        }

        private void btnViewPayments_Click(object sender, EventArgs e)
        {
            ViewPaymentsForm form = new ViewPaymentsForm();
            form.ShowDialog();
        }
    }
}
