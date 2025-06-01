using System;
using System.Windows.Forms;

namespace BusReservationSystem
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void btnUserLogin_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void btnUserRegister_Click(object sender, EventArgs e)
        {
            UserRegisterForm registerForm = new UserRegisterForm();
            registerForm.Show();
            this.Hide();
        }

        private void btnAdminLogin_Click(object sender, EventArgs e)
        {
            // We'll create this later
            AdminLoginForm adminLogin = new AdminLoginForm();
            adminLogin.Show();
            this.Hide();
        }

        private void btnAdminRegister_Click(object sender, EventArgs e)
        {
            AdminRegisterForm adminRegister = new AdminRegisterForm();
            adminRegister.Show();
            this.Hide();
        }
    }
}
