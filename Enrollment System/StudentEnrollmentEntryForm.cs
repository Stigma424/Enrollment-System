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
    public partial class StudentEnrollmentEntryForm : Form
    {
        public StudentEnrollmentEntryForm()
        {
            InitializeComponent();
            GiveDataToSubjectEnrollmentGridView();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            Hide();
            mainMenu.ShowDialog();
            Close();
        }
        //TODO ALOT
        //COMPLETION SAVING = 0% CONDITIONS = DEAD UI = TRASH
        private void GiveDataToSubjectEnrollmentGridView()
        {
            OleDbConnection thisConnection = new OleDbConnection(DatabaseConnectionString.connectionString);
            String thisCommand = "SELECT schedule.*,subject.SFSUBJUNITS  From SUBJECTSCHEDFILE schedule LEFT JOIN SUBJECTFILE subject ON schedule.SSFSUBJCODE = subject.SFSUBJCODE";
            OleDbDataAdapter thisAdapter = new OleDbDataAdapter(thisCommand, thisConnection);
            OleDbCommandBuilder thisCommandBuilder = new OleDbCommandBuilder(thisAdapter);
            DataSet thisDataSet = new DataSet();
            thisAdapter.Fill(thisDataSet, "SubjectSchedFile");
            foreach (DataRow row in thisDataSet.Tables["SubjectSchedFile"].Rows)
            {
                SubjectEnrollmentGridView.Rows.Add(row["SSFEDPCODE"], row["SSFSUBJCODE"], row["SSFSTARTTIME"], row["SSFENDTIME"], row["SSFDAYS"], row["SSFROOM"], row["SFSUBJUNITS"]);
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            OleDbConnection thisConnection = new OleDbConnection(DatabaseConnectionString.connectionString);
            String sql = "SELECT * FROM ENROLLMENTHEADERFILE";
            OleDbDataAdapter thisAdapter = new OleDbDataAdapter(sql,thisConnection);
            OleDbCommandBuilder thisBuilder = new OleDbCommandBuilder(thisAdapter);
            DataSet thisDataSet = new DataSet();

            Conditions conditions = new Conditions();
            string[] entryFields = {IDNumberTextbox.Text,NameTextbox.Text,CourseTextbox.Text,EDPCodeTextbox.Text,YearTextbox.Text,
                        EncoderTextbox.Text,EnrollmentDateTimePicker.Text,UnitsTextBox.Text};
            bool isNotNull;
            isNotNull = conditions.IsNotNull(entryFields);
            if (isNotNull)
            {
                MessageBox.Show("Enter Required Fields");
                return;
            }
            
        }

        private void SubjectEnrollmentGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupbox1_Enter(object sender, EventArgs e)
        {

        }

        private void IDNumberTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
               
                OleDbConnection thisConnection = new OleDbConnection(DatabaseConnectionString.connectionString);
                String sql = "SELECT * FROM STUDENTFILE";
                OleDbDataAdapter thisAdapter = new OleDbDataAdapter(sql, thisConnection);
                OleDbCommandBuilder thisBuilder = new OleDbCommandBuilder(thisAdapter);
                DataSet thisDataSet = new DataSet();
                thisAdapter.Fill(thisDataSet,"StudentFile");

                Conditions conditions = new Conditions();
                string[] entryFields = { IDNumberTextbox.Text };
                bool isNotNull;
                isNotNull = conditions.IsNotNull(entryFields);
                if(!isNotNull)
                {
                    MessageBox.Show("ID Number Required");
                    return;
                }
                DataRow navigatorRow;
                int rowNavigator = 0;
                foreach (DataRow row in thisDataSet.Tables["StudentFile"].Rows)
                {
                    navigatorRow = thisDataSet.Tables["StudentFile"].Rows[rowNavigator];
                    if (navigatorRow.ItemArray.GetValue(0).ToString() == IDNumberTextbox.Text.Trim())
                    {
                        NameTextbox.Text = navigatorRow.ItemArray[1].ToString()+" "+ navigatorRow.ItemArray[2].ToString() + " " + navigatorRow.ItemArray[3].ToString();
                        CourseTextbox.Text = navigatorRow.ItemArray[4].ToString();
                        YearTextbox.Text = navigatorRow.ItemArray[5].ToString();
                    }
                    rowNavigator++;
                }
            }
        }
    }
}
