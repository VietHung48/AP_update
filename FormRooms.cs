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
	public partial class FormRooms : Form
	{
		public FormRooms()
		{
			InitializeComponent();
		}
		databaseConnection db = new databaseConnection();
		private void FormRooms_Load(object sender, EventArgs e)
		{
			showData();
			MPField.DataBindings.Add("Text", dataGridView1.DataSource, "RoomID");
			MLPField.DataBindings.Add("Text", dataGridView1.DataSource, "RoomTypeID");
			MTField.DataBindings.Add("Text", dataGridView1.DataSource, "TowerID");
			TField.DataBindings.Add("Text", dataGridView1.DataSource, "RoomFloor");
			SPField.DataBindings.Add("Text", dataGridView1.DataSource, "RoomNumber");

			MLPField.DataSource = db.GetTable("Select RoomTypeID From RoomTypes");
			MLPField.ValueMember = "RoomTypeID";

			MTField.DataSource = db.GetTable("Select TowerID From Towers");
			MTField.ValueMember = "TowerID";
			dataGridView1.CurrentCellChanged += DataGridView1_CurrentCellChanged;
			maintenanceRadioSync();
		}

		private void showData()
		{
			this.roomsTableAdapter.Fill(this.hotelManagementDataSet.Rooms);
		}
		private void btnTao_Click(object sender, EventArgs e)
		{
			MPField.Text = "";
			MLPField.Text = "";
			SPField.Text = "";
			TField.Text = "";
			MTField.Text = "";
			MPField.Focus();
			dataGridView1.ClearSelection();

			int nRowIndex = dataGridView1.Rows.Count - 1;
			dataGridView1.Rows[nRowIndex].Selected = true;
			dataGridView1.FirstDisplayedScrollingRowIndex = nRowIndex;
		}

		private void btnLuu_Click(object sender, EventArgs e)
		{
			String sql = String.Format("INSERT INTO Rooms VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')",
			MPField.Text, MLPField.Text, MTField.Text, SPField.Text, TField.Text, maintenanceConverter());
			db.ExecuteCommand(sql);
			showData();
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			String sql = String.Format("UPDATE Rooms SET RoomTypeID = '{1}', RoomNumber = '{2}', RoomFloor = '{3}', TowerID = '{4}', IsUnderMaintenance = '{5}' WHERE RoomID = '{0}'",
				MPField.Text, MLPField.Text, SPField.Text, TField.Text, MTField.Text, maintenanceConverter());
			db.ExecuteCommand(sql);
			showData();
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			String sql = String.Format("DELETE FROM Rooms WHERE RoomID = '{0}'",
				MPField.Text);
			db.ExecuteCommand(sql);
			showData();
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
		private String maintenanceConverter()
		{
			return rBtnYes.Checked ? "Y" : "N";
		}
		private void DataGridView1_CurrentCellChanged(object sender, EventArgs e)
		{
			maintenanceRadioSync();
		}
		private void maintenanceRadioSync()
		{
			if (dataGridView1.CurrentRow == null) return;
			if (dataGridView1.CurrentRow.DataBoundItem is DataRowView row)
			{
				String maintenance = row["IsUnderMaintenance"].ToString().Trim();
				rBtnYes.Checked = maintenance.Equals("Y", StringComparison.OrdinalIgnoreCase);
				rBtnNo.Checked = maintenance.Equals("N", StringComparison.OrdinalIgnoreCase);
			}
		}

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                databaseConnection db = new databaseConnection();
                db.openConnection();

                string sql = "SELECT * FROM RoomOccupancyRate";
                SqlDataAdapter da = new SqlDataAdapter(sql, db.cnn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dt.TableName = "RoomOccupancyRate";

                FormReport_RoomOccupancyViewer f = new FormReport_RoomOccupancyViewer();
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
