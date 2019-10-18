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
    public partial class Form1 : Form
    {
        //init class for storing student groups
        GroupsContainer groupsContainer = new GroupsContainer();
        
        public Form1()
        {
            InitializeComponent();

        }

        private void addGroupBtn_Click(object sender, EventArgs e)
        {
            GroupCreateForm x = new GroupCreateForm(groupsContainer);
            x.ShowDialog();
        }

        private void EditGroupBtn_Click(object sender, EventArgs e)
        {
            //find and compare strings, then send the group if matched
            if(GroupListBox.SelectedItem != null)
            {
                groupsContainer.getGroups().ForEach(group =>
                {
                    if (group.getTitle() == GroupListBox.SelectedItem.ToString())
                    {
                        //use constructor to pass selected group
                        GroupCreateForm x = new GroupCreateForm(group,groupsContainer);
                        x.ShowDialog();
                    }
                });
            }
            else
            {
                MessageBox.Show("Select group to edit");
            }


        }

        private void SelectBtn_Click(object sender, EventArgs e)
        {
            //find and compare strings, then send the group if matched
            if (GroupListBox.SelectedItem != null)
            {
                groupsContainer.getGroups().ForEach(group =>
                {
                    if (group.getTitle() == GroupListBox.SelectedItem.ToString())
                    {
                        //use constructor to pass selected group
                        GroupInfoForm x = new GroupInfoForm(group);
                        x.ShowDialog();
                    }
                });
            }
            else
            {
                MessageBox.Show("Select group first");
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            //nothing selected
            if (GroupListBox.SelectedItem == null)
            {
                MessageBox.Show("Select group first");
                return;
            }
            else
            {
                //confirmation
                DialogResult result = MessageBox.Show("Are you sure?", "Confirm Delete", MessageBoxButtons.YesNo);
                Console.WriteLine(result);
                if (result == DialogResult.Yes)
                {
                    int index = 0;
                    int currIndex=0;
                    groupsContainer.getGroups().ForEach(group =>
                    {
                        if (group.getTitle() == GroupListBox.SelectedItem.ToString())
                        {
                            currIndex = index;
                        }
                        index++;
                        
                    });
                    groupsContainer.groups.RemoveAt(currIndex);

                    //finalize by updating UI
                    Form1Update();

                }
                else
                {
                    //do nothing
                }
            }

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            addTestValues();
            Form1Update();
        }

        public void Form1Update()
        {
            //clear
            GroupListBox.Items.Clear();

            //init and display student groups available ( if any )
            groupsContainer.getGroups().ForEach(group => {
                GroupListBox.Items.Add(group.getTitle());
            });
            if (groupsContainer.getGroups().Count == 0)
            {
                GroupListBox.Items.Clear();
            }

        }

        public void addTestValues()
        {
            StudentGroup testGroup = new StudentGroup("PI18E", "18");
            testGroup.AddStudent("Evaldas", "paulauskas");
            testGroup.AddSubject("Math", 10);

            testGroup.AddStudent("aaaa", "aaa");
            testGroup.AddStudent("bbbb", "bbb");
            testGroup.AddStudent("ccc", "ddd");
            testGroup.AddStudent("ffff", "ggg");
            testGroup.AddStudent("hhh", "hhh");
            testGroup.AddStudent("jjjj", "jjjj");

            groupsContainer.addGroup(testGroup);
        }

        private void GroupListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //do nothing
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            Form1Update();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Form1Update();
        }
    }
}
