namespace Assignment2
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
            this.gpaStartTB = new System.Windows.Forms.TextBox();
            this.gpaEndTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.learningDisabilityRB = new System.Windows.Forms.RadioButton();
            this.advSearchBtn = new System.Windows.Forms.Button();
            this.displayStudentRTB = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // advDepartmentTB
            // 
            this.advDepartmentTB.Location = new System.Drawing.Point(9, 32);
            this.advDepartmentTB.Name = "advDepartmentTB";
            this.advDepartmentTB.Size = new System.Drawing.Size(100, 20);
            this.advDepartmentTB.TabIndex = 1;
            // 
            // advCategoryTB
            // 
            this.advCategoryTB.Location = new System.Drawing.Point(9, 77);
            this.advCategoryTB.Name = "advCategoryTB";
            this.advCategoryTB.Size = new System.Drawing.Size(100, 20);
            this.advCategoryTB.TabIndex = 2;
            // 
            // gpaStartTB
            // 
            this.gpaStartTB.Location = new System.Drawing.Point(9, 125);
            this.gpaStartTB.Name = "gpaStartTB";
            this.gpaStartTB.Size = new System.Drawing.Size(100, 20);
            this.gpaStartTB.TabIndex = 4;
            // 
            // gpaEndTB
            // 
            this.gpaEndTB.Location = new System.Drawing.Point(135, 125);
            this.gpaEndTB.Name = "gpaEndTB";
            this.gpaEndTB.Size = new System.Drawing.Size(100, 20);
            this.gpaEndTB.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Department";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Category";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "GPA";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(113, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "to";
            // 
            // learningDisabilityRB
            // 
            this.learningDisabilityRB.AutoSize = true;
            this.learningDisabilityRB.Location = new System.Drawing.Point(9, 160);
            this.learningDisabilityRB.Name = "learningDisabilityRB";
            this.learningDisabilityRB.Size = new System.Drawing.Size(192, 17);
            this.learningDisabilityRB.TabIndex = 17;
            this.learningDisabilityRB.TabStop = true;
            this.learningDisabilityRB.Text = "Get student with learning disabilities";
            this.learningDisabilityRB.UseVisualStyleBackColor = true;
            // 
            // advSearchBtn
            // 
            this.advSearchBtn.Location = new System.Drawing.Point(9, 195);
            this.advSearchBtn.Name = "advSearchBtn";
            this.advSearchBtn.Size = new System.Drawing.Size(100, 23);
            this.advSearchBtn.TabIndex = 18;
            this.advSearchBtn.Text = "Search";
            this.advSearchBtn.UseVisualStyleBackColor = true;
            this.advSearchBtn.Click += new System.EventHandler(this.advSearchBtn_Click);
            // 
            // displayStudentRTB
            // 
            this.displayStudentRTB.Location = new System.Drawing.Point(9, 244);
            this.displayStudentRTB.Name = "displayStudentRTB";
            this.displayStudentRTB.Size = new System.Drawing.Size(255, 96);
            this.displayStudentRTB.TabIndex = 19;
            this.displayStudentRTB.Text = "";
            // 
            // SearchStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 352);
            this.Controls.Add(this.displayStudentRTB);
            this.Controls.Add(this.advSearchBtn);
            this.Controls.Add(this.learningDisabilityRB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gpaEndTB);
            this.Controls.Add(this.gpaStartTB);
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
        private System.Windows.Forms.TextBox gpaStartTB;
        private System.Windows.Forms.TextBox gpaEndTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton learningDisabilityRB;
        private System.Windows.Forms.Button advSearchBtn;
        private System.Windows.Forms.RichTextBox displayStudentRTB;
    }
}