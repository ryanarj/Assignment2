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
     
                    if (nodes[i]["department"].InnerXml.Trim().Equals(advDepartmentTB.Text.Trim()) || nodes[i]["gender"].InnerXml.Trim().Equals(advCategoryTB.Text.Trim()) || nodes[i]["race"].InnerXml.Trim().Equals(advCategoryTB.Text.Trim()))
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
                    if (currGpa >= gStart && currGpa <=gEnd)
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
                    if (!nodes[i]["learningDisability"].InnerXml.Trim().Equals("N/A"))
                    {
                        displayStudentRTB.AppendText(nodes[i]["firstName"].InnerXml + " " + nodes[i]["lastName"].InnerXml + " has this type of learning disability " + nodes[i]["learningDisability"].InnerXml + Environment.NewLine);
                    }

                }

            }

            // Search by id name
            if (advIDTB.Text.Trim() != string.Empty)
            {
                for (int i = 0; i < nodes.Count; i++)
                {
                    if (nodes[i]["schoolId"].InnerXml.Trim().Equals(advIDTB.Text))
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

            // Search by student name
            if (advNameTB.Text.Trim() != string.Empty)
            {
                string[] split = advNameTB.Text.Split(' ');
                for (int i = 0; i < nodes.Count; i++)
                {
                    if (nodes[i]["firstName"].InnerXml.Trim().Equals(split[0]) && nodes[i]["lastName"].InnerXml.Trim().Equals(split[1]))
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

            if (displayStudentRTB.Text.Trim().Equals(""))
            {
                MessageBox.Show("Enter the correct values/Student(s) by these values are not present.");
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

}