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
    public partial class FormReport_ServiceOrdersViewer : Form
    {
        public FormReport_ServiceOrdersViewer()
        {
            InitializeComponent();
        }
        public void SetDataSource(DataTable dt)
        {
            var rpt = new FormReport_ServiceOrdersDesign();
            rpt.SetDataSource(dt);
            crystalReportViewer1.ReportSource = rpt;
        }
    }
}
