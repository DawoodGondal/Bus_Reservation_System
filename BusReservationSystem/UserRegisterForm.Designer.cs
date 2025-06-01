namespace BusReservationSystem
{
    partial class UserRegisterForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // Form settings
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Registration";
            this.BackColor = System.Drawing.Color.WhiteSmoke;

            // Common styles
            System.Drawing.Font labelFont = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);
            System.Drawing.Font inputFont = new System.Drawing.Font("Segoe UI", 10F);
            System.Drawing.Size inputSize = new System.Drawing.Size(300, 26);
            int leftMargin = 250;
            int labelWidth = 100;

            // label1 - Name
            this.label1.AutoSize = true;
            this.label1.Font = labelFont;
            this.label1.Location = new System.Drawing.Point(leftMargin - labelWidth, 80);
            this.label1.Size = new System.Drawing.Size(labelWidth, 23);
            this.label1.Text = "Full Name";

            this.txtName.Font = inputFont;
            this.txtName.Location = new System.Drawing.Point(leftMargin, 80);
            this.txtName.Size = inputSize;

            // label2 - Email
            this.label2.AutoSize = true;
            this.label2.Font = labelFont;
            this.label2.Location = new System.Drawing.Point(leftMargin - labelWidth, 130);
            this.label2.Size = new System.Drawing.Size(labelWidth, 23);
            this.label2.Text = "Email";

            this.txtEmail.Font = inputFont;
            this.txtEmail.Location = new System.Drawing.Point(leftMargin, 130);
            this.txtEmail.Size = inputSize;

            // label3 - Password
            this.label3.AutoSize = true;
            this.label3.Font = labelFont;
            this.label3.Location = new System.Drawing.Point(leftMargin - labelWidth, 180);
            this.label3.Size = new System.Drawing.Size(labelWidth, 23);
            this.label3.Text = "Password";

            this.txtPassword.Font = inputFont;
            this.txtPassword.Location = new System.Drawing.Point(leftMargin, 180);
            this.txtPassword.Size = inputSize;
            this.txtPassword.UseSystemPasswordChar = true;

            // label4 - Phone
            this.label4.AutoSize = true;
            this.label4.Font = labelFont;
            this.label4.Location = new System.Drawing.Point(leftMargin - labelWidth, 230);
            this.label4.Size = new System.Drawing.Size(labelWidth, 23);
            this.label4.Text = "Phone";

            this.txtPhone.Font = inputFont;
            this.txtPhone.Location = new System.Drawing.Point(leftMargin, 230);
            this.txtPhone.Size = inputSize;

            // btnRegister
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(0, 123, 255);
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(180, 320);
            this.btnRegister.Size = new System.Drawing.Size(200, 40);
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);

            // btnClose
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnClose.BackColor = System.Drawing.Color.Gray;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(420, 320);
            this.btnClose.Size = new System.Drawing.Size(200, 40);
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);

            // Add controls
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnClose);

            this.ResumeLayout(false);
            this.PerformLayout();
        }


        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnClose;
    }
}