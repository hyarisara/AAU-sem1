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
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string gender = rbMale.Checked ? "Male" : "Female";

            string studentData = txtID.Text + "," +
                                 txtName.Text + "," +
                                 cmbDepartment.Text + "," +
                                 gender;

            File.AppendAllText("students.txt", studentData + Environment.NewLine);

            MessageBox.Show("Student saved successfully");

            txtID.Clear();
            txtName.Clear();
            cmbDepartment.SelectedIndex = -1;

        }
    }
}
