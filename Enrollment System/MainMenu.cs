using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enrollment_System
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            DatabaseConnectionString constructConnection = new DatabaseConnectionString();
            UpdateScript runScript = new UpdateScript();
        }

        private void SubjectEntryFormButton_Click(object sender, EventArgs e)
        {
            SubjectEntryForm studentEntryForm = new SubjectEntryForm();
            Hide();
            studentEntryForm.ShowDialog();
            Close();
        }

        private void StudentEntryButton_Click(object sender, EventArgs e)
        {
            StudentEntryForm studentForm = new StudentEntryForm();
            Hide();
            studentForm.ShowDialog();
            Close();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            SubjectScheduleEntryForm subjectSchedForm = new SubjectScheduleEntryForm();
            Hide();
            subjectSchedForm.ShowDialog();
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StudentEnrollmentEntryForm studentEnrollmentForm = new StudentEnrollmentEntryForm();
            Hide();
            studentEnrollmentForm.ShowDialog();
            Close();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            StudentGradeEntryForm studentGradeEntryForm = new StudentGradeEntryForm();
            Hide();
            studentGradeEntryForm.ShowDialog();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateScript runScript = new UpdateScript();
            String fileName = "Database.accdb";
            String MainPath = AppDomain.CurrentDomain.BaseDirectory;
            String word = MainPath.Replace("\\bin\\Debug","");
            MessageBox.Show(word + fileName);
        }
    }
}
