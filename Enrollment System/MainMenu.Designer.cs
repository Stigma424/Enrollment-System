namespace Enrollment_System
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.SubjectEntryFormButton = new System.Windows.Forms.Button();
            this.StudentEntryButton = new System.Windows.Forms.Button();
            this.SubjectSchedEntryButton = new System.Windows.Forms.Button();
            this.StudentEnrollmentEntryButton = new System.Windows.Forms.Button();
            this.StudentGradeEntryButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.TestButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SubjectEntryFormButton
            // 
            this.SubjectEntryFormButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubjectEntryFormButton.Location = new System.Drawing.Point(32, 98);
            this.SubjectEntryFormButton.Name = "SubjectEntryFormButton";
            this.SubjectEntryFormButton.Size = new System.Drawing.Size(111, 55);
            this.SubjectEntryFormButton.TabIndex = 0;
            this.SubjectEntryFormButton.Text = "Subject Entry";
            this.SubjectEntryFormButton.UseVisualStyleBackColor = true;
            this.SubjectEntryFormButton.Click += new System.EventHandler(this.SubjectEntryFormButton_Click);
            // 
            // StudentEntryButton
            // 
            this.StudentEntryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentEntryButton.Location = new System.Drawing.Point(32, 37);
            this.StudentEntryButton.Name = "StudentEntryButton";
            this.StudentEntryButton.Size = new System.Drawing.Size(111, 55);
            this.StudentEntryButton.TabIndex = 1;
            this.StudentEntryButton.Text = "Student Entry";
            this.StudentEntryButton.UseVisualStyleBackColor = true;
            this.StudentEntryButton.Click += new System.EventHandler(this.StudentEntryButton_Click);
            // 
            // SubjectSchedEntryButton
            // 
            this.SubjectSchedEntryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubjectSchedEntryButton.Location = new System.Drawing.Point(32, 159);
            this.SubjectSchedEntryButton.Name = "SubjectSchedEntryButton";
            this.SubjectSchedEntryButton.Size = new System.Drawing.Size(111, 55);
            this.SubjectSchedEntryButton.TabIndex = 2;
            this.SubjectSchedEntryButton.Text = "Subject Schedule Entry";
            this.SubjectSchedEntryButton.UseVisualStyleBackColor = true;
            this.SubjectSchedEntryButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // StudentEnrollmentEntryButton
            // 
            this.StudentEnrollmentEntryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentEnrollmentEntryButton.Location = new System.Drawing.Point(200, 37);
            this.StudentEnrollmentEntryButton.Name = "StudentEnrollmentEntryButton";
            this.StudentEnrollmentEntryButton.Size = new System.Drawing.Size(111, 55);
            this.StudentEnrollmentEntryButton.TabIndex = 3;
            this.StudentEnrollmentEntryButton.Text = "Student Enrollment Entry";
            this.StudentEnrollmentEntryButton.UseVisualStyleBackColor = true;
            this.StudentEnrollmentEntryButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // StudentGradeEntryButton
            // 
            this.StudentGradeEntryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentGradeEntryButton.Location = new System.Drawing.Point(200, 98);
            this.StudentGradeEntryButton.Name = "StudentGradeEntryButton";
            this.StudentGradeEntryButton.Size = new System.Drawing.Size(111, 55);
            this.StudentGradeEntryButton.TabIndex = 4;
            this.StudentGradeEntryButton.Text = "Student Grade Entry\r\n";
            this.StudentGradeEntryButton.UseVisualStyleBackColor = true;
            this.StudentGradeEntryButton.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(442, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 92);
            this.label1.TabIndex = 5;
            this.label1.Text = "UNIVERSITY\r\nOF SCHOOL\r\n";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(132)))), ((int)(((byte)(144)))));
            this.groupBox1.Controls.Add(this.ExitButton);
            this.groupBox1.Controls.Add(this.SubjectEntryFormButton);
            this.groupBox1.Controls.Add(this.StudentEntryButton);
            this.groupBox1.Controls.Add(this.StudentGradeEntryButton);
            this.groupBox1.Controls.Add(this.SubjectSchedEntryButton);
            this.groupBox1.Controls.Add(this.StudentEnrollmentEntryButton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(28, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(361, 252);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enrollment System";
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(200, 159);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(111, 55);
            this.ExitButton.TabIndex = 5;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // TestButton
            // 
            this.TestButton.Location = new System.Drawing.Point(660, 381);
            this.TestButton.Name = "TestButton";
            this.TestButton.Size = new System.Drawing.Size(75, 23);
            this.TestButton.TabIndex = 7;
            this.TestButton.Text = "Test";
            this.TestButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.TestButton.UseVisualStyleBackColor = true;
            this.TestButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TestButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SubjectEntryFormButton;
        private System.Windows.Forms.Button StudentEntryButton;
        private System.Windows.Forms.Button SubjectSchedEntryButton;
        private System.Windows.Forms.Button StudentEnrollmentEntryButton;
        private System.Windows.Forms.Button StudentGradeEntryButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button TestButton;
    }
}