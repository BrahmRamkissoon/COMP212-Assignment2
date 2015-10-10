using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BrahmLab2
{
    public partial class StudentTrackerForm : Form
    {
       public StudentTrackerForm()
        {
            InitializeComponent();
            //_sampleList();
        }

        // Private instance variables
        private Dictionary<int, string> _studentList = new Dictionary<int, string>();
        private string _studentId;
        private string _studentName;

        // Properties
        public string StudentId
        {
            get { return _studentId; }
            set { _studentId = value; }
        }

        public string StudentName
        {
            get { return _studentName; }
            set { _studentName = value; }
        }

        public Dictionary<int, string> StudentList
        {
            get { return _studentList; }
            set { _studentList = value; }
        }


        /*
        private void _sampleList()
        {
            Student brahm = new Student(300500046, "Brahm");
            Student john= new Student(300500046, "John");
            Student david = new Student(300500046, "David");

            _studentList.Add(brahm._number, brahm._name);
            _studentList.Add(john._number, john._name);
            _studentList.Add(david._number, david._name);

        }*/

        private void addStudentIDAndNameButton_Click(object sender, EventArgs e)
       {
            // Check if StudentId and StudentName textboxes are filled
            if (inputStudentIDTextBox.Text != null && inputStudentNameTextBox.Text != null)
            {
                // Check that Student ID is a number
                try
                {
                    int.Parse(inputStudentIDTextBox.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Please enter Student ID as a number");
                }
                StudentId = inputStudentIDTextBox.Text;
                StudentName = inputStudentNameTextBox.Text;

                // Add student record 
                StudentList.Add(Convert.ToInt32(StudentId), StudentName);
            }

       }

        private void deleteRecordButton_Click(object sender, EventArgs e)
        {

        }

        private void deleteAllRecordsButton_Click(object sender, EventArgs e)
        {
            DialogResult confirmDeleteRecords =
                MessageBox.Show("Are you sure you want to delete all records?",
                                "Confirm Delete All Records", MessageBoxButtons.YesNo);

            if (confirmDeleteRecords == DialogResult.Yes)
            {
                StudentList.Clear();
            }
            
        }

        private void searchWithStudentIDButton_Click(object sender, EventArgs e)
        {
            string foundStudentName;
            StudentId = Convert.ToInt32(inputStudentIDTextBox.Text);
            if (StudentList.TryGetValue(StudentId, out foundStudentName))
            {
                MessageBox.Show(foundStudentName);
            }
            else
            {
                MessageBox.Show("Student not found");

            }

        }

        private void clearDisplayScreenButton_Click(object sender, EventArgs e)
        {
            inputStudentIDTextBox.Clear();
            inputStudentNameTextBox.Clear();
        }

        private void displayAllButton_Click(object sender, EventArgs e)
        {

        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            // Confirm application exit
            
            DialogResult confirmExit = 
                MessageBox.Show("Are you sure you want to exit?",   
                                "Confirm Close Application", MessageBoxButtons.YesNo);

            if (confirmExit == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }
    }
}
