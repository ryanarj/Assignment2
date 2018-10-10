using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace Assignment2
{

    public partial class AddStudentEducationForm : Form
    {
        Dictionary<string, string> formDict = new Dictionary<string, string>();
        public AddStudentEducationForm(Dictionary<string, string> form1Dict){
            // Get the dictionary from the other form
            formDict = form1Dict;
            InitializeComponent();
        }

        private void submitBtn_Click(object sender, EventArgs e){
            // Add the dictionary values from the text box information
            string fileName = @"C:\Users\KR\Documents\Visual Studio 2015\Projects\Assignment2\Assignment2\Students.xml";
            string str = "";

            enrollementYearCB.Items.Add(new { Text = "", Value = "" });
            enrollementYearCB.Items.Add(new { Text = "2012", Value = "2012" });
            enrollementYearCB.Items.Add(new { Text = "2013", Value = "2013" });
            enrollementYearCB.Items.Add(new { Text = "2014", Value = "2014" });
            enrollementYearCB.Items.Add(new { Text = "2015", Value = "2015" });
            enrollementYearCB.Items.Add(new { Text = "2016", Value = "2016" });


            expectedGradCB.Items.Add(new { Text = "", Value = "" });
            expectedGradCB.Items.Add(new { Text = "2016", Value = "2016" });
            expectedGradCB.Items.Add(new { Text = "2017", Value = "2017" });
            expectedGradCB.Items.Add(new { Text = "2018", Value = "2018" });
            expectedGradCB.Items.Add(new { Text = "2019", Value = "2019" });
            expectedGradCB.Items.Add(new { Text = "2020", Value = "2020" });

            if (departmentTB.Text != "" && System.Text.RegularExpressions.Regex.IsMatch(departmentTB.Text, "^[a-zA-Z]+$")
                && gpaTB.Text != "" && System.Text.RegularExpressions.Regex.IsMatch(gpaTB.Text, "^[a-zA-Z]+$")
                && enrollementYearCB.Text != "")
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
                expGraduation.InnerText = expectedGradCB.Text;
                XmlNode gpa = doc.CreateElement("gpa");
                gpa.InnerText = gpaTB.Text;
                student.AppendChild(firstName); student.AppendChild(lastName); student.AppendChild(schoolId); student.AppendChild(homeAddress);
                student.AppendChild(email); student.AppendChild(phone); student.AppendChild(birthDate); student.AppendChild(gender);
                student.AppendChild(race); student.AppendChild(learningDisability); student.AppendChild(department); student.AppendChild(enrollmentYear);
                student.AppendChild(expGraduation); student.AppendChild(gpa);
                doc.DocumentElement.AppendChild(student);
                doc.Save(fileName);

                /* Format the string to have commas
                foreach (string s in formDict.Values)
                {
                    str += s + ",";
                }
                str += "\n";

                // Keep the header values
                if (!File.Exists(fileName))
                {
                    string header = "firstName,lastName,schoolId,homeAddress,email,phone,birthDate,gender,race,learningDisability,department,enrollmentYear,expGraduation,gpa" + Environment.NewLine;
                    File.WriteAllText(fileName, header);
                }

                // Append the new string 
                File.AppendAllText(fileName, str);

                // Clear out the data
                gpaTB.Clear();
                departmentTB.Clear();
                this.Close();
                */

            }
            else
            {
                MessageBox.Show("All textboxes need to have a value and/or all values need to be the correct data type!!");
            }

        }
    }
}
