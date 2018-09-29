using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Assignment2
{
    public partial class SearchStudentForm : Form
    {
        public SearchStudentForm()
        {
            InitializeComponent();
        }

        private static List<Student> ProcessStudent(string pathToFile)
        {
            // Parses the file and then adds the items to a list
            return File.ReadAllLines(pathToFile).Skip(1)
                .Where(line => line.Length > 1)
                .Select(Student.ParseFromFile)
                .ToList();
        }

        private void advSearchBtn_Click(object sender, EventArgs e)
        {
            displayStudentRTB.Clear();
            string fileName = @"C:\Users\KR\Documents\Visual Studio 2015\Projects\Assignment2\Assignment2\School.cvs";
            List<Student> studentCollection = ProcessStudent(fileName);

            // Will get a student by race or department.
            if (advDepartmentTB.Text.Trim() != string.Empty || advCategoryTB.Text.Trim() != string.Empty)
            {
                var students = from student in studentCollection
                               where student.department == advDepartmentTB.Text
                               || student.race == advCategoryTB.Text
                               || student.gender == advCategoryTB.Text
                               select student;
                foreach (var s in students)
                {
                    displayStudentRTB.AppendText(s.firstName + " " + s.lastName + Environment.NewLine);
                }
                
            }

            // Get the gpa times
            if (advGpaStartTB.Text.Trim() != string.Empty && advGpaEndTB.Text.Trim() != string.Empty)
            {
                double gStart = double.Parse(this.advGpaStartTB.Text);
                double gEnd = double.Parse(this.advGpaEndTB.Text);

                var students = from student in studentCollection
                               where student.gpa >= gStart
                               && student.gpa <= gEnd
                               select student;
                foreach (var s in students)
                {
                    displayStudentRTB.AppendText(s.firstName + " " + s.lastName + Environment.NewLine);
                }

            }

            // Add all students with learning disablilties
            if (learningDisabilityRB.Checked)
            {
                var students = from student in studentCollection
                               where student.learningDisability != string.Empty
                               && student.learningDisability != "N/A"
                               && student.learningDisability != "n/a"
                               select student;

                // Display the students
                foreach (var s in students)
                {
                    displayStudentRTB.AppendText(s.firstName + " " + s.lastName + Environment.NewLine);
                }

            }
            advDepartmentTB.Clear();
            advCategoryTB.Clear();
            advGpaEndTB.Clear();
            advGpaStartTB.Clear();
        }
    }

    class Student
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string schoolid { get; set; }
        public string homeAddress { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string race { get; set; }
        public string birthDate { get; set; }
        public string gender { get; set; }
        public string learningDisability  { get; set; }
        public double gpa { get; set; }
        public string department { get; set; }
        public string enrollmentYear { get; set; }
        public string expGraduation { get; set; }
        internal static Student ParseFromFile(string line)
        {
            var columns = line.Split(',');

            return new Student
            {
                // Parse out each column in Studdent object
                firstName = columns[0],
                lastName = columns[1],
                schoolid = columns[2],
                homeAddress = columns[3],
                email = columns[4],
                phone = columns[5],
                birthDate = columns[6],
                gender = columns[7],
                race = columns[8],
                learningDisability = columns[9],
                department = columns[10],
                enrollmentYear = columns[11],
                expGraduation = columns[12],
                gpa = double.Parse(columns[13])

            };
        }
    }
}