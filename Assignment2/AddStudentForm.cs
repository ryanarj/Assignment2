using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Assignment2
{

    public partial class AddStudentForm : Form
    {
        public AddStudentForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void toEducationFormBtn_Click(object sender, EventArgs e){
            // Add all the values into a dictionary
            Dictionary<string, string> formText = new Dictionary<string, string>();
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
            birthDateTB.Clear();
            genderTB.Clear();
            learningDisabilityTB.Clear();

            // Show the Add student education form
            AddStudentEducationForm addStudentEducation = new AddStudentEducationForm(formText);
            addStudentEducation.Show();
        }

        private void toAdvanceSearchBtn_Click(object sender, EventArgs e){
            // Show the Student search form
            SearchStudentForm searchStudent = new SearchStudentForm();
            searchStudent.Show();
        }

        private void deleteUserBtn_Click(object sender, EventArgs e){
            // Show the Delete student form
            DeleteStudentForm deleteSerach = new DeleteStudentForm();
            deleteSerach.Show();
        }
    }

}
