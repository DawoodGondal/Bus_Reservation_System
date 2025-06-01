namespace BusReservationSystem
{
    partial class ManageBusesForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBusNumber = new System.Windows.Forms.TextBox();
            this.txtCapacity = new System.Windows.Forms.TextBox();
            this.cmbBusType = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dgvBuses = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuses)).BeginInit();
            this.SuspendLayout();

            // Modern color theme
            this.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);

            // label1
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 50);
            this.label1.Text = "Bus Number:";

            // label2
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 100);
            this.label2.Text = "Bus Type:";

            // label3
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 150);
            this.label3.Text = "Total Seats:";

            // txtBusNumber
            this.txtBusNumber.Location = new System.Drawing.Point(180, 47);
            this.txtBusNumber.Size = new System.Drawing.Size(250, 25);
            this.txtBusNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // cmbBusType
            this.cmbBusType.Location = new System.Drawing.Point(180, 97);
            this.cmbBusType.Size = new System.Drawing.Size(250, 25);
            this.cmbBusType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBusType.Items.AddRange(new object[] { "AC", "Non-AC", "Sleeper" });

            // txtCapacity
            this.txtCapacity.Location = new System.Drawing.Point(180, 147);
            this.txtCapacity.Size = new System.Drawing.Size(250, 25);
            this.txtCapacity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // btnAdd
            this.btnAdd.Location = new System.Drawing.Point(50, 200);
            this.btnAdd.Size = new System.Drawing.Size(110, 35);
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(0, 123, 255);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            // btnUpdate
            this.btnUpdate.Location = new System.Drawing.Point(180, 200);
            this.btnUpdate.Size = new System.Drawing.Size(110, 35);
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(40, 167, 69);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);

            // btnDelete
            this.btnDelete.Location = new System.Drawing.Point(320, 200);
            this.btnDelete.Size = new System.Drawing.Size(110, 35);
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(220, 53, 69);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            // dgvBuses
            this.dgvBuses.Location = new System.Drawing.Point(20, 260);
            this.dgvBuses.Size = new System.Drawing.Size(540, 250);
            this.dgvBuses.BackgroundColor = System.Drawing.Color.White;
            this.dgvBuses.GridColor = System.Drawing.Color.LightGray;
            this.dgvBuses.ReadOnly = true;
            this.dgvBuses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBuses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            // ManageBusesForm
            this.ClientSize = new System.Drawing.Size(600, 540);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBusNumber);
            this.Controls.Add(this.cmbBusType);
            this.Controls.Add(this.txtCapacity);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dgvBuses);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Buses";

            ((System.ComponentModel.ISupportInitialize)(this.dgvBuses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBusNumber;
        private System.Windows.Forms.TextBox txtCapacity;
        private System.Windows.Forms.ComboBox cmbBusType;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView dgvBuses;
    }
}
