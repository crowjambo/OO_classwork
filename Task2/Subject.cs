using System;

namespace Task2
{

    class Subject
    {
        //vars
        private string name;
        private int grade;
        private int credits;

        //constructor
        public Subject(string name, int grade, int credits){
            this.name = name;
            this.grade = grade;
            this.credits = credits;
        }

        //methods
        public string getInfo(){
            return $"{name} {grade} {credits}";
        }
        
    }
}