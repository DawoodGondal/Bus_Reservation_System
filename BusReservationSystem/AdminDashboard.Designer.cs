namespace BusReservationSystem
{
    partial class AdminDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnManageBuses = new System.Windows.Forms.Button();
            this.btnManageTrips = new System.Windows.Forms.Button();
            this.btnViewPayments = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnManageRoutes = new System.Windows.Forms.Button();
            this.btnViewUsers = new System.Windows.Forms.Button();
            this.btnViewBookings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.Location = new System.Drawing.Point(0, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(179, 28);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome, Admin!";
            // 
            // btnManageBuses
            // 
            this.btnManageBuses.Location = new System.Drawing.Point(250, 80);
            this.btnManageBuses.Name = "btnManageBuses";
            this.btnManageBuses.Size = new System.Drawing.Size(300, 40);
            this.btnManageBuses.TabIndex = 1;
            this.btnManageBuses.Text = "Manage Buses";
            this.btnManageBuses.UseVisualStyleBackColor = true;
            this.btnManageBuses.Click += new System.EventHandler(this.btnManageBuses_Click);
            // 
            // btnManageTrips
            // 
            this.btnManageTrips.Location = new System.Drawing.Point(250, 180);
            this.btnManageTrips.Name = "btnManageTrips";
            this.btnManageTrips.Size = new System.Drawing.Size(300, 40);
            this.btnManageTrips.TabIndex = 3;
            this.btnManageTrips.Text = "Schedule Trips";
            this.btnManageTrips.UseVisualStyleBackColor = true;
            this.btnManageTrips.Click += new System.EventHandler(this.btnManageTrips_Click);
            // 
            // btnViewPayments
            // 
            this.btnViewPayments.Location = new System.Drawing.Point(250, 330);
            this.btnViewPayments.Name = "btnViewPayments";
            this.btnViewPayments.Size = new System.Drawing.Size(300, 40);
            this.btnViewPayments.TabIndex = 6;
            this.btnViewPayments.Text = "View Payments";
            this.btnViewPayments.UseVisualStyleBackColor = true;
            this.btnViewPayments.Click += new System.EventHandler(this.btnViewPayments_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(250, 380);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(300, 40);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnManageRoutes
            // 
            this.btnManageRoutes.Location = new System.Drawing.Point(250, 130);
            this.btnManageRoutes.Name = "btnManageRoutes";
            this.btnManageRoutes.Size = new System.Drawing.Size(300, 40);
            this.btnManageRoutes.TabIndex = 2;
            this.btnManageRoutes.Text = "Manage Routes";
            this.btnManageRoutes.UseVisualStyleBackColor = true;
            this.btnManageRoutes.Click += new System.EventHandler(this.btnManageRoutes_Click);
            // 
            // btnViewUsers
            // 
            this.btnViewUsers.Location = new System.Drawing.Point(250, 230);
            this.btnViewUsers.Name = "btnViewUsers";
            this.btnViewUsers.Size = new System.Drawing.Size(300, 40);
            this.btnViewUsers.TabIndex = 4;
            this.btnViewUsers.Text = "View Users";
            this.btnViewUsers.UseVisualStyleBackColor = true;
            this.btnViewUsers.Click += new System.EventHandler(this.btnViewUsers_Click);
            // 
            // btnViewBookings
            // 
            this.btnViewBookings.Location = new System.Drawing.Point(250, 280);
            this.btnViewBookings.Name = "btnViewBookings";
            this.btnViewBookings.Size = new System.Drawing.Size(300, 40);
            this.btnViewBookings.TabIndex = 5;
            this.btnViewBookings.Text = "View Bookings";
            this.btnViewBookings.UseVisualStyleBackColor = true;
            this.btnViewBookings.Click += new System.EventHandler(this.btnViewBookings_Click);
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnManageBuses);
            this.Controls.Add(this.btnManageRoutes);
            this.Controls.Add(this.btnManageTrips);
            this.Controls.Add(this.btnViewUsers);
            this.Controls.Add(this.btnViewBookings);
            this.Controls.Add(this.btnViewPayments);
            this.Controls.Add(this.btnLogout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnManageBuses;
        private System.Windows.Forms.Button btnManageTrips;
        private System.Windows.Forms.Button btnViewPayments;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnManageRoutes;
        private System.Windows.Forms.Button btnViewUsers;
        private System.Windows.Forms.Button btnViewBookings;
    }
}