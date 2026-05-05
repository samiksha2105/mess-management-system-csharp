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
    public partial class MealTimeTable : Form
    {
        SqlConnection con = new SqlConnection(
     @"Data Source=DESKTOP-NTCSQ2S\SQLEXPRESS;Initial Catalog=messsystem;Integrated Security=True");

        public MealTimeTable()
        {
            InitializeComponent();
            DisplayData();
        }

        void DisplayData()
        {
            try
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM MealTimeTable", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
