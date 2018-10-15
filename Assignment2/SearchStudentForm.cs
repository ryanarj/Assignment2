using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;

namespace Assignment2
{
    public partial class SearchStudentForm : Form
    {
        DirectoryInfo pFolder;
        public SearchStudentForm(DirectoryInfo parentFolder)
        {
            pFolder = parentFolder;
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
            string path = pFolder.FullName;
            string fileName = path.Substring(0, path.Length - 3) + "Students.xml";
            XmlDocument xdoc = new XmlDocument();
            xdoc.Load(fileName);
            XmlNodeList nodes = xdoc.GetElementsByTagName("Student");

            // Will get a student by race or department.
            if (advDepartmentTB.Text.Trim() != string.Empty || advCategoryTB.Text.Trim() != string.Empty)
            {

                for (int i = 0; i < nodes.Count; i++){
     
                    if (nodes[i]["department"].InnerXml == advDepartmentTB.Text || nodes[i]["gender"].InnerXml == advCategoryTB.Text || nodes[i]["race"].InnerXml == advCategoryTB.Text)
                    {
                        displayStudentRTB.AppendText(nodes[i]["firstName"].InnerXml + " " + nodes[i]["lastName"].InnerXml + Environment.NewLine);
                    }
                }
                
            }

            // Get the gpa times
            if (advGpaStartTB.Text.Trim() != string.Empty && advGpaEndTB.Text.Trim() != string.Empty)
            {
                double gStart = double.Parse(this.advGpaStartTB.Text);
                double gEnd = double.Parse(this.advGpaEndTB.Text);

                for (int i = 0; i < nodes.Count; i++)
                {
                    double currGpa = double.Parse(nodes[i]["gpa"].InnerXml);
                    if (gStart >= currGpa && gEnd <=currGpa)
                    {
                        displayStudentRTB.AppendText(nodes[i]["firstName"].InnerXml + " " + nodes[i]["lastName"].InnerXml + Environment.NewLine);
                    }
                }

            }

            // Add all students with learning disablilties
            if (learningDisabilityRB.Checked)
            {
                for (int i = 0; i < nodes.Count; i++)
                {
                    if (nodes[i]["learningDisability"].InnerXml != "N/A" || nodes[i]["learningDisability"].InnerXml != "n/a")
                    {
                        displayStudentRTB.AppendText(nodes[i]["firstName"] + " " + nodes[i]["lastName"] + Environment.NewLine);
                    }

                }

            }

            // Search by id name
            if (advIDTB.Text.Trim() != string.Empty)
            {
                for (int i = 0; i < nodes.Count; i++)
                {
                    if (nodes[i]["schoolId"].InnerXml == advIDTB.Text)
                    {
                        displayStudentRTB.AppendText("-First name: " + nodes[i]["firstName"].InnerXml + Environment.NewLine + "-Last name: " + nodes[i]["lastName"].InnerXml + Environment.NewLine + "-School ID: " + nodes[i]["schoolId"].InnerXml + Environment.NewLine +
                                                     "-Email: " + nodes[i]["email"].InnerXml + Environment.NewLine + "-Phone: " + nodes[i]["phone"].InnerXml + Environment.NewLine + "-Home address: " + nodes[i]["homeAdress"].InnerXml + Environment.NewLine +
                                                     "-Gender: " + nodes[i]["gender"].InnerXml + Environment.NewLine + "-Race: " + nodes[i]["race"].InnerXml + Environment.NewLine + "-Birthdate: " + nodes[i]["birthDate"].InnerXml + Environment.NewLine +
                                                     "-Learning Disability: " + nodes[i]["learningDisability"].InnerXml + Environment.NewLine + "-GPA: " + nodes[i]["gpa"].InnerXml + Environment.NewLine + "-Enrollment Year: " + nodes[i]["enrollmentYear"].InnerXml + Environment.NewLine +
                                                     "-Department: " + nodes[i]["department"].InnerXml + Environment.NewLine + "-Expected Graduation: " + nodes[i]["schoolId"].InnerXml + Environment.NewLine);
                    }

                }

            }

            // Search by student name
            if (advNameTB.Text.Trim() != string.Empty)
            {
                string[] split = advNameTB.Text.Split(' ');
                for (int i = 0; i < nodes.Count; i++)
                {
                    if (nodes[i]["firstName"].InnerXml == split[0] && nodes[i]["lastName"].InnerXml == split[1])
                    {
                        displayStudentRTB.AppendText("-First name: " + nodes[i]["firstName"].InnerXml + Environment.NewLine + 
                                                     "-Last name: " + nodes[i]["lastName"].InnerXml + Environment.NewLine + 
                                                     "-School ID: " + nodes[i]["schoolId"].InnerXml + Environment.NewLine +
                                                     "-Email: " + nodes[i]["email"].InnerXml + Environment.NewLine + 
                                                     "-Phone: " + nodes[i]["phone"].InnerXml + Environment.NewLine + 
                                                     "-Home address: " + nodes[i]["homeAddress"].InnerXml + Environment.NewLine +
                                                     "-Gender: " + nodes[i]["gender"].InnerXml + Environment.NewLine + 
                                                     "-Race: " + nodes[i]["race"].InnerXml + Environment.NewLine + 
                                                     "-Birthdate: " + nodes[i]["birthDate"].InnerXml + Environment.NewLine +
                                                     "-Learning Disability: " + nodes[i]["learningDisability"].InnerXml + Environment.NewLine + 
                                                     "-GPA: " + nodes[i]["gpa"].InnerXml + Environment.NewLine + 
                                                     "-Enrollment Year: " + nodes[i]["enrollmentYear"].InnerXml + Environment.NewLine +
                                                     "-Department: " + nodes[i]["department"].InnerXml + Environment.NewLine + 
                                                     "-Expected Graduation: " + nodes[i]["expGraduation"].InnerXml + Environment.NewLine);
                    }

                }

            }

            advIDTB.Clear();
            advNameTB.Clear();
            advDepartmentTB.Clear();
            advCategoryTB.Clear();
            advGpaEndTB.Clear();
            advGpaStartTB.Clear();
            learningDisabilityRB.Checked = false;
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