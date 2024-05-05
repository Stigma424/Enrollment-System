namespace Enrollment_System
{
    partial class StudentForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SICurriculumYearTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SICategoryComboBox = new System.Windows.Forms.ComboBox();
            this.SICourseCodeComboBox = new System.Windows.Forms.ComboBox();
            this.SIUnitsTextBox = new System.Windows.Forms.TextBox();
            this.SIDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.SIOfferingComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SISubjectCodeTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.SICurriculumYearTextBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.SICategoryComboBox);
            this.groupBox1.Controls.Add(this.SICourseCodeComboBox);
            this.groupBox1.Controls.Add(this.SIUnitsTextBox);
            this.groupBox1.Controls.Add(this.SIDescriptionTextBox);
            this.groupBox1.Controls.Add(this.SIOfferingComboBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.SISubjectCodeTextBox);
            this.groupBox1.Location = new System.Drawing.Point(61, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 233);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Information";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 190);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Remarks";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // SICurriculumYearTextBox
            // 
            this.SICurriculumYearTextBox.Location = new System.Drawing.Point(103, 183);
            this.SICurriculumYearTextBox.Name = "SICurriculumYearTextBox";
            this.SICurriculumYearTextBox.Size = new System.Drawing.Size(100, 20);
            this.SICurriculumYearTextBox.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Year";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Course";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Middle Name";
            // 
            // SICategoryComboBox
            // 
            this.SICategoryComboBox.FormattingEnabled = true;
            this.SICategoryComboBox.Items.AddRange(new object[] {
            "LECTURE",
            "LABORATORY"});
            this.SICategoryComboBox.Location = new System.Drawing.Point(103, 133);
            this.SICategoryComboBox.Name = "SICategoryComboBox";
            this.SICategoryComboBox.Size = new System.Drawing.Size(121, 21);
            this.SICategoryComboBox.TabIndex = 9;
            // 
            // SICourseCodeComboBox
            // 
            this.SICourseCodeComboBox.FormattingEnabled = true;
            this.SICourseCodeComboBox.Items.AddRange(new object[] {
            "BSIT",
            "BSIS",
            "BSIT:SE",
            "ACT"});
            this.SICourseCodeComboBox.Location = new System.Drawing.Point(103, 157);
            this.SICourseCodeComboBox.Name = "SICourseCodeComboBox";
            this.SICourseCodeComboBox.Size = new System.Drawing.Size(121, 21);
            this.SICourseCodeComboBox.TabIndex = 8;
            // 
            // SIUnitsTextBox
            // 
            this.SIUnitsTextBox.Location = new System.Drawing.Point(103, 80);
            this.SIUnitsTextBox.Name = "SIUnitsTextBox";
            this.SIUnitsTextBox.Size = new System.Drawing.Size(58, 20);
            this.SIUnitsTextBox.TabIndex = 7;
            // 
            // SIDescriptionTextBox
            // 
            this.SIDescriptionTextBox.Location = new System.Drawing.Point(103, 54);
            this.SIDescriptionTextBox.Name = "SIDescriptionTextBox";
            this.SIDescriptionTextBox.Size = new System.Drawing.Size(200, 20);
            this.SIDescriptionTextBox.TabIndex = 6;
            // 
            // SIOfferingComboBox
            // 
            this.SIOfferingComboBox.FormattingEnabled = true;
            this.SIOfferingComboBox.Items.AddRange(new object[] {
            "1st Year",
            "2nd Year",
            "3rd Year",
            "4th Year"});
            this.SIOfferingComboBox.Location = new System.Drawing.Point(103, 104);
            this.SIOfferingComboBox.Name = "SIOfferingComboBox";
            this.SIOfferingComboBox.Size = new System.Drawing.Size(121, 21);
            this.SIOfferingComboBox.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Student ID";
            // 
            // SISubjectCodeTextBox
            // 
            this.SISubjectCodeTextBox.Location = new System.Drawing.Point(103, 28);
            this.SISubjectCodeTextBox.Name = "SISubjectCodeTextBox";
            this.SISubjectCodeTextBox.Size = new System.Drawing.Size(100, 20);
            this.SISubjectCodeTextBox.TabIndex = 1;
            this.SISubjectCodeTextBox.TextChanged += new System.EventHandler(this.SISubjectCodeTextBox_TextChanged);
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "StudentForm";
            this.Text = "StudentForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox SICurriculumYearTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox SICategoryComboBox;
        private System.Windows.Forms.ComboBox SICourseCodeComboBox;
        private System.Windows.Forms.TextBox SIUnitsTextBox;
        private System.Windows.Forms.TextBox SIDescriptionTextBox;
        private System.Windows.Forms.ComboBox SIOfferingComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SISubjectCodeTextBox;
    }
}