using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;

namespace Assignment2
{

    public partial class AddStudentEducationForm : Form
    {
        Dictionary<string, string> formDict = new Dictionary<string, string>();
        DirectoryInfo pFolder;
        public AddStudentEducationForm(Dictionary<string, string> form1Dict, DirectoryInfo parentFolder)
        {
            // Get the dictionary from the other form
            formDict = form1Dict;
            pFolder = parentFolder;
            InitializeComponent();
        }

        private void submitBtn_Click(object sender, EventArgs e){

            var boxes = Controls.OfType<System.Windows.Forms.TextBox>();
            foreach (var box in boxes)
            {
                if (string.IsNullOrWhiteSpace(box.Text))
                {
                    errorProvider1.SetError(box, "Please fill the required field");
                }
                else
                {
                    errorProvider1.Clear();
                }
            }



            // Add the dictionary values from the text box information
            string path = pFolder.FullName;
            string fileName = path.Substring(0, path.Length - 3) + "Students.xml";

            if (departmentTB.Text != "" && System.Text.RegularExpressions.Regex.IsMatch(departmentTB.Text, "^[a-zA-Z]+$")
                && gpaTB.Text != "" && System.Text.RegularExpressions.Regex.IsMatch(gpaTB.Text, "[0-9]")
                && enrollementYearCB.Text != "" && expectedGradDP.Text != "")
            {

                XmlDocument doc = new XmlDocument();
                doc.Load(fileName);
                XmlNode student = doc.CreateElement("Student");
                XmlNode firstName = doc.CreateElement("firstName");
                firstName.InnerText = formDict["firstName"];
                XmlNode lastName = doc.CreateElement("lastName");
                lastName.InnerText = formDict["lastName"];
                XmlNode schoolId = doc.CreateElement("schoolId");
                schoolId.InnerText = formDict["schoolId"];
                XmlNode homeAddress = doc.CreateElement("homeAddress");
                homeAddress.InnerText = formDict["homeAddress"];
                XmlNode email = doc.CreateElement("email");
                email.InnerText = formDict["email"];
                XmlNode phone = doc.CreateElement("phone");
                phone.InnerText = formDict["phone"];
                XmlNode birthDate = doc.CreateElement("birthDate");
                birthDate.InnerText = formDict["birthDate"];
                XmlNode gender = doc.CreateElement("gender");
                gender.InnerText = formDict["gender"];
                XmlNode race = doc.CreateElement("race");
                race.InnerText = formDict["race"];
                XmlNode learningDisability = doc.CreateElement("learningDisability");
                learningDisability.InnerText = formDict["learningDisability"];
                XmlNode department = doc.CreateElement("department");
                department.InnerText = departmentTB.Text;
                XmlNode enrollmentYear = doc.CreateElement("enrollmentYear");
                enrollmentYear.InnerText = enrollementYearCB.Text;
                XmlNode expGraduation = doc.CreateElement("expGraduation");
                expGraduation.InnerText = expectedGradDP.Text;
                XmlNode gpa = doc.CreateElement("gpa");
                gpa.InnerText = gpaTB.Text;
                student.AppendChild(firstName); student.AppendChild(lastName); student.AppendChild(schoolId); student.AppendChild(homeAddress);
                student.AppendChild(email); student.AppendChild(phone); student.AppendChild(birthDate); student.AppendChild(gender);
                student.AppendChild(race); student.AppendChild(learningDisability); student.AppendChild(department); student.AppendChild(enrollmentYear);
                student.AppendChild(expGraduation); student.AppendChild(gpa);
                doc.DocumentElement.AppendChild(student);
                doc.Save(fileName);
                MessageBox.Show("New Student has been added!!");
                this.Close();

            }
            else
            {
                MessageBox.Show("All textboxes need to have a value and/or all values need to be the correct data type!!");
            }

        }

    }
}
