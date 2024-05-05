using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enrollment_System
{
    internal class UpdateScript
    {
        // Run this at application start
        // this Script will check status of subjects and subject scheds and inactive them
        public UpdateScript() 
        {
            UpdateSchedules();
        }
        //Work in progress
        private void UpdateSchedules()
        {
            OleDbConnection thisConnection = new OleDbConnection(DatabaseConnectionString.connectionString);
            String thisCommand = "Select * From SUBJECTSCHEDFILE";
            OleDbDataAdapter thisAdapter = new OleDbDataAdapter(thisCommand, thisConnection);
            OleDbCommandBuilder thisBuilder = new OleDbCommandBuilder(thisAdapter);
            DataSet thisDataSet = new DataSet();
            DateTime yearNow = DateTime.Now;
            thisAdapter.Fill(thisDataSet, "SubjectSchedFile");
            DataRow navigatorRow;
            int rowNavigator = 0;
            foreach (DataRow row in thisDataSet.Tables["SubjectSchedFile"].Rows)
            {
                navigatorRow = thisDataSet.Tables["SubjectSchedFile"].Rows[rowNavigator];
                if (navigatorRow.ItemArray.GetValue(11).ToString() != yearNow.ToString("yyyy"))
                {
                    thisDataSet.Tables["SubjectSchedFile"].Rows[rowNavigator][8] = "In";
                }
                rowNavigator++;
            }
            thisAdapter.Update(thisDataSet, "SubjectSchedFile");
        }
    }
}
