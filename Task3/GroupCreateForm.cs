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
    public partial class GroupCreateForm : Form
    {
        StudentGroup group;
        GroupsContainer groupContainer;
        StudentGroup backUpGroup = new StudentGroup();
        bool editing = false;

        //empty create
        public GroupCreateForm(GroupsContainer groupContainer)
        {
            InitializeComponent();

            this.groupContainer = groupContainer;
            this.group = new StudentGroup();

            
            
        }

        //edit create
        public GroupCreateForm(StudentGroup group, GroupsContainer groupContainer)
        {
            InitializeComponent();
            this.group = group;
            this.groupContainer = groupContainer;

            TitleTextBox.Text = group.getTitle();
            SemesterNumberTextBox.Text = group.getSemesterNumber();

            UpdateFormFields();

            //in case cancel
            BackUpGroupSetUp(backUpGroup,group);

            editing = true;
        }


        private void SaveGroupBtn_Click(object sender, EventArgs e)
        {
            if (!editing)
            {
                groupContainer.addGroup(group);
            }
            group.setTitle(TitleTextBox.Text);
            group.setSemesterNumber(SemesterNumberTextBox.Text);

            this.Close();
        }

        private void AddStudentBtn_Click(object sender, EventArgs e)
        {
            AddStudentForm x = new AddStudentForm(group);
            x.ShowDialog();
        }

        private void RemoveStudentBtn_Click(object sender, EventArgs e)
        {
            int index = 0;
            int currIndex = 0;
            group.GetStudents().ForEach(student =>
            {
                var x = student.getName() + " " + student.getLastName();
                if(x == StudentsListBox.SelectedItem.ToString())
                {
                    currIndex = index;
                }
                index++;
            });
            group.studentList.RemoveAt(currIndex);

            UpdateFormFields();
        }

        private void AddSubjectBtn_Click(object sender, EventArgs e)
        {
            AddSubject x = new AddSubject(group);
            x.ShowDialog();
        }

        private void RemoveSubjectBtn_Click(object sender, EventArgs e)
        {
            int index = 0;
            int currIndex = 0;
            group.GetSubjects().ForEach(subject =>
            {
                
                if (subject.getTitle() == SubjectsListBox.SelectedItem.ToString())
                {
                    currIndex = index;
                }
                index++;
            });
            group.subjectList.RemoveAt(currIndex);

            UpdateFormFields();
        }

        private void CancelGroupBtn_Click(object sender, EventArgs e)
        {
            BackUpGroupSetUp(group, backUpGroup);

            this.Close();
        }

        public void UpdateFormFields()
        {
            //reset listboxes to 0
            SubjectsListBox.Items.Clear();
            StudentsListBox.Items.Clear();


            group.GetSubjects().ForEach(subject =>
            {
                SubjectsListBox.Items.Add(subject.getTitle());
            });
            group.GetStudents().ForEach(student =>
            {
                StudentsListBox.Items.Add(student.getName() + " " + student.getLastName());
            });

            if(group.GetSubjects().Count == 0)
            {
                SubjectsListBox.Items.Clear();
            }
            if(group.GetStudents().Count == 0)
            {
                StudentsListBox.Items.Clear();
            }
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            UpdateFormFields();
        }

        private void BackUpGroupSetUp(StudentGroup cloneDestination, StudentGroup cloneTarget)
        {
            //clean
            cloneDestination.subjectList.Clear();
            cloneDestination.studentList.Clear();

            //copy data
            cloneDestination.setTitle(cloneTarget.getTitle());
            cloneDestination.setSemesterNumber(cloneTarget.getSemesterNumber());
            cloneTarget.GetSubjects().ForEach(subject =>
            {
                cloneDestination.AddSubject(subject.getTitle(),subject.getCredits());
            });
            cloneTarget.GetStudents().ForEach(student =>
            {
                cloneDestination.AddStudent(student.getName(),student.getLastName());
            });
        }
    }
}
