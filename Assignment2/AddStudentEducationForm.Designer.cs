namespace Assignment2
{
    partial class AddStudentEducationForm
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
            this.gpaTB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.departmentTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.submitBtn = new System.Windows.Forms.Button();
            this.enrollementYearCB = new System.Windows.Forms.ComboBox();
            this.expectedGradCB = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // gpaTB
            // 
            this.gpaTB.Location = new System.Drawing.Point(136, 25);
            this.gpaTB.Name = "gpaTB";
            this.gpaTB.Size = new System.Drawing.Size(100, 20);
            this.gpaTB.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.DarkGreen;
            this.label8.ForeColor = System.Drawing.Color.Gold;
            this.label8.Location = new System.Drawing.Point(133, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Current GPA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DarkGreen;
            this.label6.ForeColor = System.Drawing.Color.Gold;
            this.label6.Location = new System.Drawing.Point(12, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Expected Graduation";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DarkGreen;
            this.label5.ForeColor = System.Drawing.Color.Gold;
            this.label5.Location = new System.Drawing.Point(12, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Enrollment Year";
            // 
            // departmentTB
            // 
            this.departmentTB.Location = new System.Drawing.Point(15, 25);
            this.departmentTB.Name = "departmentTB";
            this.departmentTB.Size = new System.Drawing.Size(100, 20);
            this.departmentTB.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkGreen;
            this.label4.ForeColor = System.Drawing.Color.Gold;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Department";
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(136, 61);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(97, 23);
            this.submitBtn.TabIndex = 21;
            this.submitBtn.Text = "Submit Student ";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // enrollementYearCB
            // 
            this.enrollementYearCB.FormattingEnabled = true;
            this.enrollementYearCB.Items.AddRange(new object[] {
            "2012",
            "2013",
            "2014",
            "2015"});
            this.enrollementYearCB.Location = new System.Drawing.Point(13, 62);
            this.enrollementYearCB.Name = "enrollementYearCB";
            this.enrollementYearCB.Size = new System.Drawing.Size(106, 21);
            this.enrollementYearCB.TabIndex = 30;
            // 
            // expectedGradCB
            // 
            this.expectedGradCB.FormattingEnabled = true;
            this.expectedGradCB.Items.AddRange(new object[] {
            "2017",
            "2018",
            "2019",
            "2020"});
            this.expectedGradCB.Location = new System.Drawing.Point(12, 103);
            this.expectedGradCB.Name = "expectedGradCB";
            this.expectedGradCB.Size = new System.Drawing.Size(106, 21);
            this.expectedGradCB.TabIndex = 31;
            // 
            // AddStudentEducationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(284, 141);
            this.Controls.Add(this.expectedGradCB);
            this.Controls.Add(this.enrollementYearCB);
            this.Controls.Add(this.gpaTB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.departmentTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.submitBtn);
            this.Name = "AddStudentEducationForm";
            this.Text = "Add Student Education";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox gpaTB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox departmentTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.ComboBox enrollementYearCB;
        private System.Windows.Forms.ComboBox expectedGradCB;
    }
}