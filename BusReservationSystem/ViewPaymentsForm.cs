using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BusReservationSystem
{
    public partial class ViewPaymentsForm : Form
    {
        string connectionString = "server=localhost;user=root;password=your_password;database=BusReservationDB;";

        public ViewPaymentsForm()
        {
            InitializeComponent();
            LoadPayments();
        }

        private void LoadPayments(string search = "", DateTime? filterDate = null)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = @"
                    SELECT 
                        p.PaymentID,
                        u.FullName AS UserName,
                        tr.TripDate,
                        r.Source,
                        r.Destination,
                        b.BusNumber,
                        p.Amount,
                        pm.MethodName AS PaymentMethod,
                        p.PaymentDate
                    FROM Payment p
                    JOIN Users u ON p.UserID = u.UserID
                    JOIN Trips tr ON p.TripID = tr.TripID
                    JOIN Routes r ON tr.RouteID = r.RouteID
                    JOIN Buses b ON tr.BusID = b.BusID
                    JOIN PaymentMethod pm ON p.PaymentMethodID = pm.PaymentMethodID
                    WHERE 1=1";

                if (!string.IsNullOrEmpty(search))
                    query += " AND (u.FullName LIKE @search OR u.Email LIKE @search)";
                if (filterDate.HasValue)
                    query += " AND DATE(p.PaymentDate) = @date";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                if (!string.IsNullOrEmpty(search))
                    cmd.Parameters.AddWithValue("@search", "%" + search + "%");
                if (filterDate.HasValue)
                    cmd.Parameters.AddWithValue("@date", filterDate.Value.Date);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvPayments.DataSource = dt;

                // Total collected
                decimal total = 0;
                foreach (DataRow row in dt.Rows)
                {
                    total += Convert.ToDecimal(row["Amount"]);
                }
                lblTotal.Text = "Total Collected: ₹" + total.ToString("N2");
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadPayments(txtSearch.Text.Trim(), dtpDate.Value);
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            LoadPayments(txtSearch.Text.Trim(), dtpDate.Value);
        }

        private void dgvPayments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
