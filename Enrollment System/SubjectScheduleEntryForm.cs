using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enrollment_System
{
    public partial class SubjectScheduleEntryForm : Form
    {
        public SubjectScheduleEntryForm()
        {
            InitializeComponent();
        }

        private void StartAMPMCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        // TO-DO
        // Make it so that putting an entry of subjects with conflicting days,time,and room will not be allowed
        private void SaveButon_Click(object sender, EventArgs e)
        {
            OleDbConnection thisConnection = new OleDbConnection(DatabaseConnectionString.connectionString);
            String thisCommand = "Select * From SUBJECTSCHEDFILE";
            OleDbDataAdapter thisAdapter = new OleDbDataAdapter(thisCommand, thisConnection);
            OleDbCommandBuilder thisBuilder = new OleDbCommandBuilder(thisAdapter);
            DataSet DataSet = new DataSet();
            thisAdapter.Fill(DataSet, "SubjectSchedFile");
            DataRow thisRow = DataSet.Tables["SubjectSchedFile"].NewRow();
            Conditions condition = new Conditions();
            String[] text = {SubjectEDPCodeTextbox.Text, SubjectCodeTextbox.Text,TimeStartHourComboBox.Text,TimeStartMinuteComboBox.Text,StartCombobox.Text,
                            TimeEndHourComboBox.Text,TimeStartMinuteComboBox.Text,EndCombobox.Text,RoomTextbox.Text,StatusComboBox.Text,SectionTextbox.Text
                            ,SchoolYearTextbox.Text};
            String days;
            Boolean isNotNull = condition.IsNotNull(text),isDaysNotNull = CheckDays(), isValid,isYearInt;
            if (isNotNull && isDaysNotNull)
            {
                days = DaysChosen();
                isValid = condition.IsValid("SubjectSchedFile", DataSet, SubjectEDPCodeTextbox.Text,0);
                if (isValid)
                {
                    isYearInt = condition.isInteger(SchoolYearTextbox.Text);
                    if(isYearInt)
                    {
                        thisRow["SSFEDPCODE"] = SubjectEDPCodeTextbox.Text.Trim();
                        thisRow["SSFSUBJCODE"] = SubjectCodeTextbox.Text.Trim();
                        thisRow["SSFSTARTTIME"] = TimeStartHourComboBox.Text +":"+TimeStartMinuteComboBox.Text + StartCombobox.Text.Trim();
                        thisRow["SSFENDTIME"] =TimeEndHourComboBox.Text + ":"+TimeEndMinuteComboBox.Text + EndCombobox.Text.Trim();
                        thisRow["SSFDAYS"] = days;
                        thisRow["SSFROOM"] =RoomTextbox.Text.Trim().Substring(1,4);
                        thisRow["SSFMAXSIZE"] = 50;
                        thisRow["SSFCLASSSIZE"] = 0;
                        thisRow["SSFSTATUS"] = StatusComboBox.Text.Trim().Substring(0,2);
                        thisRow["SSFXM"] = StartCombobox.Text.Trim()+ EndCombobox.Text.Trim();
                        thisRow["SSFSECTION"] = SectionTextbox.Text.Trim().ToUpper();
                        thisRow["SSFSCHOOLYEAR"] = SchoolYearTextbox.Text.Trim();
                        MessageBox.Show("Entry Recorded");
                        DataSet.Tables["SubjectSchedFile"].Rows.Add(thisRow);
                        thisAdapter.Update(DataSet, "SubjectSchedFile");
                    }
                    else
                    {
                        MessageBox.Show("Year must be a Number");
                    }
                }
                else
                {
                    MessageBox.Show("Another Entry with the same Subject EDP Code has been found");
                }
            }
            else
            {
                MessageBox.Show("Field Entry Required");
            }
        }
        /// <summary>
        /// Method to check if user has atleast checked one checkbox for days
        /// </summary>
        /// <returns>Return boolean value to check if all checkbox of days is unchecked returns false or if 1 or more return true</returns>
        private Boolean CheckDays()
        {
            if (MondayCheckBox.Checked || TuesdayCheckBox.Checked ||WednesdayCheckBox.Checked ||ThursdayCheckBox.Checked ||FridayCheckBox.Checked || SaturdayCheckBox.Checked)
            {
                return true;
            }

            return false;
        }
        /// <summary>
        /// Methods to check what days are chosen and what check Boxes are checked
        /// </summary>
        /// <returns>returns the day chosen as String</returns>
        private String DaysChosen()
        {
            String days = "";
            String[] daysText = { MondayCheckBox.Text.Trim(), TuesdayCheckBox.Text.Trim(), WednesdayCheckBox.Text.Trim(), ThursdayCheckBox.Text.Trim()
                                ,FridayCheckBox.Text.Trim(),SaturdayCheckBox.Text.Trim() };
            Boolean[] daysChecked = {MondayCheckBox.Checked , TuesdayCheckBox.Checked, WednesdayCheckBox.Checked, ThursdayCheckBox.Checked, FridayCheckBox.Checked,
                                    SaturdayCheckBox.Checked };
            for (int i = 0; i < daysText.Length; i++)
            {
                if (daysChecked[i])
                {
                    if (daysText[i].ToUpper().Equals( "THURSDAY"))
                    {
                        days += daysText[i].Trim().ToUpper().Substring(0, 2);
                    }
                    else
                    {
                        days += daysText[i].Trim().ToUpper().Substring(0, 1);
                    }
                }
            }
            return days;
        }
        private void TimeStartTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void DaysTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SubjectEDPCodeTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void StatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            Hide();
            mainMenu.ShowDialog();
            Close();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void TestButton_Click(object sender, EventArgs e)
        {
            DateTime dateTime = new DateTime();
        }

        private void TimeStartHourComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
