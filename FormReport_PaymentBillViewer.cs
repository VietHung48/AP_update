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
    public partial class FormReport_PaymentBillViewer : Form
    {
        public FormReport_PaymentBillViewer()
        {
            InitializeComponent();
        }
        public void SetDataSource(DataTable dt)
        {
            var rpt = new FormReport_PaymentBillDesign();
            rpt.SetDataSource(dt);
            crystalReportViewer1.ReportSource = rpt;
        }
    }
}
