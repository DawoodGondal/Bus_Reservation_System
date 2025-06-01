namespace BusReservationSystem
{
    partial class StartForm
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
            this.btnUserRegister = new System.Windows.Forms.Button();
            this.btnUserLogin = new System.Windows.Forms.Button();
            this.btnAdminRegister = new System.Windows.Forms.Button();
            this.btnAdminLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // Form settings
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bus Reservation System - Start";
            this.BackColor = System.Drawing.Color.WhiteSmoke;

            // Button common style
            System.Drawing.Size buttonSize = new System.Drawing.Size(300, 50);
            System.Drawing.Font buttonFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            System.Drawing.Color buttonBackColor = System.Drawing.Color.FromArgb(0, 123, 255); // blue
            System.Drawing.Color buttonForeColor = System.Drawing.Color.White;

            // btnUserRegister
            this.btnUserRegister.BackColor = buttonBackColor;
            this.btnUserRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserRegister.Font = buttonFont;
            this.btnUserRegister.ForeColor = buttonForeColor;
            this.btnUserRegister.Location = new System.Drawing.Point(250, 50);
            this.btnUserRegister.Size = buttonSize;
            this.btnUserRegister.Text = "Register User";
            this.btnUserRegister.UseVisualStyleBackColor = false;
            this.btnUserRegister.Click += new System.EventHandler(this.btnUserRegister_Click);

            // btnUserLogin
            this.btnUserLogin.BackColor = buttonBackColor;
            this.btnUserLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserLogin.Font = buttonFont;
            this.btnUserLogin.ForeColor = buttonForeColor;
            this.btnUserLogin.Location = new System.Drawing.Point(250, 130);
            this.btnUserLogin.Size = buttonSize;
            this.btnUserLogin.Text = "Login as User";
            this.btnUserLogin.UseVisualStyleBackColor = false;
            this.btnUserLogin.Click += new System.EventHandler(this.btnUserLogin_Click);

            // btnAdminRegister
            this.btnAdminRegister.BackColor = buttonBackColor;
            this.btnAdminRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminRegister.Font = buttonFont;
            this.btnAdminRegister.ForeColor = buttonForeColor;
            this.btnAdminRegister.Location = new System.Drawing.Point(250, 210);
            this.btnAdminRegister.Size = buttonSize;
            this.btnAdminRegister.Text = "Register Admin";
            this.btnAdminRegister.UseVisualStyleBackColor = false;
            this.btnAdminRegister.Click += new System.EventHandler(this.btnAdminRegister_Click);

            // btnAdminLogin
            this.btnAdminLogin.BackColor = buttonBackColor;
            this.btnAdminLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminLogin.Font = buttonFont;
            this.btnAdminLogin.ForeColor = buttonForeColor;
            this.btnAdminLogin.Location = new System.Drawing.Point(250, 290);
            this.btnAdminLogin.Size = buttonSize;
            this.btnAdminLogin.Text = "Login as Admin";
            this.btnAdminLogin.UseVisualStyleBackColor = false;
            this.btnAdminLogin.Click += new System.EventHandler(this.btnAdminLogin_Click);

            // Add buttons
            this.Controls.Add(this.btnUserRegister);
            this.Controls.Add(this.btnUserLogin);
            this.Controls.Add(this.btnAdminRegister);
            this.Controls.Add(this.btnAdminLogin);

            this.ResumeLayout(false);
        }


        #endregion

        private System.Windows.Forms.Button btnUserLogin;
        private System.Windows.Forms.Button btnUserRegister;
        private System.Windows.Forms.Button btnAdminLogin;
        private System.Windows.Forms.Button btnAdminRegister;
    }
}