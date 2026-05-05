
namespace MessSystem
{
    partial class MealSelection
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.cmbMealTime = new System.Windows.Forms.ComboBox();
            this.dtJoinDate = new System.Windows.Forms.DateTimePicker();
            this.cmbMealType = new System.Windows.Forms.ComboBox();
            this.cmbDurationType = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(56, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Meal Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(39, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Joining Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(74, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "Duration";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(57, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 27);
            this.label5.TabIndex = 4;
            this.label5.Text = "Meal Type";
            // 
            // txtDuration
            // 
            this.txtDuration.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDuration.Location = new System.Drawing.Point(226, 203);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(75, 33);
            this.txtDuration.TabIndex = 5;
            // 
            // cmbMealTime
            // 
            this.cmbMealTime.AutoCompleteCustomSource.AddRange(new string[] {
            "Lunch",
            "Dinner"});
            this.cmbMealTime.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMealTime.FormattingEnabled = true;
            this.cmbMealTime.Items.AddRange(new object[] {
            "Lunch",
            "Dinner",
            "for both Lunch and Dinner"});
            this.cmbMealTime.Location = new System.Drawing.Point(226, 90);
            this.cmbMealTime.Name = "cmbMealTime";
            this.cmbMealTime.Size = new System.Drawing.Size(252, 33);
            this.cmbMealTime.TabIndex = 6;
            // 
            // dtJoinDate
            // 
            this.dtJoinDate.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtJoinDate.Location = new System.Drawing.Point(226, 145);
            this.dtJoinDate.Name = "dtJoinDate";
            this.dtJoinDate.Size = new System.Drawing.Size(252, 33);
            this.dtJoinDate.TabIndex = 7;
            // 
            // cmbMealType
            // 
            this.cmbMealType.AutoCompleteCustomSource.AddRange(new string[] {
            "Lunch",
            "Dinner"});
            this.cmbMealType.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMealType.FormattingEnabled = true;
            this.cmbMealType.Items.AddRange(new object[] {
            "Veg",
            "Non-Veg"});
            this.cmbMealType.Location = new System.Drawing.Point(226, 261);
            this.cmbMealType.Name = "cmbMealType";
            this.cmbMealType.Size = new System.Drawing.Size(252, 33);
            this.cmbMealType.TabIndex = 8;
            // 
            // cmbDurationType
            // 
            this.cmbDurationType.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDurationType.FormattingEnabled = true;
            this.cmbDurationType.Items.AddRange(new object[] {
            "Months",
            "Days",
            "Year"});
            this.cmbDurationType.Location = new System.Drawing.Point(334, 201);
            this.cmbDurationType.Name = "cmbDurationType";
            this.cmbDurationType.Size = new System.Drawing.Size(144, 33);
            this.cmbDurationType.TabIndex = 9;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(740, 159);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(139, 55);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(740, 239);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(139, 55);
            this.btnNext.TabIndex = 11;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 333);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1014, 284);
            this.dataGridView1.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(591, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Member_id";
            // 
            // txtMemberID
            // 
            this.txtMemberID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMemberID.Location = new System.Drawing.Point(740, 88);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.Size = new System.Drawing.Size(139, 35);
            this.txtMemberID.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(383, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 71);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Meal";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(865, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 51);
            this.button1.TabIndex = 18;
            this.button1.Text = "<<Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MealSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MessSystem.Properties.Resources.backgraound2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1038, 629);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtMemberID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cmbDurationType);
            this.Controls.Add(this.cmbMealType);
            this.Controls.Add(this.dtJoinDate);
            this.Controls.Add(this.cmbMealTime);
            this.Controls.Add(this.txtDuration);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "MealSelection";
            this.Text = "MealSelection";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MealSelection_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.ComboBox cmbMealTime;
        private System.Windows.Forms.DateTimePicker dtJoinDate;
        private System.Windows.Forms.ComboBox cmbMealType;
        private System.Windows.Forms.ComboBox cmbDurationType;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnAdd;
        
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}