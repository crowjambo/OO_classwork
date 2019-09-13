
//     Programa turi leisti įvesti studento duomenis (vardas, pavarde, grupė) ir išklausytus dalykus (pavadinimas, įvertinimas, kreditų kiekis) klaviatūra. (7 taškai)
//     Programa ekrane turi išvesti pilną studento informaciją ir apskaičiuotojo vidurkio reikšmę. (8 taškai)

using System;
using System.Collections; 
using System.Collections.Generic; 

namespace Task2
{
    class Student
    {
        //variables
        private string name;
        private string lastName;
        private string group;
        private List<Subject> subjects = new List<Subject>();

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

        public List<Subject> getSubjects(){
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
            Subject newSubject = new Subject(name,grade,credits);
            subjects.Add(newSubject);



            //newSubject.name = name etc etc
            //can just use class, and each class has its own return single instance function as string, and then just using foreach on the array of subject objects can call each their own printing/returning/get function!!!

            //create it and then send it to setter

            //how do I access / create structs in c#, check it out
        }

        //methods

        //calculate vidurki pagal creditus + return the value!
        public double calculateAverage(){
            return 3.3; //return average here
        }

        
        public static Student SubjectsInput(Student student){
            string name;
            int grade;
            int credits;
            while(true){
                Console.Write("Add subject? Y/N?");
                string input = Console.ReadLine();
                if(input == "N"){
                    break;
                }
                Console.Write("Subject name: ");
                name = Console.ReadLine();
                Console.Write("Grade: ");
                grade = Int32.Parse(Console.ReadLine());
                Console.Write("Credits: ");
                credits = Int32.Parse(Console.ReadLine());
                student.addSubject(name,grade,credits);
            }
            return student;
        }
    }
}