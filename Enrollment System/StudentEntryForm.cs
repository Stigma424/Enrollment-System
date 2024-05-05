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
    public partial class StudentEntryForm : Form
    {
        public StudentEntryForm()
        {
            InitializeComponent();
        }

        private void SISubjectCodeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click_1(object sender, EventArgs e)
        {

        }

        private void RemarkscomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void YeartextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CoursetextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void MiddleinitialtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void firstnametextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LastnametextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void StatuscomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void IdnotextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Savebutton_Click(object sender, EventArgs e)
        {
            OleDbConnection thisConnection = new OleDbConnection(DatabaseConnectionString.connectionString);
            String thisCommand = "Select * From STUDENTFILE";
            OleDbDataAdapter thisAdapter = new OleDbDataAdapter(thisCommand, thisConnection);
            OleDbCommandBuilder thisBuilder = new OleDbCommandBuilder(thisAdapter);
            DataSet studentInformationDataSet = new DataSet();
            thisAdapter.Fill(studentInformationDataSet, "StudentFile");
            DataRow studentInformationRow = studentInformationDataSet.Tables["StudentFile"].NewRow();
            Conditions condition = new Conditions();
            String[] textBoxes = { IdTextBox.Text, LastNameTextBox.Text, FirstNameTextBox.Text,
                                   MiddleinitialtTextBox.Text, CourseTextBox.Text, YearTextBox.Text, RemarkscomboBox.Text, 
                                   StatuscomboBox.Text };
            Boolean isNotNull = condition.IsNotNull(textBoxes),isValid,isIdInt,isYearInt;
            if (isNotNull)
            {
                isValid = condition.IsValid("StudentFile",studentInformationDataSet, IdTextBox.Text.Trim(), 0);
                if (isValid)
                {
                    isIdInt = condition.isInteger(IdTextBox.Text);
                    isYearInt = condition.isInteger(YearTextBox.Text);
                    if (isYearInt && isIdInt)
                    {
                        studentInformationRow["STFSTUDID"] = Convert.ToInt32(IdTextBox.Text.Trim());
                        studentInformationRow["STFSTUDLNAME"] = LastNameTextBox.Text.Trim();
                        studentInformationRow["STFSTUDFNAME"] = FirstNameTextBox.Text.Trim();
                        studentInformationRow["STFSTUDMNAME"] = MiddleinitialtTextBox.Text.Trim();
                        studentInformationRow["STFSTUDCOURSE"] = CourseTextBox.Text.Trim().ToUpper();
                        studentInformationRow["STFSTUDYEAR"] = Convert.ToInt16(YearTextBox.Text.Trim());
                        studentInformationRow["STFSTUDREMARKS"] = RemarkscomboBox.Text.Trim();
                        studentInformationRow["STFSTUDSTATUS"] = StatuscomboBox.Text.Trim().Substring(0, 2).ToUpper();
                        MessageBox.Show("Entry Recorded");
                        studentInformationDataSet.Tables["StudentFile"].Rows.Add(studentInformationRow);
                        thisAdapter.Update(studentInformationDataSet, "StudentFile");
                    }
                    else
                    {
                        MessageBox.Show("Student ID and Year must be Numbers");
                    }
                }
                else
                {
                    MessageBox.Show("Another Entry with the same Student ID has been found");
                }
            }
            else
            {
                MessageBox.Show("Field Entry Required");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            Hide();
            mainMenu.ShowDialog();
            Close();
        }

        private void DisplayButton_Click(object sender, EventArgs e)
        {
            DisplayStudentList displayStudent = new DisplayStudentList();
            Hide();
            displayStudent.ShowDialog();
            Close();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            IdTextBox.Text = "";
            LastNameTextBox.Text = "";
            FirstNameTextBox.Text = "";
            MiddleinitialtTextBox.Text = "";
            CourseTextBox.Text = "";
            YearTextBox.Text = "";
            RemarkscomboBox.Text = "";
            StatuscomboBox.Text = "";
        }
    }
}
