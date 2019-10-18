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
    public partial class GroupInfoForm : Form
    {
        StudentGroup group;

        public GroupInfoForm(StudentGroup group)
        {
            InitializeComponent();

            this.group = group;

            UpdateFields();

            
        }

        private void AddGradeBtn_Click(object sender, EventArgs e)
        {
            if(StudentsList.SelectedItem != null && SubjectsList.SelectedItem != null && GradeInputBox.Text != "")
            {
                group.studentList.ForEach(student =>
                {
                    if(student.getName()+" "+student.getLastName() == StudentsList.SelectedItem.ToString())
                    {
                        student.AddGrade(SubjectsList.SelectedItem.ToString(),Convert.ToInt32(GradeInputBox.Text));
                    }
                });

                
            }
        }

        private void DeleteGradeBtn_Click(object sender, EventArgs e)
        {
            //check that all is selected
            if (StudentsList.SelectedItem != null && SubjectsList.SelectedItem != null && GradesList.SelectedItem != null)
            {
                //scan through all students to find one matching selected values
                group.studentList.ForEach(student =>
                {
                    if (student.getName() + " " + student.getLastName() == StudentsList.SelectedItem.ToString())
                    {
                        //do action once found
                        student.DeleteGrade(SubjectsList.SelectedItem.ToString(), Convert.ToInt32(GradesList.SelectedItem));
                    }
                });


            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StudentsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //nothing
        }

        private void GradesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //nothing
        }

        private void UpdateFields()
        {
            //clear
            StudentsList.Items.Clear();
            SubjectsList.Items.Clear();
            CreditsListBox.Items.Clear();
            GradesList.Items.Clear();
            Top3StudentsList.Items.Clear();

            //students list print
            group.GetStudents().ForEach(student =>
            {
                StudentsList.Items.Add(student.getName() + " " + student.getLastName());
            });

            //subjects and credits print
            group.GetSubjects().ForEach(subject =>
            {
                SubjectsList.Items.Add(subject.getTitle());
                CreditsListBox.Items.Add(subject.getCredits().ToString());
            });


            //include automatically calculated top 3, average etc in here!!!!
            var topThree = group.Top3Students();


            for (int i = 0; i < 3; i++)
            {
                Top3StudentsList.Items.Add(topThree[i].getName() + " " + topThree[i].getLastName() + " " + topThree[i].calcOverallAverage().ToString());
            }
            





        }


        private void RefreshBtn_Click(object sender, EventArgs e)
        {

            UpdateFields();


        }

        public void ShowGrades()
        {
            GradesList.Items.Clear();
            //grades print (only once selected)
            if (StudentsList.SelectedItem != null && SubjectsList.SelectedItem != null)
            {
                group.GetStudents().ForEach(student =>
                {
                    //find matching student
                    if (student.getName() + " " + student.getLastName() == StudentsList.SelectedItem.ToString())
                    {
                        //returns a list
                        var gradesList = student.GetGrades(SubjectsList.SelectedItem.ToString());
                        if (gradesList != null)
                        {
                            gradesList.ForEach(grade =>
                            {
                                GradesList.Items.Add(grade.ToString());
                            });
                        }

                        //show average for selected grade
                        float average = student.calcAverageGradeForSubject(SubjectsList.SelectedItem.ToString());

                        SubjectAverageLabel.Text = average.ToString();

                        //show average of all subjects for student
                        average = student.calcOverallAverage();
                        OverallAverageLabel.Text = average.ToString();

                    }
                });

                //show whole groups average
                WholeGroupAverageLabel.Text = group.calcAllGroupAverage().ToString();
            }
        }

        private void ShowGradesBtn_Click(object sender, EventArgs e)
        {
            ShowGrades();
        }
    }
        
}
