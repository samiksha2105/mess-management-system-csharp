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
    public partial class Registration : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-NTCSQ2S\SQLEXPRESS;Initial Catalog=messsystem;Integrated Security=True");
        public Registration()
        {
            InitializeComponent();
            DisplayData();
            textFirstName.KeyPress += BlockSpace_KeyPress;
            textLastName.KeyPress += BlockSpace_KeyPress;

            textFirstName.TextChanged += RemoveSpace_TextChanged;
            textLastName.TextChanged += RemoveSpace_TextChanged;
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            DisplayData();
            GenerateMemberID();
            this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.CenterScreen;
            

        }

        void DisplayData()
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Members1", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (textFirstName.Text == "" || textLastName.Text == "" || textMobile.Text == "")
            {
                MessageBox.Show("Please fill all details.");
                return;
            }

            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Members1 (FirstName, LastName, Mobile) OUTPUT INSERTED.MemberID VALUES (@fn, @ln, @mb)", con);
            cmd.Parameters.AddWithValue("@fn",textFirstName.Text);
            cmd.Parameters.AddWithValue("@ln",textLastName.Text);
            cmd.Parameters.AddWithValue("@mb", textMobile.Text);

            // 🔹 Get the newly inserted MemberID
            int newMemberID = (int)cmd.ExecuteScalar();
            con.Close();

            MessageBox.Show("Member Added Successfully! ID: " + newMemberID);

            DisplayData();
            ClearFields();



        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (textMemberID.Text == "")
            {
                MessageBox.Show("Select a record to update.");
                return;
            }

            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Members1 SET FirstName=@fn, LastName=@ln, Mobile=@mb WHERE MemberID=@id", con);
            cmd.Parameters.AddWithValue("@id", textMemberID.Text);
            cmd.Parameters.AddWithValue("@fn", textFirstName.Text);
            cmd.Parameters.AddWithValue("@ln", textLastName.Text);
            cmd.Parameters.AddWithValue("@mb", textMobile.Text);
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Record Updated Successfully!");
            DisplayData();
            ClearFields();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (textMemberID.Text == "")
            {
                MessageBox.Show("Select a record to delete.");
                return;
            }

            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM Members1 WHERE MemberID=@id", con);
            cmd.Parameters.AddWithValue("@id", textMemberID.Text);
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Record Deleted Successfully!");
            DisplayData();
            ClearFields();

            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        void ClearFields()
        {
            textMemberID.Clear();
            textFirstName.Clear();
            textLastName.Clear();
            textMobile.Clear();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                textMemberID.Text = row.Cells["MemberID"].Value.ToString();
                textFirstName.Text = row.Cells["FirstName"].Value.ToString();
                textLastName.Text = row.Cells["LastName"].Value.ToString();
                textMobile.Text = row.Cells["Mobile"].Value.ToString();
            }
        }

        private void textMemberID_TextChanged(object sender, EventArgs e)
        {

        }

        private void textFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            string memberId = textMemberID.Text.Trim();

            if (string.IsNullOrEmpty(memberId))
            {
                MessageBox.Show("Please enter Member ID");
                return;
            }

            // Save MemberID in static class
            CurrentSession.MemberID = memberId;

            // 🔹 Open MealSelection page and pass MemberID
            MealSelection mealForm = new MealSelection();//newMemberID
            mealForm.Show();
            this.Hide();
        }

        private void textMobile_TextChanged(object sender, EventArgs e)
        {

        }
        private void GenerateMemberID()
        {
            SqlCommand cmd = new SqlCommand("Select isnull(max(MemberId),0)+ 1 from Members1", con);
            int newId = Convert.ToInt32(cmd.ExecuteScalar());
            textMemberID.Text = newId.ToString();

        }
        
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            // Check only plain Enter (not Ctrl+Enter, Shift+Enter, etc.)
            if (keyData == Keys.Enter)
            {
                Control active = this.ActiveControl;

                
                if (active is TextBox tb)
                {
                    if (tb.Multiline) return base.ProcessCmdKey(ref msg, keyData);
                }
                if (active is RichTextBox || active is DataGridView || active is Button)
                {
                    return base.ProcessCmdKey(ref msg, keyData);
                }

                // Move to next control in tab order
                this.SelectNextControl(active, true, true, true, true);
                return true; // consumed
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

       
        private void txtMobile_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnAdd.Focus();
                // or: btnSave.PerformClick();
            }
        }
        private void BlockSpace_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                e.Handled = true; // ignore space
            }
        }

        // ❌ Remove spaces if pasted
        private void RemoveSpace_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (tb == null) return;

            int cursorPos = tb.SelectionStart;

            string newText = tb.Text.Replace(" ", "");

            if (tb.Text != newText)
            {
                tb.Text = newText;
                tb.SelectionStart = cursorPos > tb.Text.Length ? tb.Text.Length : cursorPos;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void textMemberID_TextChanged_1(object sender, EventArgs e)
        {

        }
    }

}