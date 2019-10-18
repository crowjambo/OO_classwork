using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.BackEnd
{
    public class Subject
    {
        private string title;
        private int credits;

        //setters getters
        public void setTitle(string title)
        {
            this.title = title;
        }
        public string getTitle()
        {
            return title;
        }
        public void setCredits(int credits)
        {
            this.credits = credits;
        }
        public int getCredits()
        {
            return credits;
        }

        //constructor
        public Subject(string title, int credits)
        {
            this.title = title;
            this.credits = credits;
        }

        //methods

        
    }
}
