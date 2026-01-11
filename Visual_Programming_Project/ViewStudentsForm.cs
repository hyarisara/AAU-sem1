using System;
using Visual_Programming_Project;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Visual_Programming_Project
{
    public partial class ViewStudentsForm : Form
    {
        public ViewStudentsForm()
        {
            InitializeComponent();
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            lstStudents.Items.Clear();

            if (File.Exists("students.txt"))
            {
                string[] students = File.ReadAllLines("students.txt");

                foreach (string student in students)
                {
                    lstStudents.Items.Add(student);
                }
            }
            else
            {
                MessageBox.Show("No student records found");
            }
        }
    }
}
