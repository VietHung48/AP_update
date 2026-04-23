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

namespace Group4Ap
{
	public partial class FormServiceOrders : Form
	{
		public FormServiceOrders()
		{
			InitializeComponent();
		}

		databaseConnection db = new databaseConnection();
		private void btnTao_Click(object sender, EventArgs e)
		{
			int nRowIndex = dataGridView1.Rows.Count - 1;
			SOIField.Text = (nRowIndex+1).ToString();
			GIDField.Text = "";
			SIDField.Text = "";
			EIDField.Text = "";
			ODField.Text = "";
			SOIField.Focus();
			dataGridView1.ClearSelection();

			dataGridView1.Rows[nRowIndex].Selected = true;
			dataGridView1.FirstDisplayedScrollingRowIndex = nRowIndex;
		}

		private void btnLuu_Click(object sender, EventArgs e)
		{
			String sql = String.Format("INSERT INTO ServiceOrders (GuestID, ServiceID, EmployeeID, OrderDate) VALUES ('{0}', '{1}', '{2}', CONVERT(DATETIME, '{3}', 103))",
			GIDField.Text, SIDField.Text, EIDField.Text, ODField.Text);
			db.ExecuteCommand(sql);
			showData();
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			String sql = String.Format("UPDATE ServiceOrders SET GuestID = '{1}', ServiceID = '{2}', EmployeeID = '{3}', OrderDate = CONVERT(DATETIME, '{4}', 103) WHERE ServiceOrderID = '{0}'",
				SOIField.Text, GIDField.Text, SIDField.Text, EIDField.Text, ODField.Text);
			db.ExecuteCommand(sql);
			showData();
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			String sql = String.Format("DELETE FROM ServiceOrders WHERE ServiceOrderID = '{0}'",
				SOIField.Text);
			db.ExecuteCommand(sql);
			showData();
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
		private void FormServiceOrders_Load(object sender, EventArgs e)
		{
			showData();
			SOIField.DataBindings.Add("Text", dataGridView1.DataSource, "ServiceOrderID");
			GIDField.DataBindings.Add("Text", dataGridView1.DataSource, "GuestID");
			SIDField.DataBindings.Add("Text", dataGridView1.DataSource, "ServiceID");
			EIDField.DataBindings.Add("Text", dataGridView1.DataSource, "EmployeeID");
			ODField.DataBindings.Add("Text", dataGridView1.DataSource, "OrderDate");

			GIDField.DataSource = db.GetTable("Select GuestID From Guests");
			GIDField.ValueMember = "GuestID";
			SIDField.DataSource = db.GetTable("Select ServiceID From Services");
			SIDField.ValueMember = "ServiceID";
			EIDField.DataSource = db.GetTable("Select EmployeeID From Employees");
			EIDField.ValueMember = "EmployeeID";
		}
		private void showData()
		{
			this.serviceOrdersTableAdapter.Fill(this.hotelManagementDataSet.ServiceOrders);
		}

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                db.openConnection();

                string sql = "SELECT * FROM GuestServiceDetails WHERE GuestID = @GuestID";
                SqlCommand cmd = new SqlCommand(sql, db.cnn);
                cmd.Parameters.AddWithValue("@GuestID", GIDField.Text);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Khách này chưa sử dụng dịch vụ nào.",
                                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                FormReport_ServiceOrdersViewer f = new FormReport_ServiceOrdersViewer();
                f.SetDataSource(dt);
                f.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                db.closeConnection();
            }
        }
    }
}
