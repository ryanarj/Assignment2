using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            return File.ReadAllLines(pathToFile).Skip(1)
                .Where(line => line.Length > 1)
                .Select(Student.ParseFromFile)
                .ToList();
        }

        private void advSearchBtn_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            string fileName = @"C:\Users\KR\Documents\Visual Studio 2015\Projects\Assignment2\Assignment2\School.cvs";
            List<Student> studentCollection = ProcessStudent(fileName);
            if (this.advDepartmentTB.Text.Trim() != string.Empty || this.advCategoryTB.Text.Trim() != string.Empty)
            {
                var students = from student in studentCollection
                               where student.department == this.advDepartmentTB.Text
                               || student.race == this.advCategoryTB.Text
                               select student;
                foreach (var s in students)
                {
                    richTextBox1.AppendText(s.firstName + " " + s.lastName);
                }
                
            }
            if (this.gpaStartTB.Text.Trim() != string.Empty && this.gpaEndTB.Text.Trim() != string.Empty)
            {
                double gStart = double.Parse(this.gpaStartTB.Text);
                double gEnd = double.Parse(this.gpaEndTB.Text);

                var students = from student in studentCollection
                               where student.gpa >= gStart
                               && student.gpa <= gEnd
                               select student;
                foreach (var s in students)
                {
                    richTextBox1.AppendText(s.firstName + " " + s.lastName);
                }

            }
            if (this.learningDisabilityRB.Checked)
            {
                var students = from student in studentCollection
                               where student.learningDisability != string.Empty
                               || student.learningDisability != "N/A"
                               || student.learningDisability != "n/a"
                               select student;
                foreach (var s in students)
                {
                    richTextBox1.AppendText(s.firstName + " " + s.lastName);
                }

            }

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