using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Assignment2
{

    public partial class AddStudentForm : Form
    {
        DirectoryInfo pFolder1;

        public AddStudentForm(DirectoryInfo pFolder)
        {
            pFolder1 = pFolder;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void toEducationFormBtn_Click(object sender, EventArgs e){
            // Add all the values into a dictionary
            Dictionary<string, string> formText = new Dictionary<string, string>();

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


            if (firstNameTB.Text != "" && System.Text.RegularExpressions.Regex.IsMatch(firstNameTB.Text, "^[a-zA-Z]+$") 
                && lastNameTB.Text != "" && System.Text.RegularExpressions.Regex.IsMatch(lastNameTB.Text, "^[a-zA-Z]+$")
                && schoolIdTB.Text != "" 
                && homeAddressTB.Text != "" && System.Text.RegularExpressions.Regex.IsMatch(homeAddressTB.Text, "^[a-zA-Z]+$")
                && emailTB.Text != ""
                && phoneNumberTB.Text != ""
                && raceTB.Text != "" && System.Text.RegularExpressions.Regex.IsMatch(raceTB.Text, "^[a-zA-Z]+$")
                && learningDisabilityTB.Text != ""
                && genderTB.Text != "" && System.Text.RegularExpressions.Regex.IsMatch(genderTB.Text, "^[a-zA-Z]+$"))
            {
                formText["firstName"] = firstNameTB.Text;
                formText["lastName"] = lastNameTB.Text;
                formText["schoolId"] = schoolIdTB.Text;
                formText["homeAddress"] = homeAddressTB.Text;
                formText["email"] = emailTB.Text;
                formText["phone"] = phoneNumberTB.Text;
                formText["birthDate"] = birthDateTB.Text;
                formText["gender"] = genderTB.Text;
                formText["race"] = raceTB.Text;
                formText["learningDisability"] = learningDisabilityTB.Text;


                // Clear the fields
                firstNameTB.Clear();
                lastNameTB.Clear();
                schoolIdTB.Clear();
                homeAddressTB.Clear();
                emailTB.Clear();
                phoneNumberTB.Clear();
                raceTB.Clear();
                genderTB.Clear();
                learningDisabilityTB.Clear();

                // Show the Add student education form
                AddStudentEducationForm addStudentEducation = new AddStudentEducationForm(formText, pFolder1);
                addStudentEducation.Show();
                this.Close();

            }
            else
            {
                MessageBox.Show("All textboxes need to have a value and/or all values need to be the correct data type!!");
            }
        
        }

    }

}
