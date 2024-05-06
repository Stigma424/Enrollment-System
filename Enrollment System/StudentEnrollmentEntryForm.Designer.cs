namespace Enrollment_System
{
    partial class StudentEnrollmentEntryForm
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
            this.BackButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.YearTextbox = new System.Windows.Forms.TextBox();
            this.EDPCodeTextbox = new System.Windows.Forms.TextBox();
            this.CourseTextbox = new System.Windows.Forms.TextBox();
            this.NameTextbox = new System.Windows.Forms.TextBox();
            this.IDNumberTextbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupbox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.EnrollmentDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.EncoderTextbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SubjectEnrollmentGridView = new System.Windows.Forms.DataGridView();
            this.EDPCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Days = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Room = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Units = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.UnitsTextBox = new System.Windows.Forms.TextBox();
            this.groupbox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SubjectEnrollmentGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(35, 410);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 19;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(250, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 31);
            this.label1.TabIndex = 20;
            this.label1.Text = "Student Enrollment Entry";
            // 
            // YearTextbox
            // 
            this.YearTextbox.Location = new System.Drawing.Point(74, 136);
            this.YearTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.YearTextbox.Name = "YearTextbox";
            this.YearTextbox.ReadOnly = true;
            this.YearTextbox.Size = new System.Drawing.Size(76, 20);
            this.YearTextbox.TabIndex = 30;
            // 
            // EDPCodeTextbox
            // 
            this.EDPCodeTextbox.Location = new System.Drawing.Point(74, 112);
            this.EDPCodeTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.EDPCodeTextbox.Name = "EDPCodeTextbox";
            this.EDPCodeTextbox.Size = new System.Drawing.Size(76, 20);
            this.EDPCodeTextbox.TabIndex = 29;
            // 
            // CourseTextbox
            // 
            this.CourseTextbox.Location = new System.Drawing.Point(74, 84);
            this.CourseTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.CourseTextbox.Name = "CourseTextbox";
            this.CourseTextbox.ReadOnly = true;
            this.CourseTextbox.Size = new System.Drawing.Size(76, 20);
            this.CourseTextbox.TabIndex = 28;
            // 
            // NameTextbox
            // 
            this.NameTextbox.Location = new System.Drawing.Point(74, 55);
            this.NameTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.NameTextbox.Name = "NameTextbox";
            this.NameTextbox.ReadOnly = true;
            this.NameTextbox.Size = new System.Drawing.Size(129, 20);
            this.NameTextbox.TabIndex = 27;
            // 
            // IDNumberTextbox
            // 
            this.IDNumberTextbox.Location = new System.Drawing.Point(74, 29);
            this.IDNumberTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.IDNumberTextbox.Name = "IDNumberTextbox";
            this.IDNumberTextbox.Size = new System.Drawing.Size(76, 20);
            this.IDNumberTextbox.TabIndex = 26;
            this.IDNumberTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IDNumberTextbox_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 117);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "EDP Code";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 139);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Year";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 87);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Course";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 34);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "ID Number";
            // 
            // groupbox1
            // 
            this.groupbox1.Controls.Add(this.IDNumberTextbox);
            this.groupbox1.Controls.Add(this.YearTextbox);
            this.groupbox1.Controls.Add(this.label6);
            this.groupbox1.Controls.Add(this.EDPCodeTextbox);
            this.groupbox1.Controls.Add(this.label2);
            this.groupbox1.Controls.Add(this.CourseTextbox);
            this.groupbox1.Controls.Add(this.label3);
            this.groupbox1.Controls.Add(this.NameTextbox);
            this.groupbox1.Controls.Add(this.label4);
            this.groupbox1.Controls.Add(this.label5);
            this.groupbox1.Location = new System.Drawing.Point(35, 52);
            this.groupbox1.Name = "groupbox1";
            this.groupbox1.Size = new System.Drawing.Size(231, 178);
            this.groupbox1.TabIndex = 31;
            this.groupbox1.TabStop = false;
            this.groupbox1.Text = "Student Information";
            this.groupbox1.Enter += new System.EventHandler(this.groupbox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SaveButton);
            this.groupBox2.Controls.Add(this.EnrollmentDateTimePicker);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.EncoderTextbox);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(35, 255);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(231, 126);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Encoder Information";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(138, 97);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 33;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // EnrollmentDateTimePicker
            // 
            this.EnrollmentDateTimePicker.Location = new System.Drawing.Point(41, 58);
            this.EnrollmentDateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.EnrollmentDateTimePicker.Name = "EnrollmentDateTimePicker";
            this.EnrollmentDateTimePicker.Size = new System.Drawing.Size(172, 20);
            this.EnrollmentDateTimePicker.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 65);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Date";
            // 
            // EncoderTextbox
            // 
            this.EncoderTextbox.Location = new System.Drawing.Point(74, 30);
            this.EncoderTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.EncoderTextbox.Name = "EncoderTextbox";
            this.EncoderTextbox.Size = new System.Drawing.Size(76, 20);
            this.EncoderTextbox.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 35);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Encoded By:";
            // 
            // SubjectEnrollmentGridView
            // 
            this.SubjectEnrollmentGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SubjectEnrollmentGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EDPCode,
            this.SubjectCode,
            this.StartTime,
            this.EndTime,
            this.Days,
            this.Room,
            this.Units});
            this.SubjectEnrollmentGridView.Location = new System.Drawing.Point(272, 72);
            this.SubjectEnrollmentGridView.Name = "SubjectEnrollmentGridView";
            this.SubjectEnrollmentGridView.RowHeadersWidth = 51;
            this.SubjectEnrollmentGridView.Size = new System.Drawing.Size(685, 277);
            this.SubjectEnrollmentGridView.TabIndex = 33;
            this.SubjectEnrollmentGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SubjectEnrollmentGridView_CellContentClick);
            // 
            // EDPCode
            // 
            this.EDPCode.HeaderText = "EDP Code";
            this.EDPCode.MinimumWidth = 6;
            this.EDPCode.Name = "EDPCode";
            this.EDPCode.Width = 125;
            // 
            // SubjectCode
            // 
            this.SubjectCode.HeaderText = "Subject Code";
            this.SubjectCode.MinimumWidth = 6;
            this.SubjectCode.Name = "SubjectCode";
            this.SubjectCode.Width = 125;
            // 
            // StartTime
            // 
            this.StartTime.HeaderText = "Start Time";
            this.StartTime.MinimumWidth = 6;
            this.StartTime.Name = "StartTime";
            this.StartTime.Width = 125;
            // 
            // EndTime
            // 
            this.EndTime.HeaderText = "EndTime";
            this.EndTime.MinimumWidth = 6;
            this.EndTime.Name = "EndTime";
            this.EndTime.Width = 125;
            // 
            // Days
            // 
            this.Days.HeaderText = "Days";
            this.Days.MinimumWidth = 6;
            this.Days.Name = "Days";
            this.Days.Width = 125;
            // 
            // Room
            // 
            this.Room.HeaderText = "Room";
            this.Room.MinimumWidth = 6;
            this.Room.Name = "Room";
            this.Room.Width = 125;
            // 
            // Units
            // 
            this.Units.HeaderText = "Units";
            this.Units.MinimumWidth = 6;
            this.Units.Name = "Units";
            this.Units.Width = 125;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(832, 368);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "Units:";
            // 
            // UnitsTextBox
            // 
            this.UnitsTextBox.Location = new System.Drawing.Point(881, 365);
            this.UnitsTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.UnitsTextBox.Name = "UnitsTextBox";
            this.UnitsTextBox.Size = new System.Drawing.Size(76, 20);
            this.UnitsTextBox.TabIndex = 31;
            // 
            // StudentEnrollmentEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 492);
            this.Controls.Add(this.UnitsTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.SubjectEnrollmentGridView);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupbox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BackButton);
            this.Name = "StudentEnrollmentEntryForm";
            this.Text = "EnrollmentEntryForm";
            this.groupbox1.ResumeLayout(false);
            this.groupbox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SubjectEnrollmentGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox YearTextbox;
        private System.Windows.Forms.TextBox EDPCodeTextbox;
        private System.Windows.Forms.TextBox CourseTextbox;
        private System.Windows.Forms.TextBox NameTextbox;
        private System.Windows.Forms.TextBox IDNumberTextbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupbox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.DateTimePicker EnrollmentDateTimePicker;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox EncoderTextbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView SubjectEnrollmentGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn EDPCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Days;
        private System.Windows.Forms.DataGridViewTextBoxColumn Room;
        private System.Windows.Forms.DataGridViewTextBoxColumn Units;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox UnitsTextBox;
    }
}