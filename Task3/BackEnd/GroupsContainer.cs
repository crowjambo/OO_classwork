using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.BackEnd
{
    public class GroupsContainer
    {
        public List<StudentGroup> groups = new List<StudentGroup>();

        public GroupsContainer()
        {
            //empty at first (unless want to preload some data from somewhere! )

            StudentGroup testGroup = new StudentGroup("PI18E", "18");
            testGroup.AddStudent("Evaldas", "paulauskas");
            testGroup.AddSubject("Math", 10);

            testGroup.AddStudent("aaaa", "aaa");
            testGroup.AddStudent("bbbb", "bbb");
            testGroup.AddStudent("ccc", "ddd");
            testGroup.AddStudent("ffff", "ggg");
            testGroup.AddStudent("hhh", "hhh");
            testGroup.AddStudent("jjjj", "jjjj");

            groups.Add(testGroup);
        }

        //methods



    }
}
