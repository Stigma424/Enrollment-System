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
using System.Windows.Forms.VisualStyles;
using static System.Runtime.CompilerServices.RuntimeHelpers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Enrollment_System
{
    public partial class SubjectEntryForm : Form
    {
        public SubjectEntryForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        //TODO LIMPYOHI NYA HIMO LAIN FORM GURO PARA SA PAG SAVE OG PRE REQUISITE OG CO REQUISITE
        // ANG PURPOSE UNTA ANI KAY PANG FIND RA KUNG NAA REQUISITE ANG USA KA SUB OR WA
        private void RIRequisiteTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                string subjectPreqCode, description,units, subjectCode, coPre;
                string sql = "SELECT * FROM SUBJECTFILE";
                OleDbConnection thisConnection = new OleDbConnection(DatabaseConnectionString.connectionString);
                thisConnection.Open();
                OleDbCommand thisCommand = thisConnection.CreateCommand();
                string subjectPreqSQL = "SELECT * FROM SUBJECTPREQFILE";
                thisCommand.CommandText = sql;
                OleDbDataReader thisDataReader = thisCommand.ExecuteReader();
                OleDbDataAdapter thisAdapter = new OleDbDataAdapter(subjectPreqSQL, thisConnection);
                OleDbCommandBuilder thisBuilder = new OleDbCommandBuilder(thisAdapter);
                DataSet thisDataSet = new DataSet();
                thisAdapter.Fill(thisDataSet, "SubjectPreqFile");
                bool found = false;
                subjectPreqCode = "";
                description = "";
                units = "";
                subjectCode = SISubjectCodeTextBox.Text;
                coPre = "";
                while (thisDataReader.Read())
                {
                    if (thisDataReader["SFSUBJCODE"].ToString().Trim().ToUpper() == RIRequisiteTextBox.Text.Trim().ToUpper())
                    {
                        found = true;
                        subjectPreqCode = thisDataReader["SFSUBJCODE"].ToString();
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
                    SubjectDataGridView.Rows[index].Cells["SubjectCode"].Value = subjectPreqCode;
                    SubjectDataGridView.Rows[index].Cells["Description"].Value = description;
                    SubjectDataGridView.Rows[index].Cells["Units"].Value = units;
                    if (RIPreRequisiteRadioButton.Checked)
                    {
                        thisRow = thisDataSet.Tables["SubjectPreqFile"].NewRow();
                        thisRow["SUBJCODE"] = subjectCode;
                        thisRow["SUBJPRECODE"] = subjectPreqCode;
                        coPre = "PR";
                        thisRow["SUBJCATEGORY"] = coPre;
                        thisDataSet.Tables["SubjectPreqFile"].Rows.Add(thisRow);
                        thisAdapter.Update(thisDataSet, "SubjectPreqFile");
                    }
                    else if (RICoRequisiteRadioButton.Checked)
                    {
                        thisRow = thisDataSet.Tables["SubjectPreqFile"].NewRow();
                        thisRow["SUBJCODE"] = subjectCode;
                        thisRow["SUBJPRECODE"] = subjectPreqCode;
                        coPre = "CR";
                        thisRow["SUBJCATEGORY"] = coPre;
                        thisDataSet.Tables["SubjectPreqFile"].Rows.Add(thisRow);
                        thisAdapter.Update(thisDataSet, "SubjectPreqFile");
                    }
                    else
                    {
                        MessageBox.Show("Please select a Form of requisite");
                    }
                    SubjectDataGridView.Rows[index].Cells["Requisite"].Value = coPre;
                }

            }
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            OleDbConnection thisConnection = new OleDbConnection(DatabaseConnectionString.connectionString);
            String Ole = "Select * From SUBJECTFILE";
            OleDbDataAdapter thisAdapter = new OleDbDataAdapter(Ole, thisConnection);
            OleDbCommandBuilder thisBuilder = new OleDbCommandBuilder(thisAdapter);
            DataSet thisDataSet = new DataSet();
            thisAdapter.Fill(thisDataSet, "SubjectFile");
            DataRow thisRow = thisDataSet.Tables["SubjectFile"].NewRow();
            Conditions condition = new Conditions();
            String[] textBoxes = { SISubjectCodeTextBox.Text, SIDescriptionTextBox.Text, SIUnitsTextBox.Text,
                                   SIOfferingComboBox.Text, SIOfferingComboBox.Text, SICourseCodeComboBox.Text,
                                   SICurriculumYearTextBox.Text };
            Boolean isNotNull = condition.IsNull(textBoxes), isValid, isUnitsInt;
            if (isNotNull)
            {
                isValid = condition.IsValid("SubjectFile", thisDataSet, SISubjectCodeTextBox.Text, SICourseCodeComboBox.Text, 0, 6);
                if (isValid)
                {
                    isUnitsInt = condition.isInteger(SIUnitsTextBox.Text);
                    if (isUnitsInt)
                    {
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
                    else
                    {
                        MessageBox.Show("Units must be in Numbers");
                    }
                }
                else
                {
                    MessageBox.Show("");
                }
            }
            else
            {
                MessageBox.Show("Field Entry Required");
            }
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

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        private void RIRequisiteTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SISubjectCodeTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        
    }
}
