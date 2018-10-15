using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace Assignment2
{
    public partial class MainMenu : Form
    {
        DirectoryInfo parentFolder;
        public MainMenu()
        {
            string expath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            parentFolder = Directory.GetParent(expath);
            InitializeComponent();
        }

        private void mainMenuAddStudentBtn_Click(object sender, EventArgs e)
        {
            AddStudentForm asf = new AddStudentForm(parentFolder);
            asf.Show();
        }

        private void mainMenuDeleteStudentBtn_Click(object sender, EventArgs e)
        {
            DeleteStudentForm dsf = new DeleteStudentForm(parentFolder);
            dsf.Show();
        }

        private void mainMenuStudentLookupBtn_Click(object sender, EventArgs e)
        {
            SearchStudentForm ssf = new SearchStudentForm(parentFolder);
            ssf.Show();
        }
    }
}
