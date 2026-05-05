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
    public partial class Attendance : Form
    {
        // ✅ Connection string
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-NTCSQ2S\SQLEXPRESS;Initial Catalog=messsystem;Integrated Security=True");

        public Attendance()
        {
            InitializeComponent();
        }

        private void Attendance_Load(object sender, EventArgs e)
        {
            comboBoxStatus.Items.Add("Present");
            comboBoxStatus.Items.Add("Absent");

           // txtMemberID.ReadOnly = false;  // You will type MemberID
        }

        // ✅ When clicking or focusing on Member Name textbox — fetch name from Members1
        private void txtMemberName_Click(object sender, EventArgs e)
        {
            FetchMemberNameByID();
        }

        private void txtMemberName_Enter(object sender, EventArgs e)
        {
            FetchMemberNameByID();
        }

        // ✅ Function: fetch first + last name based on MemberID
        private void FetchMemberNameByID()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(numericUpDown.Text))
                {
                    MessageBox.Show("Please enter Member ID first.");
                    return;
                }

                using (SqlCommand cmd = new SqlCommand("SELECT FirstName, LastName FROM Members1 WHERE MemberID = @MemberID", con))
                {
                    cmd.Parameters.AddWithValue("@MemberID", numericUpDown.Text.Trim());

                    if (con.State != ConnectionState.Open)
                        con.Open();

                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        string fullName = dr["FirstName"].ToString() + " " + dr["LastName"].ToString();
                        txtMemberName.Text = fullName.Trim();
                    }
                    else
                    {
                        MessageBox.Show("No member found with this ID.");
                        txtMemberName.Clear();
                    }

                    dr.Close();
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching name: " + ex.Message);
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        // ✅ Save attendance record
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (numericUpDown.Text == "" || txtMemberName.Text == "" || comboBoxStatus.Text == "")
                {
                    MessageBox.Show("Please fill all details before saving.");
                    return;
                }

                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Attendance (MemberID, MemberName, Status, Date) VALUES (@MemberID, @MemberName, @Status, @Date)", con);
                cmd.Parameters.AddWithValue("@MemberID", numericUpDown.Text);
                cmd.Parameters.AddWithValue("@MemberName", txtMemberName.Text);
                cmd.Parameters.AddWithValue("@Status", comboBoxStatus.Text);
                cmd.Parameters.AddWithValue("@Date", dateTimePicker1.Value.Date);
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Attendance saved successfully ✅");

                //numericUpDown.Clear();
                txtMemberName.Clear();
                comboBoxStatus.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                con.Close();
            }
        }

        // ✅ Show attendance records when clicking Next button
        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT AttendanceID, MemberID, MemberName, Status, Date FROM Attendance ORDER BY Date DESC", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
                con.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void Attendance_Load_1(object sender, EventArgs e)
        {

        }
    }
}