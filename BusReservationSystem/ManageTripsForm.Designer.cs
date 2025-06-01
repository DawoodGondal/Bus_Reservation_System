namespace BusReservationSystem
{
    partial class ManageTripsForm
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
            this.cmbRoute = new System.Windows.Forms.ComboBox();
            this.cmbBus = new System.Windows.Forms.ComboBox();
            this.dtpTripDate = new System.Windows.Forms.DateTimePicker();
            this.dtpDepartureTime = new System.Windows.Forms.DateTimePicker();
            this.dtpArrivalTime = new System.Windows.Forms.DateTimePicker();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.dgvTrips = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblRoute = new System.Windows.Forms.Label();
            this.lblBus = new System.Windows.Forms.Label();
            this.lblTripDate = new System.Windows.Forms.Label();
            this.lblDepartureTime = new System.Windows.Forms.Label();
            this.lblArrivalTime = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrips)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbRoute
            // 
            this.cmbRoute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoute.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbRoute.FormattingEnabled = true;
            this.cmbRoute.Location = new System.Drawing.Point(240, 30);
            this.cmbRoute.Name = "cmbRoute";
            this.cmbRoute.Size = new System.Drawing.Size(250, 28);
            this.cmbRoute.TabIndex = 0;
            // 
            // cmbBus
            // 
            this.cmbBus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbBus.FormattingEnabled = true;
            this.cmbBus.Location = new System.Drawing.Point(240, 80);
            this.cmbBus.Name = "cmbBus";
            this.cmbBus.Size = new System.Drawing.Size(250, 28);
            this.cmbBus.TabIndex = 1;
            // 
            // dtpTripDate
            // 
            this.dtpTripDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtpTripDate.Location = new System.Drawing.Point(240, 128);
            this.dtpTripDate.Name = "dtpTripDate";
            this.dtpTripDate.Size = new System.Drawing.Size(250, 26);
            this.dtpTripDate.TabIndex = 2;
            // 
            // dtpDepartureTime
            // 
            this.dtpDepartureTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtpDepartureTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpDepartureTime.Location = new System.Drawing.Point(240, 177);
            this.dtpDepartureTime.Name = "dtpDepartureTime";
            this.dtpDepartureTime.ShowUpDown = true;
            this.dtpDepartureTime.Size = new System.Drawing.Size(250, 26);
            this.dtpDepartureTime.TabIndex = 3;
            // 
            // dtpArrivalTime
            // 
            this.dtpArrivalTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtpArrivalTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpArrivalTime.Location = new System.Drawing.Point(240, 228);
            this.dtpArrivalTime.Name = "dtpArrivalTime";
            this.dtpArrivalTime.ShowUpDown = true;
            this.dtpArrivalTime.Size = new System.Drawing.Size(250, 26);
            this.dtpArrivalTime.TabIndex = 4;
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtPrice.Location = new System.Drawing.Point(240, 277);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(250, 26);
            this.txtPrice.TabIndex = 5;
            // 
            // dgvTrips
            // 
            this.dgvTrips.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTrips.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrips.Location = new System.Drawing.Point(30, 420);
            this.dgvTrips.Name = "dgvTrips";
            this.dgvTrips.RowHeadersWidth = 51;
            this.dgvTrips.RowTemplate.Height = 24;
            this.dgvTrips.Size = new System.Drawing.Size(740, 160);
            this.dgvTrips.TabIndex = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAdd.Location = new System.Drawing.Point(100, 340);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 35);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnUpdate.Location = new System.Drawing.Point(240, 340);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 35);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDelete.Location = new System.Drawing.Point(380, 340);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 35);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnClose.Location = new System.Drawing.Point(520, 340);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 35);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblRoute
            // 
            this.lblRoute.AutoSize = true;
            this.lblRoute.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblRoute.Location = new System.Drawing.Point(100, 33);
            this.lblRoute.Name = "lblRoute";
            this.lblRoute.Size = new System.Drawing.Size(53, 20);
            this.lblRoute.TabIndex = 11;
            this.lblRoute.Text = "Route";
            // 
            // lblBus
            // 
            this.lblBus.AutoSize = true;
            this.lblBus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblBus.Location = new System.Drawing.Point(100, 83);
            this.lblBus.Name = "lblBus";
            this.lblBus.Size = new System.Drawing.Size(39, 20);
            this.lblBus.TabIndex = 12;
            this.lblBus.Text = "Bus";
            // 
            // lblTripDate
            // 
            this.lblTripDate.AutoSize = true;
            this.lblTripDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTripDate.Location = new System.Drawing.Point(100, 133);
            this.lblTripDate.Name = "lblTripDate";
            this.lblTripDate.Size = new System.Drawing.Size(79, 20);
            this.lblTripDate.TabIndex = 13;
            this.lblTripDate.Text = "Trip Date";
            // 
            // lblDepartureTime
            // 
            this.lblDepartureTime.AutoSize = true;
            this.lblDepartureTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDepartureTime.Location = new System.Drawing.Point(100, 183);
            this.lblDepartureTime.Name = "lblDepartureTime";
            this.lblDepartureTime.Size = new System.Drawing.Size(126, 20);
            this.lblDepartureTime.TabIndex = 14;
            this.lblDepartureTime.Text = "Departure Time";
            // 
            // lblArrivalTime
            // 
            this.lblArrivalTime.AutoSize = true;
            this.lblArrivalTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblArrivalTime.Location = new System.Drawing.Point(100, 233);
            this.lblArrivalTime.Name = "lblArrivalTime";
            this.lblArrivalTime.Size = new System.Drawing.Size(99, 20);
            this.lblArrivalTime.TabIndex = 15;
            this.lblArrivalTime.Text = "Arrival Time";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblPrice.Location = new System.Drawing.Point(100, 283);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(48, 20);
            this.lblPrice.TabIndex = 16;
            this.lblPrice.Text = "Price";
            // 
            // ManageTripsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblArrivalTime);
            this.Controls.Add(this.lblDepartureTime);
            this.Controls.Add(this.lblTripDate);
            this.Controls.Add(this.lblBus);
            this.Controls.Add(this.lblRoute);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvTrips);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.dtpArrivalTime);
            this.Controls.Add(this.dtpDepartureTime);
            this.Controls.Add(this.dtpTripDate);
            this.Controls.Add(this.cmbBus);
            this.Controls.Add(this.cmbRoute);
            this.Name = "ManageTripsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Trips";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrips)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbRoute;
        private System.Windows.Forms.ComboBox cmbBus;
        private System.Windows.Forms.DateTimePicker dtpTripDate;
        private System.Windows.Forms.DateTimePicker dtpDepartureTime;
        private System.Windows.Forms.DateTimePicker dtpArrivalTime;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.DataGridView dgvTrips;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblRoute;
        private System.Windows.Forms.Label lblBus;
        private System.Windows.Forms.Label lblTripDate;
        private System.Windows.Forms.Label lblDepartureTime;
        private System.Windows.Forms.Label lblArrivalTime;
        private System.Windows.Forms.Label lblPrice;
    }
}
