using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
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
        /// <summary>
        /// This is Still WIP
        /// </summary>
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
            String sql = "SELECT * FROM ENROLLMENTDETAILFILE WHERE 1=0";
            OleDbDataAdapter thisAdapter = new OleDbDataAdapter(sql,thisConnection);
            OleDbCommandBuilder thisBuilder = new OleDbCommandBuilder(thisAdapter);
            DataSet thisDataSet = new DataSet();

            Conditions conditions = new Conditions();
            string[] entryFields = {IDNumberTextbox.Text,NameTextbox.Text,CourseTextbox.Text,EDPCodeTextbox.Text,YearTextbox.Text,
                        EncoderTextbox.Text,EnrollmentDateTimePicker.Text,UnitsTextBox.Text};
            bool isNotNull;
            isNotNull = conditions.IsNotNull(entryFields);
            if (!isNotNull)
            {
                MessageBox.Show("Enter Required Fields");
                return;
            }
            if (!(SubjectEnrollmentGridView.Rows.Count > 1 && SubjectEnrollmentGridView.Rows != null))
            {
                MessageBox.Show("Datagrid is empty Please Fill");
                return;
            }
            if (isValidHeader())
            {
                MessageBox.Show("Student is Already Enrolled");
                return;
            }
            thisAdapter.Fill(thisDataSet, "EnrollmentDetailFile");
            foreach (DataGridViewRow row in SubjectEnrollmentGridView.Rows)
            {
                if (!row.IsNewRow)
                {
                    DataRow thisRow = thisDataSet.Tables["EnrollmentDetailFile"].NewRow();
                    if (!IsValidEnroll(row.Cells["EDPCode"].Value.ToString()))
                    {
                        MessageBox.Show("Student Has Already Enrolled in the Class"); /// make this return before updating
                        return;
                    }
                    thisRow["ENRDFSTUDID"] = Convert.ToInt64(IDNumberTextbox.Text);
                    thisRow["ENRDFSTUDSUBJCODE"] = row.Cells["SubjectCode"].Value.ToString();
                    thisRow["ENRDFSTUDEDPCODE"] = row.Cells["EDPCode"].Value.ToString();
                    thisRow["ENRDFSTUDSTATUS"] = "";
                    UpdateClassSize(row.Cells["EDPCode"].Value.ToString());
                    thisDataSet.Tables["EnrollmentDetailFile"].Rows.Add(thisRow);
                }
            }
            thisAdapter.Update(thisDataSet, "EnrollmentDetailFile");

            sql = "SELECT * FROM ENROLLMENTHEADERFILE WHERE 1=0";
            thisAdapter = new OleDbDataAdapter(sql, thisConnection);
            thisBuilder = new OleDbCommandBuilder(thisAdapter);
            DataSet headerDataSet = new DataSet();

            thisAdapter.Fill(headerDataSet, "EnrollmentHeaderFile");
            DataRow thisHeaderRow = headerDataSet.Tables["EnrollmentHeaderFile"].NewRow();
            thisHeaderRow["ENRHFSTUDID"] = Convert.ToInt64(IDNumberTextbox.Text);
            thisHeaderRow["ENRHFSTUDATEENROLL"] = EnrollmentDateTimePicker.Text;
            thisHeaderRow["ENRHFSTUDSCHLYR"] = YearTextbox.Text;
            thisHeaderRow["ENRHFSTUDENCODER"] = EncoderTextbox.Text;
            thisHeaderRow["ENRHFSTUDTOTALUNITS"] = Convert.ToDouble(UnitsTextBox.Text);
            thisHeaderRow["ENRHFSTUDSTATUS"] = "EN";
            headerDataSet.Tables["EnrollmentHeaderFile"].Rows.Add(thisHeaderRow);
            thisAdapter.Update(headerDataSet, "EnrollmentHeaderFile");

            MessageBox.Show("Subjects Enrolled");
        } 
        private Boolean isValidHeader()
        {
            OleDbConnection thisConnection = new OleDbConnection(DatabaseConnectionString.connectionString);
            String sql = "SELECT * FROM ENROLLMENTHEADERFILE";
            OleDbDataAdapter thisAdapter = new OleDbDataAdapter(sql, thisConnection);
            OleDbCommandBuilder thisBuilder = new OleDbCommandBuilder(thisAdapter);
            DataSet thisDataSet = new DataSet();
            thisAdapter.Fill(thisDataSet, "EnrollmentHeaderFile");
            DataRow navigatorRow;
            int rowNavigator = 0;
            foreach (DataRow row in thisDataSet.Tables["EnrollmentHeaderFile"].Rows)
            {
                navigatorRow = thisDataSet.Tables["EnrollmentHeaderFile"].Rows[rowNavigator];
                if (navigatorRow.ItemArray.GetValue(0).ToString() == IDNumberTextbox.Text)
                {
                    return true;
                }
                rowNavigator++;

            }
            return false;
        }
        private Boolean IsValidEnroll(String edpcode)
        {
            OleDbConnection thisConnection = new OleDbConnection(DatabaseConnectionString.connectionString);
            String sql = "SELECT * FROM ENROLLMENTDETAILFILE";
            OleDbDataAdapter thisAdapter = new OleDbDataAdapter(sql, thisConnection);
            OleDbCommandBuilder thisBuilder = new OleDbCommandBuilder(thisAdapter);
            DataSet thisDataSet = new DataSet();
            thisAdapter.Fill(thisDataSet, "EnrollmentDetailFile");
            DataRow navigatorRow;
            int rowNavigator = 0;
            foreach (DataRow row in thisDataSet.Tables["EnrollmentDetailFile"].Rows)
            {
                navigatorRow = thisDataSet.Tables["EnrollmentDetailFile"].Rows[rowNavigator];
                if (navigatorRow["ENRDFSTUDID"].ToString() == IDNumberTextbox.Text)
                {
                    if (navigatorRow["ENRDFSTUDEDPCODE"].ToString() == edpcode)
                    {
                        return false;
                    }
                }
                rowNavigator++;

            }
            return true;
        }
        private void UpdateClassSize(String edpCode)
        {
            OleDbConnection thisConnection = new OleDbConnection(DatabaseConnectionString.connectionString);
            String sql = "SELECT * FROM SUBJECTSCHEDFILE";
            OleDbDataAdapter thisAdapter = new OleDbDataAdapter(sql, thisConnection);
            OleDbCommandBuilder thisBuilder = new OleDbCommandBuilder(thisAdapter);
            DataSet thisDataSet = new DataSet();
            thisAdapter.Fill(thisDataSet, "SubjectSchedFile");
            DataRow navigatorRow;
            int rowNavigator = 0;
            foreach (DataRow row in thisDataSet.Tables["SubjectSchedFile"].Rows)
            {
                navigatorRow = thisDataSet.Tables["SubjectSchedFile"].Rows[rowNavigator];
                if (navigatorRow.ItemArray.GetValue(0).ToString() == edpCode.Trim())
                {
                    navigatorRow["SSFCLASSSIZE"] = Convert.ToInt32(navigatorRow["SSFCLASSSIZE"].ToString()) + 1;
                    if (Convert.ToInt32(navigatorRow["SSFCLASSSIZE"]) >= Convert.ToInt32(navigatorRow["SSFMAXSIZE"]))
                    {
                        navigatorRow["SSFSTATUS"] = "Cl";
                    }
                }
                rowNavigator++;
            }
            thisAdapter.Update(thisDataSet, "SubjectSchedFile");
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
                string[] entryFields = {IDNumberTextbox.Text};
                bool isNotNull,found = false;
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
                        found = true;
                    }
                    rowNavigator++;
                }
                if (!found)
                {
                    MessageBox.Show("ID not Found");
                }
            }
        }

        private void EDPCodeTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                OleDbConnection thisConnection = new OleDbConnection(DatabaseConnectionString.connectionString);
                String sql = "SELECT schedule.*,subject.SFSUBJUNITS From SUBJECTSCHEDFILE schedule LEFT JOIN SUBJECTFILE subject ON schedule.SSFSUBJCODE = subject.SFSUBJCODE";
                OleDbDataAdapter thisAdapter = new OleDbDataAdapter(sql, thisConnection);
                OleDbCommandBuilder thisBuilder = new OleDbCommandBuilder(thisAdapter);
                DataSet thisDataSet = new DataSet();
                thisAdapter.Fill(thisDataSet, "SubjectSchedFile");
                Conditions conditions = new Conditions();
                string[] entryFields = {IDNumberTextbox.Text,NameTextbox.Text,CourseTextbox.Text,EDPCodeTextbox.Text,YearTextbox.Text,
                        EncoderTextbox.Text,EnrollmentDateTimePicker.Text};
                bool isNotNull,isDupe,isNotActive,found = false;
                isNotNull = conditions.IsNotNull(entryFields);
                double totalUnits = Convert.ToDouble(UnitsTextBox.Text);
                if (!isNotNull)
                {
                    MessageBox.Show("Entry Field Required");
                    return;
                }
                foreach (DataRow row in thisDataSet.Tables["SubjectSchedFile"].Rows)
                {
                    if (EDPCodeTextbox.Text.Trim() == row.ItemArray.GetValue(0).ToString().Trim())
                    {
                        isDupe = CheckDupesGrid(EDPCodeTextbox.Text);
                        isNotActive = CheckStatus(row);
                        if (isDupe)
                        {
                            MessageBox.Show("Duplicate Subject Edp Code is not Allowed");
                            found = true;
                            continue;
                        }
                        if (isNotActive)
                        {
                            MessageBox.Show("Subject is Found but Not Active");
                            found = true;
                            continue;
                        }
                        SubjectEnrollmentGridView.Rows.Add(row["SSFEDPCODE"], row["SSFSUBJCODE"], row["SSFSTARTTIME"], row["SSFENDTIME"], row["SSFDAYS"], row["SSFROOM"], row["SFSUBJUNITS"]);
                        totalUnits += Convert.ToDouble(row.ItemArray.GetValue(12).ToString());
                        found = true;
                    }
                }
                if (!found)
                {
                    MessageBox.Show("EDP Code Not Found");
                }
                UnitsTextBox.Text = totalUnits.ToString();
            }
        }
        private Boolean CheckDupesGrid(string edpCode)
        {
            foreach (DataGridViewRow row in SubjectEnrollmentGridView.Rows)
            {
                DataGridViewCell cell = row.Cells["EDPCode"];
                if (cell != null && cell.Value != null)
                {
                    string edpCodeGrid = cell.Value.ToString();
                    if (edpCodeGrid.Equals(edpCode))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        private Boolean CheckStatus(DataRow row)
        {
            string status = row.ItemArray[8].ToString().ToUpper();
            return !(status == "AC"); 
        }
        
        private void ClearButton_Click(object sender, EventArgs e)
        {

        }
    }
}
