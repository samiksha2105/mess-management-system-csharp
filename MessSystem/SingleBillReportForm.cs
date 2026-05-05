using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace MessSystem
{
    public partial class SingleBillReportForm : Form
    {
        public SingleBillReportForm()
        {
            InitializeComponent();
        }

        private void btnShowReceipt_Click(object sender, EventArgs e)
        {
             if (string.IsNullOrWhiteSpace(txtMemberID.Text))
    {
        MessageBox.Show("Please enter a Member ID.");
        return;
    }

    int memberId = int.Parse(txtMemberID.Text);

    ReportDocument rpt = new ReportDocument();
    rpt.Load(@"C:\Users\Admin\source\repos\MessSystem\MessSystem\reports\singlebillReciept.rpt");

    // Database login (change as per your setup)
    //rpt.SetDatabaseLogon("your_username", "your_password", "DESKTOP-NTCSQ2S\\SQLEXPRESS", "messsystem");

    // Show only that one member’s record
    rpt.RecordSelectionFormula = "{Billing.MemberID} = " + memberId;

    crystalReportViewer1.ReportSource = rpt;
    crystalReportViewer1.Refresh();
        }

        private void SingleBillReportForm_Load(object sender, EventArgs e)
        {

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Billing billing = new Billing();
            billing.Show();
            this.Hide();

        }
    }
}
