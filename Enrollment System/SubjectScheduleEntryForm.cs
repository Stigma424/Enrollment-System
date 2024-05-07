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
        //TODO ALOT = Do something about the DATETIME in database / Condition to avoid time end must not be lesser than start
        //days room conflict and more conditions
        // include list soon
        //COMPLETION SAVING = 80% CONDITIONS = NAH UI = TRASH
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
            Boolean isNotNull = condition.IsNotNull(text),isDaysNotNull = CheckDays(), isNotValid,isYearNotInt,isConflictedRoom
                ,isConflictedTime,isConflictedDays, isSubjCodeNotFound;
            if(isNotNull && isDaysNotNull)
            {
                MessageBox.Show("Field Entry Required");
                return;
            }
            days = DaysChosen();
            isNotValid = condition.IsValid("SubjectSchedFile", DataSet, SubjectEDPCodeTextbox.Text, 0);
            if (isNotValid)
            {
                MessageBox.Show("Another Entry with the same Subject EDP Code has been found");
                return;
            }
            isYearNotInt = condition.isInteger(SchoolYearTextbox.Text);
            if (isYearNotInt)
            {
                MessageBox.Show("Year must be a Number");
                return;
            }
            isSubjCodeNotFound = CheckSubjectCode();
            if ( isSubjCodeNotFound)
            {
                MessageBox.Show("Subject Code Not Found");
                return;
            }
            isConflictedRoom = CheckConflictRoom(DataSet);
            isConflictedDays = CheckConflictDays(DataSet);
            isConflictedTime = CheckConflictTime(DataSet);
            if (isConflictedRoom && isConflictedDays && isConflictedTime)
            {
                String message = " ";
                if (isConflictedTime)
                {
                    message += "Time ";
                }
                if (isConflictedDays)
                {
                    message += "Days ";
                }
                if (isConflictedRoom)
                {
                    message += "Room ";
                }
                MessageBox.Show("Existing Schedule with the same"+message+"has been found");
                return;
            }
            thisRow["SSFEDPCODE"] = SubjectEDPCodeTextbox.Text.Trim();
            thisRow["SSFSUBJCODE"] = SubjectCodeTextbox.Text.Trim();
            thisRow["SSFSTARTTIME"] = TimeStartHourComboBox.Text + ":" + TimeStartMinuteComboBox.Text + StartCombobox.Text.Trim();
            thisRow["SSFENDTIME"] = TimeEndHourComboBox.Text + ":" + TimeEndMinuteComboBox.Text + EndCombobox.Text.Trim();
            thisRow["SSFDAYS"] = days;
            thisRow["SSFROOM"] = RoomTextbox.Text.Trim().ToString().Substring(0, 4);
            thisRow["SSFMAXSIZE"] = 50;
            thisRow["SSFCLASSSIZE"] = 0;
            thisRow["SSFSTATUS"] = StatusComboBox.Text.Trim().Substring(0, 2);
            thisRow["SSFXM"] = StartCombobox.Text.Trim() + EndCombobox.Text.Trim();
            thisRow["SSFSECTION"] = SectionTextbox.Text.Trim().ToUpper();
            thisRow["SSFSCHOOLYEAR"] = SchoolYearTextbox.Text.Trim();
            MessageBox.Show("Entry Recorded");
            DataSet.Tables["SubjectSchedFile"].Rows.Add(thisRow);
            thisAdapter.Update(DataSet, "SubjectSchedFile");
            thisRow["SSFEDPCODE"] = SubjectEDPCodeTextbox.Text.Trim();
        }
        private Boolean CheckSubjectCode()
        {
            OleDbConnection thisConnection = new OleDbConnection(DatabaseConnectionString.connectionString);
            String thisCommand = "Select * From SUBJECTFILE";
            OleDbDataAdapter thisAdapter = new OleDbDataAdapter(thisCommand, thisConnection);
            OleDbCommandBuilder thisBuilder = new OleDbCommandBuilder(thisAdapter);
            DataSet thisDataSet = new DataSet();
            thisAdapter.Fill(thisDataSet, "SubjectFile");
            DataRow navigatorRow;
            int rowNavigator = 0;
            foreach (DataRow row in thisDataSet.Tables["SubjectFile"].Rows)
            {
                navigatorRow = thisDataSet.Tables["SubjectFile"].Rows[rowNavigator];
                if (navigatorRow.ItemArray.GetValue(0).ToString() == SubjectCodeTextbox.Text)
                {
                    return false;
                }
                rowNavigator++;

            }
            return true;
        }
        private Boolean CheckConflictDays(DataSet thisDataSet)
        {
            string daysInDatabase,daysFromCurrInput;
            DataRow navigatorRow;
            int rowNavigator = 0;
            daysFromCurrInput = DaysChosen(); daysFromCurrInput = ExpandDay(daysFromCurrInput);
            string[] daysExpandedCurr = daysFromCurrInput.Split(' ');
            string[] daysExpandedDatabase;
            foreach (DataRow row in thisDataSet.Tables["SubjectSchedFile"].Rows)
            {
                navigatorRow = thisDataSet.Tables["SubjectSchedFile"].Rows[rowNavigator];
                daysInDatabase = navigatorRow.ItemArray.GetValue(4).ToString();
                daysInDatabase = ExpandDay(daysInDatabase);
                daysExpandedDatabase = daysInDatabase.Split(' ');
                foreach (String dayDatabase in daysExpandedDatabase)
                {
                    foreach (String dayCurr in daysExpandedCurr)
                    {
                        if (dayDatabase == dayCurr)
                        {
                            return false;
                        }
                    }
                }
                rowNavigator++;

            }
            return true;
        }
        
        private Boolean CheckConflictRoom(DataSet thisDataSet)
        {
            DataRow navigatorRow;
            int rowNavigator = 0;
            foreach (DataRow row in thisDataSet.Tables["SubjectSchedFile"].Rows)
            {
                navigatorRow = thisDataSet.Tables["SubjectSchedFile"].Rows[rowNavigator];
                if (navigatorRow.ItemArray.GetValue(5).ToString() == RoomTextbox.Text)
                {
                    if (!navigatorRow.ItemArray.GetValue(8).ToString().ToUpper().Equals("AC"))
                    {
                        return false;
                    }
                }
                rowNavigator++;

            }
            return true;
        }
        private Boolean CheckConflictTime(DataSet thisDataSet)
        {
            DateTime timeStart = Convert.ToDateTime(TimeStartHourComboBox.Text + ":" + TimeStartMinuteComboBox.Text + StartCombobox.Text.Trim()),
                     timeEnd = Convert.ToDateTime(TimeEndHourComboBox.Text + ":" + TimeEndMinuteComboBox.Text + EndCombobox.Text.Trim());
            DataRow navigatorRow;
            int rowNavigator = 0;
            foreach (DataRow row in thisDataSet.Tables["SubjectSchedFile"].Rows)
            {
                navigatorRow = thisDataSet.Tables["SubjectSchedFile"].Rows[rowNavigator];
                if (Convert.ToDateTime(Convert.ToDateTime(navigatorRow.ItemArray.GetValue(2).ToString()).ToString("HH:mm")) < Convert.ToDateTime(timeEnd.ToString("HH:mm")) 
                    && Convert.ToDateTime(Convert.ToDateTime(navigatorRow.ItemArray.GetValue(3).ToString()).ToString("HH:mm")) > Convert.ToDateTime(timeStart.ToString("HH:mm")))
                {
                    if (!navigatorRow.ItemArray.GetValue(8).ToString().ToUpper().Equals("AC"))
                    {
                        return false;
                    }
                }
                rowNavigator++;

            }
            return true;
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
                    if (daysText[i].ToUpper().Equals("THURSDAY"))
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
        private string ExpandDay(string words)
        {
            string expandedDays = "";

            for (int i = 0; i < words.Length; i++)
            {
                string dayAbbreviation = words[i].ToString().ToLower();

                switch (dayAbbreviation)
                {
                    case "m":
                        expandedDays += "MONDAY ";
                        break;
                    case "t":
                        if (i < words.Length - 1 && words[i + 1].ToString() == "H")
                        {
                            expandedDays += "THURSDAY ";
                            i++;
                        }
                        else
                        {
                            expandedDays += "TUESDAY ";
                        }
                        break;
                    case "w":
                        expandedDays += "WEDNESDAY ";
                        break;
                    case "f":
                        expandedDays += "FRIDAY ";
                        break;
                    case "s":
                        expandedDays += "SATURDAY ";
                        i++;
                        break;
                }
            }
            return expandedDays;
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
            string test = ExpandDay("MTWTH");
           MessageBox.Show(test);
        }

        private void TimeStartHourComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
