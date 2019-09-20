
using System;
using System.Collections; 
using System.Collections.Generic; 

namespace Task2
{
    class Student
    {
        // ------------------- VARS -------------------
        private string name;
        private string lastName;
        private string group;
        private List<Subject> subjects = null;

        // ------------------- GET SET -------------------
        public string getFullName(){
            return this.name + " " + this.lastName;
        }
        public void setFullName(string name, string lastName){
            this.name = name;
            this.lastName = lastName;
        }
        public string getGroup(){
            return this.group;
        }
        public void setGroup(string group){
            this.group = group;
        }

        public List<Subject> getSubjects(){
            return subjects;
        }

        // ------------------- CONSTRUCTORS -------------------
        public Student(string name = "Evaldas", string lastName = "Paulauskas", string group = "PI18E"){
            this.name = name;
            this.lastName = lastName;
            this.group = group;
            this.subjects = new List<Subject>();
        }

        //Constructor calling another constructor if Struct is sent
        public Student(StudentVars vars) : this(vars.name, vars.lastName, vars.groupName){ }

        // ------------------- METHODS -------------------
        public void addSubject(SubjectVars vars){  
            Subject newSubject = new Subject(vars);
            subjects.Add(newSubject);
        }

        public double calculateAverage(){
            int allCredits = 0;
            double allMultipliedValues = 0;
            subjects.ForEach(el => {allCredits += el.getCredits(); allMultipliedValues += el.getGrade() * el.getCredits(); } );

            return allMultipliedValues/allCredits;
        }

/*


    Sum the number of credits. 4 + 4 + 3 + 2 = 13, that was a really easy step.
    Take the value assigned to the grade and multiply by the number of credits. In our case, it will be:

    A * 4 credits = 4.0 * 4 = 16
    B * 4 credits = 3.0 * 4 = 12
    A * 3 credits = 4.0 * 3 = 12
    C * 2 credits = 2.3 * 2 = 4.6

    Add all the values. 16 + 12 + 12 + 4.6 = 44.6
    Divide the sum by the total number of credits. So for our example it's equal to 44.6/13 = 3.43


 */

    }
}