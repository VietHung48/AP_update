using DoDongHai;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Group4Ap;

namespace Group4Ap
{
	public partial class FormPayment : Form
	{
		public FormPayment()
		{
			InitializeComponent();
		}

		databaseConnection db = new databaseConnection();

		private void btnLuu_Click(object sender, EventArgs e)
		{
			db.ExecuteCommand(String.Format("exec CalcPayment '{0}'", RIDField.Text));
			showData();
		}

		private void FormPayment_Load(object sender, EventArgs e)
		{
            showData();
			RIDField.DataBindings.Add("Text", dataGridView1.DataSource, "ReserID");
			GIDField.DataBindings.Add("Text", dataGridView1.DataSource, "GuestID");
			GNField.DataBindings.Add("Text", dataGridView1.DataSource, "GuestName");
			SDField.DataBindings.Add("Text", dataGridView1.DataSource, "StayDuration");
			RCField.DataBindings.Add("Text", dataGridView1.DataSource, "RoomCost");
			SCField.DataBindings.Add("Text", dataGridView1.DataSource, "ServiceCost");
			TCField.DataBindings.Add("Text", dataGridView1.DataSource, "TotalCost");
			PSField.DataBindings.Add("Text", dataGridView1.DataSource, "PaymentStatus");
			checkPaymentStatus();
		}
		private void showData()
		{
			this.reservationInvoiceDetailsTableAdapter1.Fill(this.hotelManagementDataSet1.ReservationInvoiceDetails);
		}

		private void checkPaymentStatus(){
			if (PSField.Text == "Paid" || PSField.Text == "Cancelled")
			{
				btnLuu.Enabled = false;
			}
			else
			{
				btnLuu.Enabled = true;
			}
		}

		private void dataGridView1_SelectionChanged(object sender, EventArgs e)
		{
			checkPaymentStatus();
		}

        private void button1_Click(object sender, EventArgs e)
        {
            db.openConnection();
            SqlCommand cmd = new SqlCommand("CalcPayment", db.cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@reserID", RIDField.Text);

            string sqlSelect = "SELECT * FROM ReservationInvoiceDetails WHERE ReserID = '" + RIDField.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(sqlSelect, db.cnn);
            DataTable dt = new DataTable();
            da.Fill(dt); 

            FormReport_PaymentBillViewer f = new FormReport_PaymentBillViewer();
            f.SetDataSource(dt);

            f.ShowDialog();
			

        }
    }
}
