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

        private Dictionary<int, string> _studentList = new Dictionary<int, string>();
        private int studentID;
        private string studentName;

        // Properties
        public int StudentId
        {
            get { return studentID; }
            set { studentID = value; }
        }

        public string StudentName
        {
            get { return studentName; }
            set { studentName = value; }
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
           StudentId = Convert.ToInt32(inputStudentIDTextBox.Text);
           StudentName = inputStudentNameTextBox.Text;
    
           StudentList.Add(StudentId, StudentName);
       }

        private void deleteRecordButton_Click(object sender, EventArgs e)
        {

        }

        private void deleteAllRecordsButton_Click(object sender, EventArgs e)
        {

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

        }

        private void displayAllButton_Click(object sender, EventArgs e)
        {

        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            DialogResult confirmExit = 
                MessageBox.Show("Are you sure you want to exit?","Confirm Close Application", MessageBoxButtons.YesNo);

            if (confirmExit == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }
    }
}
