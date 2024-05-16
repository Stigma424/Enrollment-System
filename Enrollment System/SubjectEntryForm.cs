using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
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
        //TODO TBD = MAYBE HAVE ANOTHER SAVE AND LIST FOR SUBJECTS AND SUBJECTS WITH REQ
        //COMPLETION SAVING = 100% CONDITIONS = FINISHED? UI = TRASH
        private void RIRequisiteTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                string subjectPreqCode, description,units, subjectCode, coPre;
                string[] entryTextBoxes = {RIRequisiteTextBox.Text,SISubjectCodeTextBox.Text};
                OleDbConnection thisConnection = new OleDbConnection(DatabaseConnectionString.connectionString);
                string sql = "SELECT * FROM SUBJECTFILE";
                OleDbDataAdapter thisAdapter = new OleDbDataAdapter(sql, thisConnection);
                OleDbCommandBuilder thisBuilder = new OleDbCommandBuilder(thisAdapter);
                DataSet thisDataSet = new DataSet();
                thisAdapter.Fill(thisDataSet, "SubjectFile");

                Conditions conditions = new Conditions();
                bool found,isNotNull,isSubCodeFound,isRadioButtonNotNull,isNotDuplicate;
                subjectPreqCode = ""; description = ""; units = ""; subjectCode = SISubjectCodeTextBox.Text; coPre = ""; coPre ="";

                int index;
                isNotNull = conditions.IsNotNull(entryTextBoxes);
                isRadioButtonNotNull = GetPreCoRequisite(out coPre);
                
                if (isNotNull && isRadioButtonNotNull)
                {
                    if (SamePreqSubjectCode())
                    {
                        return;
                    }
                    isSubCodeFound = conditions.IsValid("SubjectFIle", thisDataSet, SISubjectCodeTextBox.Text, 0);
                    if (!isSubCodeFound)
                    {
                        found = GetSubjectPreqCode(thisDataSet, out subjectPreqCode, out description, out units);
                        if (found)
                        {
                            string subjectPreqSQL = "SELECT * FROM SUBJECTPREQFILE";
                            thisAdapter = new OleDbDataAdapter(subjectPreqSQL, thisConnection);
                            thisBuilder = new OleDbCommandBuilder(thisAdapter);
                            thisDataSet.Clear();
                            thisAdapter.Fill(thisDataSet, "SubjectPreqFile");
                            isNotDuplicate = conditions.IsValid("SubjectPreqFile", thisDataSet, SISubjectCodeTextBox.Text, subjectPreqCode, 0, 1);
                            if (isNotDuplicate)
                            {
                                DataRow thisRow;
                                index = SubjectDataGridView.Rows.Add();
                                SubjectDataGridView.Rows[index].Cells["SubjectCode"].Value = subjectPreqCode;
                                SubjectDataGridView.Rows[index].Cells["Description"].Value = description;
                                SubjectDataGridView.Rows[index].Cells["Units"].Value = units;

                                thisRow = thisDataSet.Tables["SubjectPreqFile"].NewRow();
                                thisRow["SUBJCODE"] = subjectCode;
                                thisRow["SUBJPRECODE"] = subjectPreqCode;
                                thisRow["SUBJCATEGORY"] = coPre;
                                thisDataSet.Tables["SubjectPreqFile"].Rows.Add(thisRow);
                                thisAdapter.Update(thisDataSet, "SubjectPreqFile");
                                MessageBox.Show("Requisite Entry Recorded");
                            }
                            else
                            {
                                MessageBox.Show("Entered Information Is Already Existing");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Subject Code Not Found In Requisite Information Please save First");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Subject Code Not found In Subject Information Please save First");
                    }
                }
                else
                {
                    MessageBox.Show("Enter Required Fields: Both Subject Code & One of the Requisite choices");
                }
            }
        }
        private Boolean SamePreqSubjectCode()
        {
            if(RIRequisiteTextBox.Text == SISubjectCodeTextBox.Text)
            {
                return true;
            }
            return false;
        }
        private Boolean GetPreCoRequisite(out string coPre)
        {
            if (RIPreRequisiteRadioButton.Checked)
            {
                coPre = "PR";
                return true;
            }
            else if (RICoRequisiteRadioButton.Checked)
            {
                coPre =  "Co";
                return true;
            }
            else 
            {
                coPre = "";
                return false;
            }
        }
        private Boolean GetSubjectPreqCode(DataSet thisDataSet,out string subjectPreqCode,out string description, out string units)
        {
            subjectPreqCode = ""; description = ""; units = "";
            DataRow navigatorRow;
            int rowNavigator = 0;
            foreach (DataRow row in thisDataSet.Tables["SubjectFile"].Rows)
            {
                navigatorRow = thisDataSet.Tables["SubjectFile"].Rows[rowNavigator];
                if (navigatorRow.ItemArray.GetValue(0).ToString() == RIRequisiteTextBox.Text.Trim().ToUpper())
                {
                    subjectPreqCode = row.ItemArray[0].ToString();
                    description = row.ItemArray[1].ToString();
                    units = row.ItemArray[2].ToString();
                    return true;
                }
                rowNavigator++;
            }
            return false;
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
            Boolean isNotNull = condition.IsNotNull(textBoxes), isValid, isUnitsInt;
            if (isNotNull)
            {
                isValid = condition.IsValid("SubjectFile", thisDataSet, SISubjectCodeTextBox.Text, SICourseCodeComboBox.Text, 0, 6);
                if (isValid)
                {
                    isUnitsInt = condition.isInteger(SIUnitsTextBox.Text);
                    if (isUnitsInt)
                    {
                        thisRow["SFSUBJCODE"] = SISubjectCodeTextBox.Text.ToUpper();
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
                        ClearAll();
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
        private void ClearAll()
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
        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearAll();
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
