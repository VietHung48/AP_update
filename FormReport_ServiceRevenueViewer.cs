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

    public partial class FormReport_ServiceRevenueViewer : Form
    {
        databaseConnection db = new databaseConnection();
        public FormReport_ServiceRevenueViewer()
        {
            InitializeComponent();
        }
        public void SetDataSource(DataTable dt)
        {
            FormReport_RevenueDesign rpt = new FormReport_RevenueDesign();
            rpt.SetDataSource(dt);
            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.Refresh();
        }

        
    }
}
