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
    public partial class DeleteSearch : Form
    {
        public DeleteSearch()
        {
            InitializeComponent();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            string fileName = @"C:\Users\KR\Documents\Visual Studio 2015\Projects\Assignment2\Assignment2\School.cvs";
            string userID = userIdTB.Text;
            List<string> lines = new List<String>();

            if (File.Exists(fileName))
            {
                using (StreamReader reader = new StreamReader(fileName))
                {
                    string line;

                    while ((line = reader.ReadLine()) != null)
                    {
                        if (line.Contains(","))
                        {
                            string[] split = line.Split(',');

                            if (split[2].Contains(userID))
                            {
                                line = "";
                            }
                        }

                        lines.Add(line);
                    }
                }

                using (StreamWriter writer = new StreamWriter(fileName, false))
                {
                    foreach (string line in lines)
                        writer.WriteLine(line);
                }
            }
        }
    }
}
