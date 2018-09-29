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
        public AddStudentEducationForm(Dictionary<string, string> form1Dict)
        {
            formDict = form1Dict;
            InitializeComponent();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {


            formDict["department"] = departmentTB.Text;
            formDict["enrollmentYear"] = enrollmentYearTB.Text;
            formDict["expGraduation"] = expectedGraduationrTB.Text;
            formDict["gpa"] = gpaTB.Text;
            string str = "";
            foreach(string s in formDict.Values)
            {
                str += s + ",";
            }
            str += "\n";
            string fileName = @"C:\Users\KR\Documents\Visual Studio 2015\Projects\Assignment2\Assignment2\School.cvs";
            if (!File.Exists(fileName))
            {
                string clientHeader = "firstName,lastName,schoolId,homeAddress,email,phone,birthDate,gender,race,learningDisability,department,enrollmentYear,expGraduation,gpa" + Environment.NewLine;

                File.WriteAllText(fileName, clientHeader);
            }

            File.AppendAllText(fileName, str);
            gpaTB.Clear();
            enrollmentYearTB.Clear();
            expectedGraduationrTB.Clear();
            departmentTB.Clear();
            this.Close();
        }
    }
}
