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
    public partial class DisplayStudentList : Form
    {
        public DisplayStudentList()
        {
            InitializeComponent();
            DisplayStudents();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        /// <summary>
        /// This method runs when the form is opened and it displays every list of students.
        /// </summary>
        private void DisplayStudents()
        {
            OleDbConnection thisConnection = new OleDbConnection(DatabaseConnectionString.connectionString);
            String thisCommand = "Select * From STUDENTFILE";
            OleDbDataAdapter thisAdapter = new OleDbDataAdapter(thisCommand, thisConnection);
            OleDbCommandBuilder thisBuilder = new OleDbCommandBuilder(thisAdapter);
            DataSet studentInformationDataSet = new DataSet();
            thisAdapter.Fill(studentInformationDataSet, "StudentFile");
            foreach (DataRow row in studentInformationDataSet.Tables["StudentFile"].Rows)
            {
                StudentListDataGridView.Rows.Add(row["STFSTUDID"], row["STFSTUDLNAME"], row["STFSTUDFNAME"], row["STFSTUDMNAME"], row["STFSTUDCOURSE"], row["STFSTUDYEAR"], row["STFSTUDREMARKS"], row["STFSTUDSTATUS"]);
            }
        }
        private void BackButton_Click(object sender, EventArgs e)
        {
            StudentEntryForm studentForm = new StudentEntryForm();
            Hide();
            studentForm.ShowDialog();
            Close();
        }
    }
}
