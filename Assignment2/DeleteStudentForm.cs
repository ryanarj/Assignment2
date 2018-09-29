using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

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
            string fileName = @"C:\Users\KR\Documents\Visual Studio 2015\Projects\Assignment2\Assignment2\School.cvs";
            string userID = userIdTB.Text;
            List<string> lines = new List<String>();

            // Open the file and then file the line and then delete it if found.
            if (File.Exists(fileName)){
                using (StreamReader reader = new StreamReader(fileName)){
                    string line;
                    while ((line = reader.ReadLine()) != null){
                        if (line.Contains(",")){
                            // Split the line by ","
                            string[] split = line.Split(',');
                            // If the user id is in the third position of the array delete the line
                            if (split[2].Contains(userID)){line = "";}
                        }
                        lines.Add(line);
                    }
                }
                
                // Add the lines back tot eh file
                using (StreamWriter writer = new StreamWriter(fileName, false)){
                    foreach (string l in lines)
                        writer.WriteLine(l);
                }
            }
        }
    }
}
