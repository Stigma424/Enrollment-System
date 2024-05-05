namespace Enrollment_System
{
    partial class SubjectScheduleEntryForm
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
            this.TimeEndMinuteComboBox = new System.Windows.Forms.ComboBox();
            this.TimeEndHourComboBox = new System.Windows.Forms.ComboBox();
            this.TimeStartMinuteComboBox = new System.Windows.Forms.ComboBox();
            this.TimeStartHourComboBox = new System.Windows.Forms.ComboBox();
            this.FridayCheckBox = new System.Windows.Forms.CheckBox();
            this.StatusComboBox = new System.Windows.Forms.ComboBox();
            this.SaturdayCheckBox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ThursdayCheckBox = new System.Windows.Forms.CheckBox();
            this.WednesdayCheckBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SaveButon = new System.Windows.Forms.Button();
            this.TuesdayCheckBox = new System.Windows.Forms.CheckBox();
            this.EndCombobox = new System.Windows.Forms.ComboBox();
            this.MondayCheckBox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.StartCombobox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SchoolYearTextbox = new System.Windows.Forms.TextBox();
            this.SubjectEDPCodeTextbox = new System.Windows.Forms.TextBox();
            this.RoomTextbox = new System.Windows.Forms.TextBox();
            this.SubjectCodeTextbox = new System.Windows.Forms.TextBox();
            this.SectionTextbox = new System.Windows.Forms.TextBox();
            this.BackButton = new System.Windows.Forms.Button();
            this.DisplayButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TestButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TimeEndMinuteComboBox);
            this.groupBox1.Controls.Add(this.TimeEndHourComboBox);
            this.groupBox1.Controls.Add(this.TimeStartMinuteComboBox);
            this.groupBox1.Controls.Add(this.TimeStartHourComboBox);
            this.groupBox1.Controls.Add(this.FridayCheckBox);
            this.groupBox1.Controls.Add(this.StatusComboBox);
            this.groupBox1.Controls.Add(this.SaturdayCheckBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.ThursdayCheckBox);
            this.groupBox1.Controls.Add(this.WednesdayCheckBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.SaveButon);
            this.groupBox1.Controls.Add(this.TuesdayCheckBox);
            this.groupBox1.Controls.Add(this.EndCombobox);
            this.groupBox1.Controls.Add(this.MondayCheckBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.ClearButton);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.StartCombobox);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.SchoolYearTextbox);
            this.groupBox1.Controls.Add(this.SubjectEDPCodeTextbox);
            this.groupBox1.Controls.Add(this.RoomTextbox);
            this.groupBox1.Controls.Add(this.SubjectCodeTextbox);
            this.groupBox1.Controls.Add(this.SectionTextbox);
            this.groupBox1.Location = new System.Drawing.Point(12, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(450, 373);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Subject Schedule Information";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // TimeEndMinuteComboBox
            // 
            this.TimeEndMinuteComboBox.FormattingEnabled = true;
            this.TimeEndMinuteComboBox.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.TimeEndMinuteComboBox.Location = new System.Drawing.Point(251, 164);
            this.TimeEndMinuteComboBox.Name = "TimeEndMinuteComboBox";
            this.TimeEndMinuteComboBox.Size = new System.Drawing.Size(50, 21);
            this.TimeEndMinuteComboBox.TabIndex = 55;
            this.TimeEndMinuteComboBox.Text = "Min";
            // 
            // TimeEndHourComboBox
            // 
            this.TimeEndHourComboBox.FormattingEnabled = true;
            this.TimeEndHourComboBox.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.TimeEndHourComboBox.Location = new System.Drawing.Point(196, 164);
            this.TimeEndHourComboBox.Name = "TimeEndHourComboBox";
            this.TimeEndHourComboBox.Size = new System.Drawing.Size(49, 21);
            this.TimeEndHourComboBox.TabIndex = 56;
            this.TimeEndHourComboBox.Text = "Hour";
            // 
            // TimeStartMinuteComboBox
            // 
            this.TimeStartMinuteComboBox.FormattingEnabled = true;
            this.TimeStartMinuteComboBox.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.TimeStartMinuteComboBox.Location = new System.Drawing.Point(251, 122);
            this.TimeStartMinuteComboBox.Name = "TimeStartMinuteComboBox";
            this.TimeStartMinuteComboBox.Size = new System.Drawing.Size(50, 21);
            this.TimeStartMinuteComboBox.TabIndex = 57;
            this.TimeStartMinuteComboBox.Text = "Min";
            // 
            // TimeStartHourComboBox
            // 
            this.TimeStartHourComboBox.FormattingEnabled = true;
            this.TimeStartHourComboBox.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.TimeStartHourComboBox.Location = new System.Drawing.Point(196, 122);
            this.TimeStartHourComboBox.Name = "TimeStartHourComboBox";
            this.TimeStartHourComboBox.Size = new System.Drawing.Size(49, 21);
            this.TimeStartHourComboBox.TabIndex = 58;
            this.TimeStartHourComboBox.Text = "Hour";
            this.TimeStartHourComboBox.SelectedIndexChanged += new System.EventHandler(this.TimeStartHourComboBox_SelectedIndexChanged);
            // 
            // FridayCheckBox
            // 
            this.FridayCheckBox.AutoSize = true;
            this.FridayCheckBox.Location = new System.Drawing.Point(311, 177);
            this.FridayCheckBox.Name = "FridayCheckBox";
            this.FridayCheckBox.Size = new System.Drawing.Size(54, 17);
            this.FridayCheckBox.TabIndex = 59;
            this.FridayCheckBox.Text = "Friday";
            this.FridayCheckBox.UseVisualStyleBackColor = true;
            // 
            // StatusComboBox
            // 
            this.StatusComboBox.FormattingEnabled = true;
            this.StatusComboBox.Items.AddRange(new object[] {
            "Active",
            "Inactive",
            "Dissolved",
            "Restricted",
            "Closed"});
            this.StatusComboBox.Location = new System.Drawing.Point(137, 232);
            this.StatusComboBox.Name = "StatusComboBox";
            this.StatusComboBox.Size = new System.Drawing.Size(121, 21);
            this.StatusComboBox.TabIndex = 53;
            this.StatusComboBox.SelectedIndexChanged += new System.EventHandler(this.StatusComboBox_SelectedIndexChanged);
            // 
            // SaturdayCheckBox
            // 
            this.SaturdayCheckBox.AutoSize = true;
            this.SaturdayCheckBox.Location = new System.Drawing.Point(311, 200);
            this.SaturdayCheckBox.Name = "SaturdayCheckBox";
            this.SaturdayCheckBox.Size = new System.Drawing.Size(68, 17);
            this.SaturdayCheckBox.TabIndex = 58;
            this.SaturdayCheckBox.Text = "Saturday";
            this.SaturdayCheckBox.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 52;
            this.label4.Text = "Status";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ThursdayCheckBox
            // 
            this.ThursdayCheckBox.AutoSize = true;
            this.ThursdayCheckBox.Location = new System.Drawing.Point(311, 154);
            this.ThursdayCheckBox.Name = "ThursdayCheckBox";
            this.ThursdayCheckBox.Size = new System.Drawing.Size(70, 17);
            this.ThursdayCheckBox.TabIndex = 56;
            this.ThursdayCheckBox.Text = "Thursday";
            this.ThursdayCheckBox.UseVisualStyleBackColor = true;
            this.ThursdayCheckBox.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // WednesdayCheckBox
            // 
            this.WednesdayCheckBox.AutoSize = true;
            this.WednesdayCheckBox.Location = new System.Drawing.Point(311, 131);
            this.WednesdayCheckBox.Name = "WednesdayCheckBox";
            this.WednesdayCheckBox.Size = new System.Drawing.Size(83, 17);
            this.WednesdayCheckBox.TabIndex = 57;
            this.WednesdayCheckBox.Text = "Wednesday";
            this.WednesdayCheckBox.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Subject EDP Code:";
            // 
            // SaveButon
            // 
            this.SaveButon.Location = new System.Drawing.Point(321, 257);
            this.SaveButon.Margin = new System.Windows.Forms.Padding(2);
            this.SaveButon.Name = "SaveButon";
            this.SaveButon.Size = new System.Drawing.Size(70, 24);
            this.SaveButon.TabIndex = 46;
            this.SaveButon.Text = "Save";
            this.SaveButon.UseVisualStyleBackColor = true;
            this.SaveButon.Click += new System.EventHandler(this.SaveButon_Click);
            // 
            // TuesdayCheckBox
            // 
            this.TuesdayCheckBox.AutoSize = true;
            this.TuesdayCheckBox.Location = new System.Drawing.Point(311, 108);
            this.TuesdayCheckBox.Name = "TuesdayCheckBox";
            this.TuesdayCheckBox.Size = new System.Drawing.Size(67, 17);
            this.TuesdayCheckBox.TabIndex = 55;
            this.TuesdayCheckBox.Text = "Tuesday";
            this.TuesdayCheckBox.UseVisualStyleBackColor = true;
            // 
            // EndCombobox
            // 
            this.EndCombobox.FormattingEnabled = true;
            this.EndCombobox.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.EndCombobox.Location = new System.Drawing.Point(130, 164);
            this.EndCombobox.Margin = new System.Windows.Forms.Padding(2);
            this.EndCombobox.Name = "EndCombobox";
            this.EndCombobox.Size = new System.Drawing.Size(48, 21);
            this.EndCombobox.TabIndex = 51;
            this.EndCombobox.Text = "AM";
            // 
            // MondayCheckBox
            // 
            this.MondayCheckBox.AutoSize = true;
            this.MondayCheckBox.Location = new System.Drawing.Point(311, 85);
            this.MondayCheckBox.Name = "MondayCheckBox";
            this.MondayCheckBox.Size = new System.Drawing.Size(64, 17);
            this.MondayCheckBox.TabIndex = 54;
            this.MondayCheckBox.Text = "Monday";
            this.MondayCheckBox.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Subject Code:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "TIme Start";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Time End:";
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(321, 287);
            this.ClearButton.Margin = new System.Windows.Forms.Padding(2);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(70, 24);
            this.ClearButton.TabIndex = 47;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(291, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Days:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 268);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "Section";
            // 
            // StartCombobox
            // 
            this.StartCombobox.FormattingEnabled = true;
            this.StartCombobox.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.StartCombobox.Location = new System.Drawing.Point(130, 122);
            this.StartCombobox.Margin = new System.Windows.Forms.Padding(2);
            this.StartCombobox.Name = "StartCombobox";
            this.StartCombobox.Size = new System.Drawing.Size(48, 21);
            this.StartCombobox.TabIndex = 45;
            this.StartCombobox.Text = "AM";
            this.StartCombobox.SelectedIndexChanged += new System.EventHandler(this.StartAMPMCombobox_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 204);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 35;
            this.label9.Text = "Room:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 298);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 13);
            this.label10.TabIndex = 36;
            this.label10.Text = "School Year:";
            // 
            // SchoolYearTextbox
            // 
            this.SchoolYearTextbox.Location = new System.Drawing.Point(182, 296);
            this.SchoolYearTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.SchoolYearTextbox.Name = "SchoolYearTextbox";
            this.SchoolYearTextbox.Size = new System.Drawing.Size(76, 20);
            this.SchoolYearTextbox.TabIndex = 43;
            // 
            // SubjectEDPCodeTextbox
            // 
            this.SubjectEDPCodeTextbox.Location = new System.Drawing.Point(182, 47);
            this.SubjectEDPCodeTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.SubjectEDPCodeTextbox.Name = "SubjectEDPCodeTextbox";
            this.SubjectEDPCodeTextbox.Size = new System.Drawing.Size(76, 20);
            this.SubjectEDPCodeTextbox.TabIndex = 37;
            this.SubjectEDPCodeTextbox.TextChanged += new System.EventHandler(this.SubjectEDPCodeTextbox_TextChanged);
            // 
            // RoomTextbox
            // 
            this.RoomTextbox.Location = new System.Drawing.Point(182, 201);
            this.RoomTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.RoomTextbox.Name = "RoomTextbox";
            this.RoomTextbox.Size = new System.Drawing.Size(76, 20);
            this.RoomTextbox.TabIndex = 42;
            // 
            // SubjectCodeTextbox
            // 
            this.SubjectCodeTextbox.Location = new System.Drawing.Point(182, 80);
            this.SubjectCodeTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.SubjectCodeTextbox.Name = "SubjectCodeTextbox";
            this.SubjectCodeTextbox.Size = new System.Drawing.Size(76, 20);
            this.SubjectCodeTextbox.TabIndex = 38;
            // 
            // SectionTextbox
            // 
            this.SectionTextbox.Location = new System.Drawing.Point(182, 265);
            this.SectionTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.SectionTextbox.Name = "SectionTextbox";
            this.SectionTextbox.Size = new System.Drawing.Size(76, 20);
            this.SectionTextbox.TabIndex = 41;
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(515, 157);
            this.BackButton.Margin = new System.Windows.Forms.Padding(2);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(70, 24);
            this.BackButton.TabIndex = 52;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // DisplayButton
            // 
            this.DisplayButton.Location = new System.Drawing.Point(657, 157);
            this.DisplayButton.Margin = new System.Windows.Forms.Padding(2);
            this.DisplayButton.Name = "DisplayButton";
            this.DisplayButton.Size = new System.Drawing.Size(70, 24);
            this.DisplayButton.TabIndex = 53;
            this.DisplayButton.Text = "Display";
            this.DisplayButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(468, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 92);
            this.label1.TabIndex = 52;
            this.label1.Text = "Subject Schedule \r\n          Form";
            // 
            // TestButton
            // 
            this.TestButton.Location = new System.Drawing.Point(652, 394);
            this.TestButton.Name = "TestButton";
            this.TestButton.Size = new System.Drawing.Size(75, 23);
            this.TestButton.TabIndex = 54;
            this.TestButton.Text = "Test";
            this.TestButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.TestButton.UseVisualStyleBackColor = true;
            this.TestButton.Click += new System.EventHandler(this.TestButton_Click);
            // 
            // SubjectScheduleEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 465);
            this.Controls.Add(this.TestButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DisplayButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "SubjectScheduleEntryForm";
            this.Text = "StudentScheduleEntryForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.ComboBox EndCombobox;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button SaveButon;
        private System.Windows.Forms.ComboBox StartCombobox;
        private System.Windows.Forms.TextBox SchoolYearTextbox;
        private System.Windows.Forms.TextBox RoomTextbox;
        private System.Windows.Forms.TextBox SectionTextbox;
        private System.Windows.Forms.TextBox SubjectCodeTextbox;
        private System.Windows.Forms.TextBox SubjectEDPCodeTextbox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button DisplayButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox MondayCheckBox;
        private System.Windows.Forms.CheckBox TuesdayCheckBox;
        private System.Windows.Forms.ComboBox StatusComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox WednesdayCheckBox;
        private System.Windows.Forms.CheckBox ThursdayCheckBox;
        private System.Windows.Forms.CheckBox FridayCheckBox;
        private System.Windows.Forms.CheckBox SaturdayCheckBox;
        private System.Windows.Forms.Button TestButton;
        private System.Windows.Forms.ComboBox TimeEndMinuteComboBox;
        private System.Windows.Forms.ComboBox TimeEndHourComboBox;
        private System.Windows.Forms.ComboBox TimeStartMinuteComboBox;
        private System.Windows.Forms.ComboBox TimeStartHourComboBox;
    }
}