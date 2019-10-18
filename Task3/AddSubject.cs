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
    public partial class AddSubject : Form
    {
        StudentGroup group;

        public AddSubject(StudentGroup group)
        {
            InitializeComponent();

            this.group = group;
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            group.AddSubject(TitleTextBox.Text, Convert.ToInt32(CreditsTextBox.Text));
            this.Close();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
