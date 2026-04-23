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
	public partial class FormServiceRevenue : Form
	{
		public FormServiceRevenue()
		{
			InitializeComponent();
		}
        databaseConnection db = new databaseConnection();

        private void FormServiceRevenue_Load(object sender, EventArgs e)
		{
            // TODO: This line of code loads data into the 'hotelManagementDataSet.ServiceRevenue' table. You can move, or remove it, as needed.
            this.serviceRevenueTableAdapter.Fill(this.hotelManagementDataSet.ServiceRevenue);
			RIDField.DataBindings.Add("Text", dataGridView1.DataSource, "ServiceID");
			GIDField.DataBindings.Add("Text", dataGridView1.DataSource, "ServiceName");
			GNField.DataBindings.Add("Text", dataGridView1.DataSource, "TotalRevenue");
		}

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                db.openConnection();

                string sql = "select * from ServiceRevenue";
                SqlDataAdapter da = new SqlDataAdapter(sql, db.cnn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dt.TableName = "ServiceRevenue";

                FormReport_ServiceRevenueViewer f = new FormReport_ServiceRevenueViewer();
                f.SetDataSource(dt);

                f.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                databaseConnection db = new databaseConnection();
                db.openConnection();

                string sql = "SELECT * FROM RevenueByMonth ORDER BY Year, Month";
                SqlDataAdapter da = new SqlDataAdapter(sql, db.cnn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dt.TableName = "RevenueByMonth";

                FormReport_RevenueByMonthViewer f = new FormReport_RevenueByMonthViewer();
                f.SetDataSource(dt);
                f.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
