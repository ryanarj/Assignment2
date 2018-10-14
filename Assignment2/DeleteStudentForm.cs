using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace Assignment2
{
    public partial class DeleteStudentForm : Form
    {
        public DeleteStudentForm()
        {
            InitializeComponent();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            string fileName = @"C:\Users\KR\Documents\Visual Studio 2015\Projects\Assignment2\Assignment2\Students.xml";
            string userID = userIdTB.Text;
            XmlDocument xdoc = new XmlDocument();
            xdoc.Load(fileName);
            XmlNodeList nodes = xdoc.GetElementsByTagName("Student");
            for (int i = 0; i < nodes.Count; i++)
            {
                string a = nodes[i]["schoolId"].InnerXml;
                if (nodes[i]["schoolId"].InnerXml == userID)
                {
                    nodes[i].ParentNode.RemoveChild(nodes[i]);
                }
            }
            xdoc.Save(fileName);

        }
    }
}
