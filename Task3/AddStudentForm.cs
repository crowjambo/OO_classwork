using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task3.BackEnd;

namespace Task3
{
    public partial class AddStudentForm : Form
    {
        StudentGroup group;
        public AddStudentForm(StudentGroup group)
        {
            InitializeComponent();
            this.group = group;
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            group.AddStudent(NameTextBox.Text, LastNameTextBox.Text);
            this.Close();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
