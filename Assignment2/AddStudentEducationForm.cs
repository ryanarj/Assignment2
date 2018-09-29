using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            string fileName = @"C:\Users\KR\Documents\Visual Studio 2015\Projects\Assignment2\Assignment2\School.cvs";
            string str = "";
            formDict["department"] = departmentTB.Text;
            formDict["enrollmentYear"] = enrollmentYearTB.Text;
            formDict["expGraduation"] = expectedGraduationrTB.Text;
            formDict["gpa"] = gpaTB.Text;

            // Format the string to have commas
            foreach(string s in formDict.Values)
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
            enrollmentYearTB.Clear();
            expectedGraduationrTB.Clear();
            departmentTB.Clear();
            this.Close();
        }
    }
}
