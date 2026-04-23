using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group4Ap
{
    public partial class FormReport_RoomOccupancyViewer : Form
    {
        public FormReport_RoomOccupancyViewer()
        {
            InitializeComponent();
        }
        public void SetDataSource(DataTable dt)
        {
            var rpt = new FormReport_RoomOccupancyDesign();
            rpt.SetDataSource(dt);
            crystalReportViewer1.ReportSource = rpt;
        }
    }
}
