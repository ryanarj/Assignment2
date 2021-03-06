﻿namespace Assignment2
{
    partial class SearchStudentForm
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
            this.advDepartmentTB = new System.Windows.Forms.TextBox();
            this.advCategoryTB = new System.Windows.Forms.TextBox();
            this.advGpaStartTB = new System.Windows.Forms.TextBox();
            this.advGpaEndTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.learningDisabilityRB = new System.Windows.Forms.RadioButton();
            this.advSearchBtn = new System.Windows.Forms.Button();
            this.displayStudentRTB = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.advIDTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.advNameTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // advDepartmentTB
            // 
            this.advDepartmentTB.Location = new System.Drawing.Point(9, 98);
            this.advDepartmentTB.Name = "advDepartmentTB";
            this.advDepartmentTB.Size = new System.Drawing.Size(100, 20);
            this.advDepartmentTB.TabIndex = 1;
            // 
            // advCategoryTB
            // 
            this.advCategoryTB.Location = new System.Drawing.Point(9, 143);
            this.advCategoryTB.Name = "advCategoryTB";
            this.advCategoryTB.Size = new System.Drawing.Size(100, 20);
            this.advCategoryTB.TabIndex = 2;
            // 
            // advGpaStartTB
            // 
            this.advGpaStartTB.Location = new System.Drawing.Point(9, 191);
            this.advGpaStartTB.Name = "advGpaStartTB";
            this.advGpaStartTB.Size = new System.Drawing.Size(100, 20);
            this.advGpaStartTB.TabIndex = 4;
            // 
            // advGpaEndTB
            // 
            this.advGpaEndTB.Location = new System.Drawing.Point(135, 191);
            this.advGpaEndTB.Name = "advGpaEndTB";
            this.advGpaEndTB.Size = new System.Drawing.Size(100, 20);
            this.advGpaEndTB.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(6, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Department";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(6, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Category";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Gold;
            this.label4.Location = new System.Drawing.Point(6, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "GPA";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(113, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "to";
            // 
            // learningDisabilityRB
            // 
            this.learningDisabilityRB.AutoSize = true;
            this.learningDisabilityRB.ForeColor = System.Drawing.Color.Gold;
            this.learningDisabilityRB.Location = new System.Drawing.Point(9, 226);
            this.learningDisabilityRB.Name = "learningDisabilityRB";
            this.learningDisabilityRB.Size = new System.Drawing.Size(192, 17);
            this.learningDisabilityRB.TabIndex = 17;
            this.learningDisabilityRB.TabStop = true;
            this.learningDisabilityRB.Text = "Get student with learning disabilities";
            this.learningDisabilityRB.UseVisualStyleBackColor = true;
            // 
            // advSearchBtn
            // 
            this.advSearchBtn.Location = new System.Drawing.Point(9, 261);
            this.advSearchBtn.Name = "advSearchBtn";
            this.advSearchBtn.Size = new System.Drawing.Size(100, 23);
            this.advSearchBtn.TabIndex = 18;
            this.advSearchBtn.Text = "Search";
            this.advSearchBtn.UseVisualStyleBackColor = true;
            this.advSearchBtn.Click += new System.EventHandler(this.advSearchBtn_Click);
            // 
            // displayStudentRTB
            // 
            this.displayStudentRTB.Location = new System.Drawing.Point(9, 307);
            this.displayStudentRTB.Name = "displayStudentRTB";
            this.displayStudentRTB.Size = new System.Drawing.Size(363, 96);
            this.displayStudentRTB.TabIndex = 19;
            this.displayStudentRTB.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(6, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Search by userID";
            // 
            // advIDTB
            // 
            this.advIDTB.Location = new System.Drawing.Point(9, 48);
            this.advIDTB.Name = "advIDTB";
            this.advIDTB.Size = new System.Drawing.Size(100, 20);
            this.advIDTB.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Gold;
            this.label5.Location = new System.Drawing.Point(132, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Search by Name";
            // 
            // advNameTB
            // 
            this.advNameTB.Location = new System.Drawing.Point(135, 48);
            this.advNameTB.Name = "advNameTB";
            this.advNameTB.Size = new System.Drawing.Size(100, 20);
            this.advNameTB.TabIndex = 22;
            // 
            // SearchStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(384, 415);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.advNameTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.advIDTB);
            this.Controls.Add(this.displayStudentRTB);
            this.Controls.Add(this.advSearchBtn);
            this.Controls.Add(this.learningDisabilityRB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.advGpaEndTB);
            this.Controls.Add(this.advGpaStartTB);
            this.Controls.Add(this.advCategoryTB);
            this.Controls.Add(this.advDepartmentTB);
            this.Name = "SearchStudentForm";
            this.Text = "Search for a student";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox advDepartmentTB;
        private System.Windows.Forms.TextBox advCategoryTB;
        private System.Windows.Forms.TextBox advGpaStartTB;
        private System.Windows.Forms.TextBox advGpaEndTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton learningDisabilityRB;
        private System.Windows.Forms.Button advSearchBtn;
        private System.Windows.Forms.RichTextBox displayStudentRTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox advIDTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox advNameTB;
    }
}