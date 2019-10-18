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
        }

        //methods
        public void addGroup(StudentGroup group)
        {
            groups.Add(group);
        }
        public List<StudentGroup> getGroups()
        {
            return groups;
        }


    }
}
