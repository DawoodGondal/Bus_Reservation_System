namespace BusReservationSystem
{
    partial class BookTicketForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.comboTripList = new System.Windows.Forms.ComboBox();
            this.txtPassengerName = new System.Windows.Forms.TextBox();
            this.btnBook = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSeatNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboTripList
            // 
            this.comboTripList.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboTripList.FormattingEnabled = true;
            this.comboTripList.Location = new System.Drawing.Point(200, 80);
            this.comboTripList.Name = "comboTripList";
            this.comboTripList.Size = new System.Drawing.Size(400, 31);
            this.comboTripList.TabIndex = 0;
            // 
            // txtPassengerName
            // 
            this.txtPassengerName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPassengerName.Location = new System.Drawing.Point(200, 160);
            this.txtPassengerName.Name = "txtPassengerName";
            this.txtPassengerName.Size = new System.Drawing.Size(400, 30);
            this.txtPassengerName.TabIndex = 1;
            // 
            // btnBook
            // 
            this.btnBook.BackColor = System.Drawing.Color.FromArgb(46, 204, 113); // modern green
            this.btnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBook.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnBook.ForeColor = System.Drawing.Color.White;
            this.btnBook.Location = new System.Drawing.Point(200, 360);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(400, 45);
            this.btnBook.TabIndex = 2;
            this.btnBook.Text = "Book Ticket";
            this.btnBook.UseVisualStyleBackColor = false;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);
            this.label2.Location = new System.Drawing.Point(200, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Select Trip ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);
            this.label3.Location = new System.Drawing.Point(200, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Passenger Full Name";
            // 
            // txtSeatNumber
            // 
            this.txtSeatNumber.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSeatNumber.Location = new System.Drawing.Point(200, 240);
            this.txtSeatNumber.Name = "txtSeatNumber";
            this.txtSeatNumber.Size = new System.Drawing.Size(400, 30);
            this.txtSeatNumber.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);
            this.label1.Location = new System.Drawing.Point(200, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Seat Number";
            // 
            // BookTicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSeatNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.txtPassengerName);
            this.Controls.Add(this.comboTripList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BookTicketForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book Ticket";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboTripList;
        private System.Windows.Forms.TextBox txtPassengerName;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSeatNumber;
        private System.Windows.Forms.Label label1;
    }
}
