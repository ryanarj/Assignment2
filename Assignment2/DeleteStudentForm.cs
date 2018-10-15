using System;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace Assignment2
{
    public partial class DeleteStudentForm : Form
    {
        DirectoryInfo pFolder;
        public DeleteStudentForm(DirectoryInfo pFolder1)
        {
            pFolder = pFolder1;
            InitializeComponent();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            bool isFound = false;
            string path = pFolder.FullName;
            string fileName = path.Substring(0, path.Length - 3) + "Students.xml";
            string userID = userIdTB.Text;
            XmlDocument xdoc = new XmlDocument();
            xdoc.Load(fileName);
            XmlNodeList nodes = xdoc.GetElementsByTagName("Student");
            for (int i = 0; i < nodes.Count; i++)
            {
                if (nodes[i]["schoolId"].InnerXml == userID)
                {
                    nodes[i].ParentNode.RemoveChild(nodes[i]);
                    MessageBox.Show("Student has been been deleted!!");
                    isFound = true;
                    xdoc.Save(fileName);
                }
            }
            if(!isFound) {
                MessageBox.Show("Cannot find user!");
            }

        }
    }
}
