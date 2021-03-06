using System;

namespace Task2
{

    class Subject
    {
        // ------------------- VARS -------------------
        private string name;
        private int grade;
        private int credits;

        // ------------------- GET SET -------------------
        public int getGrade(){
            return grade;
        }
        public int getCredits(){
            return credits;
        }

        // ------------------- CONSTRUCTORS -------------------
        public Subject(string name, int grade, int credits){
            this.name = name;
            this.grade = grade;
            this.credits = credits;
        }

        public Subject(SubjectVars vars) : this(vars.name, vars.grade, vars.credits){
            //sending values to the other constructor
        }

        // ------------------- METHODS -------------------
        public string getInfo(){
            return $"{name} | Grade: {grade} | Credits: {credits}";
        }
        
    }
}