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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\JD\Desktop\APPSDEV FINALS\Enrollment System\Enrollment System\Database.accdb";
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void RIRequisiteTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {

                OleDbConnection thisConnection = new OleDbConnection(connectionString);
                thisConnection.Open();
                OleDbCommand thisCommand = thisConnection.CreateCommand();
                string sql = "SELECT * FROM SUBJECTFILE";
                string subjectPreqSQL = "SELECT * FROM SUBJECTPREQFILE";
                thisCommand.CommandText = sql;
                OleDbDataReader thisDataReader = thisCommand.ExecuteReader();
                OleDbDataAdapter thisAdapter = new OleDbDataAdapter(subjectPreqSQL, thisConnection);
                OleDbCommandBuilder thisBuilder = new OleDbCommandBuilder(thisAdapter);
                DataSet thisDataSet = new DataSet();
                thisAdapter.Fill(thisDataSet, "SubjectPreqFile");
                bool found = false;
                string subjectCode = "";
                string description = "";
                string units = "";
                string subjectWithPreRequisite = SISubjectCodeTextBox.Text;
                
                while (thisDataReader.Read())
                {
                    if (thisDataReader["SFSUBJCODE"].ToString().Trim().ToUpper() == RIRequisiteTextBox.Text.Trim().ToUpper())
                    {
                        found = true;
                        subjectCode = thisDataReader["SFSUBJCODE"].ToString();
                        description = thisDataReader["SFSUBJDESC"].ToString();
                        units = thisDataReader["SFSUBJUNITS"].ToString();
                        break;
                        
                    }

                }
                int index;
                if (found == false)
                    MessageBox.Show("Subject Code Not Found");
                else
                {
                    DataRow thisRow; 
                    index = SubjectDataGridView.Rows.Add();
                    SubjectDataGridView.Rows[index].Cells["SubjectCode"].Value = subjectCode;
                    SubjectDataGridView.Rows[index].Cells["Description"].Value = description;
                    SubjectDataGridView.Rows[index].Cells["Units"].Value = units;
                    if (RIPreRequisiteRadioButton.Checked)
                    {
                        thisRow = thisDataSet.Tables["SubjectPreqFile"].NewRow();
                        thisRow["SUBJCODE"] = subjectWithPreRequisite;
                        thisRow["SUBJPRECODE"] = subjectCode;
                        thisRow["SUBJCATEGORY"] = "PR";
                        thisDataSet.Tables["SubjectPreqFile"].Rows.Add(thisRow);
                        thisAdapter.Update(thisDataSet, "SubjectPreqFile");
                    }
                    else if (RICoRequisiteRadioButton.Checked)
                    {
                        thisRow = thisDataSet.Tables["SubjectPreqFile"].NewRow();
                        thisRow["SUBJCODE"] = subjectWithPreRequisite;
                        thisRow["SUBJPRECODE"] = subjectCode;
                        thisRow["SUBJCATEGORY"] = "CR";
                        thisDataSet.Tables["SubjectPreqFile"].Rows.Add(thisRow);
                        thisAdapter.Update(thisDataSet, "SubjectPreqFile");
                    }
                    else
                    {
                        MessageBox.Show("Please select a Form of requisite");
                    }
                }

            }
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            OleDbConnection thisConnection = new OleDbConnection(connectionString);
            String Ole = "Select * From SUBJECTFILE";
            OleDbDataAdapter thisAdapter = new OleDbDataAdapter(Ole, thisConnection);
            OleDbCommandBuilder thisBuilder = new OleDbCommandBuilder(thisAdapter);
            DataSet thisDataSet = new DataSet();
            thisAdapter.Fill(thisDataSet, "SubjectFile");
            DataRow thisRow = thisDataSet.Tables["SubjectFile"].NewRow();
            thisRow["SFSUBJCODE"] = SISubjectCodeTextBox.Text;
            thisRow["SFSUBJDESC"] = SIDescriptionTextBox.Text;
            thisRow["SFSUBJUNITS"] = Convert.ToInt16(SIUnitsTextBox.Text);
            thisRow["SFSUBJREGOFRNG"] = SIOfferingComboBox.Text.Substring(0, 1);
            thisRow["SFSUBJCATEGORY"] = SICategoryComboBox.Text.Substring(0, 3);
            thisRow["SFSUBJSTATUS"] = "AC";
            thisRow["SFSUBJCOURSECODE"] = SICourseCodeComboBox.Text;
            thisRow["SFSUBJCURRCODE"] = SICurriculumYearTextBox.Text;

            thisDataSet.Tables["SubjectFile"].Rows.Add(thisRow);
            thisAdapter.Update(thisDataSet, "SubjectFile");

            MessageBox.Show("Recorded");
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            SISubjectCodeTextBox.Text = "";
            SIDescriptionTextBox.Text = "";
            SIUnitsTextBox.Text = "";
            SIOfferingComboBox.Text = "";
            SICategoryComboBox.Text = "";
            SICourseCodeComboBox.Text = "";
            SICurriculumYearTextBox.Text = "";
            RICoRequisiteRadioButton.Checked = false;
            RIPreRequisiteRadioButton.Checked = false;
            RIRequisiteTextBox.Text = "";
            SubjectDataGridView.Rows.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            Hide();
            mainMenu.ShowDialog();
            Close();
        }


        private void RIRequisiteTextBox_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < SubjectDataGridView.Rows.Count; i++)
            {
                DataGridViewRow row = SubjectDataGridView.Rows[i];
                if (row.Cells[0].Value != null)
                {
                    string subjectCode = SubjectCodeTextBox.Text;
                    string preCode = row.Cells[0].Value.ToString();
                    DataRow[] existingRows = preqDataSet.Tables["SubjectPreqFile"].Select($"SUBJCODE = '{subjectCode}' AND SUBJPRECODE = '{preCode}'");
                    if (existingRows.Length == 0)
                    {
                        DataRow preqRow = preqDataSet.Tables["SubjectPreqFile"].NewRow();
                        preqRow["SUBJCODE"] = subjectCode;
                        preqRow["SUBJPRECODE"] = preCode;

                        preqDataSet.Tables["SubjectPreqFile"].Rows.Add(preqRow);
                    }
                }
            }
        }

    }
}
