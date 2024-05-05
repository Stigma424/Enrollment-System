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
            String thisCommand;
            OleDbDataAdapter thisAdapter = new OleDbDataAdapter();
        }

        private void SubjectEnrollmentGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
