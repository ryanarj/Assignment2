using System;
using System.Windows.Forms;

namespace Assignment2
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void mainMenuAddStudentBtn_Click(object sender, EventArgs e)
        {
            AddStudentForm asf = new AddStudentForm();
            asf.Show();
        }

        private void mainMenuDeleteStudentBtn_Click(object sender, EventArgs e)
        {
            DeleteStudentForm dsf = new DeleteStudentForm();
            dsf.Show();
        }

        private void mainMenuStudentLookupBtn_Click(object sender, EventArgs e)
        {
            SearchStudentForm ssf = new SearchStudentForm();
            ssf.Show();
        }
    }
}
