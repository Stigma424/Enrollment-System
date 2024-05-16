namespace Enrollment_System
{
    partial class SubjectEntryForm
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
            this.SISubjectCodeTextBox = new System.Windows.Forms.TextBox();
            this.SIOfferingComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RIPreRequisiteRadioButton = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RICoRequisiteRadioButton = new System.Windows.Forms.RadioButton();
            this.label15 = new System.Windows.Forms.Label();
            this.RIRequisiteTextBox = new System.Windows.Forms.TextBox();
            this.SubjectDataGridView = new System.Windows.Forms.DataGridView();
            this.SubjectCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Units = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Requisite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaveButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SubjectDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SISubjectCodeTextBox
            // 
            this.SISubjectCodeTextBox.Location = new System.Drawing.Point(103, 28);
            this.SISubjectCodeTextBox.Name = "SISubjectCodeTextBox";
            this.SISubjectCodeTextBox.Size = new System.Drawing.Size(100, 23);
            this.SISubjectCodeTextBox.TabIndex = 1;
            this.SISubjectCodeTextBox.TextChanged += new System.EventHandler(this.SISubjectCodeTextBox_TextChanged);
            // 
            // SIOfferingComboBox
            // 
            this.SIOfferingComboBox.FormattingEnabled = true;
            this.SIOfferingComboBox.Items.AddRange(new object[] {
            "1 First Semester",
            "2 Second Semester",
            "3 Summer"});
            this.SIOfferingComboBox.Location = new System.Drawing.Point(103, 104);
            this.SIOfferingComboBox.Name = "SIOfferingComboBox";
            this.SIOfferingComboBox.Size = new System.Drawing.Size(121, 24);
            this.SIOfferingComboBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(299, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Subject Entry";
            // 
            // RIPreRequisiteRadioButton
            // 
            this.RIPreRequisiteRadioButton.AutoSize = true;
            this.RIPreRequisiteRadioButton.Location = new System.Drawing.Point(198, 19);
            this.RIPreRequisiteRadioButton.Name = "RIPreRequisiteRadioButton";
            this.RIPreRequisiteRadioButton.Size = new System.Drawing.Size(88, 17);
            this.RIPreRequisiteRadioButton.TabIndex = 3;
            this.RIPreRequisiteRadioButton.TabStop = true;
            this.RIPreRequisiteRadioButton.Text = "Pre-Requisite";
            this.RIPreRequisiteRadioButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Subject Code";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(108)))), ((int)(((byte)(168)))));
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
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 233);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Subject Information";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 190);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Curriculum Year";
            // 
            // SICurriculumYearTextBox
            // 
            this.SICurriculumYearTextBox.Location = new System.Drawing.Point(124, 184);
            this.SICurriculumYearTextBox.Name = "SICurriculumYearTextBox";
            this.SICurriculumYearTextBox.Size = new System.Drawing.Size(100, 23);
            this.SICurriculumYearTextBox.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Course Code";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Category";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Offering";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // SICategoryComboBox
            // 
            this.SICategoryComboBox.FormattingEnabled = true;
            this.SICategoryComboBox.Items.AddRange(new object[] {
            "LECTURE",
            "LABORATORY"});
            this.SICategoryComboBox.Location = new System.Drawing.Point(103, 133);
            this.SICategoryComboBox.Name = "SICategoryComboBox";
            this.SICategoryComboBox.Size = new System.Drawing.Size(121, 24);
            this.SICategoryComboBox.TabIndex = 9;
            // 
            // SICourseCodeComboBox
            // 
            this.SICourseCodeComboBox.FormattingEnabled = true;
            this.SICourseCodeComboBox.Items.AddRange(new object[] {
            "BSIT",
            "BSIS",
            "BSIT:SE",
            "ACT",
            "BSN",
            "ABM",
            "BSED"});
            this.SICourseCodeComboBox.Location = new System.Drawing.Point(103, 157);
            this.SICourseCodeComboBox.Name = "SICourseCodeComboBox";
            this.SICourseCodeComboBox.Size = new System.Drawing.Size(121, 24);
            this.SICourseCodeComboBox.TabIndex = 8;
            // 
            // SIUnitsTextBox
            // 
            this.SIUnitsTextBox.Location = new System.Drawing.Point(103, 80);
            this.SIUnitsTextBox.Name = "SIUnitsTextBox";
            this.SIUnitsTextBox.Size = new System.Drawing.Size(58, 23);
            this.SIUnitsTextBox.TabIndex = 7;
            // 
            // SIDescriptionTextBox
            // 
            this.SIDescriptionTextBox.Location = new System.Drawing.Point(103, 54);
            this.SIDescriptionTextBox.Name = "SIDescriptionTextBox";
            this.SIDescriptionTextBox.Size = new System.Drawing.Size(200, 23);
            this.SIDescriptionTextBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Units";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Description";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(108)))), ((int)(((byte)(168)))));
            this.groupBox2.Controls.Add(this.RICoRequisiteRadioButton);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.RIPreRequisiteRadioButton);
            this.groupBox2.Controls.Add(this.RIRequisiteTextBox);
            this.groupBox2.Location = new System.Drawing.Point(359, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(335, 74);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Requisite Information";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // RICoRequisiteRadioButton
            // 
            this.RICoRequisiteRadioButton.AutoSize = true;
            this.RICoRequisiteRadioButton.Location = new System.Drawing.Point(198, 42);
            this.RICoRequisiteRadioButton.Name = "RICoRequisiteRadioButton";
            this.RICoRequisiteRadioButton.Size = new System.Drawing.Size(85, 17);
            this.RICoRequisiteRadioButton.TabIndex = 16;
            this.RICoRequisiteRadioButton.TabStop = true;
            this.RICoRequisiteRadioButton.Text = "Co-Requisite";
            this.RICoRequisiteRadioButton.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 26);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 13);
            this.label15.TabIndex = 4;
            this.label15.Text = "Subject Code";
            // 
            // RIRequisiteTextBox
            // 
            this.RIRequisiteTextBox.Location = new System.Drawing.Point(82, 26);
            this.RIRequisiteTextBox.Name = "RIRequisiteTextBox";
            this.RIRequisiteTextBox.Size = new System.Drawing.Size(100, 20);
            this.RIRequisiteTextBox.TabIndex = 1;
            this.RIRequisiteTextBox.TextChanged += new System.EventHandler(this.RIRequisiteTextBox_TextChanged);
            this.RIRequisiteTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RIRequisiteTextBox_KeyPress);
            // 
            // SubjectDataGridView
            // 
            this.SubjectDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(132)))), ((int)(((byte)(144)))));
            this.SubjectDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SubjectDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SubjectCode,
            this.Description,
            this.Units,
            this.Requisite});
            this.SubjectDataGridView.Location = new System.Drawing.Point(359, 132);
            this.SubjectDataGridView.Name = "SubjectDataGridView";
            this.SubjectDataGridView.Size = new System.Drawing.Size(429, 235);
            this.SubjectDataGridView.TabIndex = 17;
            // 
            // SubjectCode
            // 
            this.SubjectCode.HeaderText = "Subject Code";
            this.SubjectCode.Name = "SubjectCode";
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            // 
            // Units
            // 
            this.Units.HeaderText = "Units";
            this.Units.Name = "Units";
            // 
            // Requisite
            // 
            this.Requisite.HeaderText = "Co/Pre";
            this.Requisite.Name = "Requisite";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(73, 308);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 16;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(196, 308);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 17;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(140, 344);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 18;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(22)))), ((int)(((byte)(32)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(132)))), ((int)(((byte)(144)))));
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 34);
            this.panel1.TabIndex = 19;
            // 
            // SubjectEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(81)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.SubjectDataGridView);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "SubjectEntryForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SubjectDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox SISubjectCodeTextBox;
        private System.Windows.Forms.ComboBox SIOfferingComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton RIPreRequisiteRadioButton;
        private System.Windows.Forms.Label label2;
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView SubjectDataGridView;
        private System.Windows.Forms.RadioButton RICoRequisiteRadioButton;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox RIRequisiteTextBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Units;
        private System.Windows.Forms.DataGridViewTextBoxColumn Requisite;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Panel panel1;
    }
}

