// StudentTrackerForm.cs
// COMP212 Assignment2
// Author - Brahmadut Ramkissoon 300500046 
using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace BrahmLab2
{
    public partial class StudentTrackerForm : Form
    {
        public StudentTrackerForm()
        {
            InitializeComponent();
            _sampleList();
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

        // Sample list of students
        private void _sampleList()
        {
            StudentList.Add(300500046, "Brahm Ramkissoon");
            StudentList.Add(000, "John Smith");
            StudentList.Add(007, "James Bond");


        }

        private void addStudentIDAndNameButton_Click(object sender, EventArgs e)
        {
            // Check if StudentId and StudentName textboxes are filled
            bool isStudentIDEmpty = string.IsNullOrWhiteSpace(inputStudentIDTextBox.Text);
            bool isStudentNameEmpty = string.IsNullOrWhiteSpace(inputStudentNameTextBox.Text);
            if (!isStudentIDEmpty && !isStudentNameEmpty)
            {
                // Check that Student ID is a number
                try
                {
                    int validStudentID;
                    Int32.TryParse(inputStudentIDTextBox.Text, out validStudentID);

                    StudentName = inputStudentNameTextBox.Text;
                    // Add student record 
                    StudentList.Add(validStudentID, StudentName);
                    MessageBox.Show("Student Record added sucessfully");

                }
                catch (Exception)
                {
                    inputStudentIDTextBox.Clear();
                    MessageBox.Show("Please enter Student ID as a number");
                }
            }
            else
            {
                MessageBox.Show("Please enter Student ID and number.");
            }

        }

        // Delete a record using Student ID
        private void deleteRecordButton_Click(object sender, EventArgs e)
        {
            // Check if StudentId is filled
            bool isStudentIDEmpty = string.IsNullOrWhiteSpace(inputStudentIDTextBox.Text);
            if (!isStudentIDEmpty)
            {
                string studentRecord; // value connected to key
                try
                {
                    int.Parse(inputStudentIDTextBox.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Please enter Student ID as a number");
                }

                StudentId = inputStudentIDTextBox.Text;
                if (StudentList.ContainsKey(Convert.ToInt32(StudentId)))
                {
                    StudentList.TryGetValue(Convert.ToInt32(StudentId), out studentRecord);
                    // Confirm removal of record

                    DialogResult confirmRemove =
                        MessageBox.Show($"Are you sure you want remove this record? \n " +
                                        $"[{StudentId}, {studentRecord}]",
                                        "Confirm Record Removal", MessageBoxButtons.YesNo);

                    if (confirmRemove == DialogResult.Yes)
                    {
                        StudentList.Remove(Convert.ToInt32(StudentId));
                    }
                }
                else
                {
                    MessageBox.Show("Student record not found");
                }
            }
            else
            {
                MessageBox.Show("Please enter a Student ID");
            }

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

        // Search for a record using Student ID
        private void searchWithStudentIDButton_Click(object sender, EventArgs e)
        {
            // Check if StudentId is filled
            bool isStudentIDEmpty = string.IsNullOrWhiteSpace(inputStudentIDTextBox.Text);
            if (!isStudentIDEmpty)
            {
                string studentRecord; // value connected to key
                try
                {
                    int.Parse(inputStudentIDTextBox.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Please enter Student ID as a number");
                }

                StudentId = inputStudentIDTextBox.Text;
                if (StudentList.TryGetValue(Convert.ToInt32(StudentId), out studentRecord))
                {
                    MessageBox.Show(studentRecord);
                }
                else
                {
                    MessageBox.Show("Student record not found");
                }
            }
            else
            {
                MessageBox.Show("Please enter a Student ID");
            }

        }

        // Clear the input fields
        private void clearDisplayScreenButton_Click(object sender, EventArgs e)
        {
            inputStudentIDTextBox.Clear();
            inputStudentNameTextBox.Clear();
        }

        // Display all records
        private void displayAllButton_Click(object sender, EventArgs e)
        {
            string allRecords = "";
            int numOfRecord = 0;
            foreach (KeyValuePair<int, string> record in StudentList)
            {
                numOfRecord++;
                allRecords += $"{numOfRecord}: {record}\n";     // format string output of student list
            }
            MessageBox.Show(allRecords);
        }

        // Close the Application
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
