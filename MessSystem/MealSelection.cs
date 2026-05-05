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

namespace MessSystem
{
    public partial class MealSelection : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-NTCSQ2S\SQLEXPRESS;Initial Catalog=messsystem;Integrated Security=True");
        public MealSelection()
        {
            InitializeComponent();
            txtMemberID.Text = CurrentSession.MemberID;
            DisplayData();
        }

        private void MealSelection_Load(object sender, EventArgs e)
        {
            DisplayData();
        }

        void DisplayData()
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM MealSelection1", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO MealSelection1 (MemberID, MealTime, JoiningDate, Duration,DurationType, MealType) VALUES (@id, @mt, @jd, @dur,@durtype, @type)", con);
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtMemberID.Text)); // Add a textbox for MemberID if needed
                cmd.Parameters.AddWithValue("@mt", cmbMealTime.Text);
                cmd.Parameters.AddWithValue("@jd", dtJoinDate.Value);
                cmd.Parameters.AddWithValue("@dur", txtDuration.Text);
                cmd.Parameters.AddWithValue("@durtype", cmbDurationType.Text);
                cmd.Parameters.AddWithValue("@type", cmbMealType.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Meal Selection Saved Successfully!");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                con.Close();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Billing bill = new Billing();
            bill.Show();
            this.Hide();
        }

        private void MealSelection_Load_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Registration registration = new Registration();
            registration.Show();
            this.Hide();

        }
    }
}
