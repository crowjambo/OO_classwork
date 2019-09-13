
//     Programa turi leisti įvesti studento duomenis (vardas, pavarde, grupė) ir išklausytus dalykus (pavadinimas, įvertinimas, kreditų kiekis) klaviatūra. (7 taškai)
//     Programa ekrane turi išvesti pilną studento informaciją ir apskaičiuotojo vidurkio reikšmę. (8 taškai)

using System;

namespace Task2
{

    struct Subject{
        string name;
        int grade;
        int credits;
    }

    class Student
    {
        //variables
        private string name;
        private string lastName;
        private string group;
        private Subject[] subjects;

        //getters and setters
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
        private void setSubject(Subject subject){
            //append to list or array using addSubject method
            //might not be neccessary just send it in addSubject
        }
        public Subject[] getSubjects(){
            return subjects;
            //return the whole array or list and using foreach in program.cs print it all out?
            //whats the solid/dry approach to returning arrays or lists and printing them out?
            //simply return and thats it? this is just for data and data manipulation
        }

        //constructor
        public Student(){
            //leave empty? or default values
        }

        //methods
        public void addSubject(string name, int grade, int credits){
            Subject newSubject = new Subject();
            //newSubject.name = name etc etc

            //create it and then send it to setter

            //how do I access / create structs in c#, check it out
        }

        //calculate vidurki pagal creditus
    }
}