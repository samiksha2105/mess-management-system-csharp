using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;


namespace MessSystem
{
    public partial class Billing : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-NTCSQ2S\SQLEXPRESS;Initial Catalog=messsystem;Integrated Security=True");

        public Billing()
        {
            InitializeComponent();
            txtMemberID.Text = CurrentSession.MemberID;

        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Billing (MemberID, PaymentType, Amount, PaymentDate) VALUES (@mid, @pt, @am, @pd)", con);
            cmd.Parameters.AddWithValue("@mid", txtMemberID.Text);
            cmd.Parameters.AddWithValue("@pt", cmbPaymentType.Text);
            cmd.Parameters.AddWithValue("@am", txtAmount.Text);
            cmd.Parameters.AddWithValue("@pd", dtPaymentDate.Value);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Payment Saved");
            /*
            Attendance attendance = new Attendance();
            attendance.Show();
            this.Hide();
            */
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Billing", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Attendance attendance = new Attendance();
            attendance.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Billing_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MealSelection mealSelection = new MealSelection();
            mealSelection.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SingleBillReportForm singleBillReportForm = new SingleBillReportForm();
            singleBillReportForm.Show();
            this.Hide();
        }
    }
}