using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessSystem
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            Registration reg = new Registration();
            reg.Show();
            this.Hide();
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            Attendance attendance = new Attendance();
            attendance.Show();
            this.Hide();
        }

        private void btnTimeTable_Click(object sender, EventArgs e)
        {
            MealTimeTable mealTimeTable = new MealTimeTable();
            mealTimeTable.Show();
            this.Hide();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
