//class for taking in inputs and returning them
using System;
using System.Collections.Generic; 

namespace Task2
{
    public struct SubjectVars{
        public string name;
        public int grade;
        public int credits;
    }

    public struct StudentVars{
        public string name;
        public string lastName;
        public string groupName;
    }

    class InputManager{
  
        public static StudentVars StudentInput(){
            var studentInputs = new StudentVars();

            Console.Write("Enter student name: ");
            studentInputs.name = Console.ReadLine();
            Console.Write("Enter LastName: ");
            studentInputs.lastName = Console.ReadLine();
            Console.Write("Enter Group Name: ");
            studentInputs.groupName = Console.ReadLine();

            return studentInputs;
        }

        public static SubjectVars AddSingleSubject(){
            var subjectInputs = new SubjectVars();
            
            //take inputs
            Console.Write("Subject name: ");
            subjectInputs.name = Console.ReadLine();
            Console.Write("Grade: ");
            subjectInputs.grade = Int32.Parse(Console.ReadLine());
            Console.Write("Credits: ");
            subjectInputs.credits = Int32.Parse(Console.ReadLine());
  
            
            return subjectInputs;
        }

        public static List<SubjectVars> AddMultipleSubjects(){
            var subjectsToAdd = new List<SubjectVars>();

            while(true){
                subjectsToAdd.Add(AddSingleSubject());
                Console.Write("Continue adding? N/n to stop : ");
                var inputKey = Console.ReadLine();
                if(inputKey == "N" || inputKey == "n"){
                    break;
                }
            }
            return subjectsToAdd;
        }
    }

}
