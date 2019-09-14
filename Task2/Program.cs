// Parašykite programą, kuri apskaičiuoja studento pažymių vidurkį, atsižvelgdama į dalykų apimtį kreditais.
//Programa turi leisti įvesti studento duomenis (vardas, pavarde, grupė) ir išklausytus dalykus (pavadinimas, įvertinimas, kreditų kiekis) klaviatūra. (7 taškai)
//Programa ekrane turi išvesti pilną studento informaciją ir apskaičiuotojo vidurkio reikšmę. (8 taškai)
//Programos architektūra turi atitikti vienafunkciškumo principą (angl. Single Responsibility). (10 taškų)
//============================
//EVALDAS PAULAUSKAS PI18E
//TASK 2
//============================


using System;

namespace Task2
{
    
    class Program
    {

        static void Main(string[] args)
        {
            //create student
            Student student1 = new Student(InputManager.StudentInput());

            //adds subjects
            for(int i = 0; i<3;i++){
                student1.addSubject(InputManager.SubjectInput());
            }

            //outputs
            Console.WriteLine("\n\n-------------------\n\n");
            Console.Write($"{student1.getFullName()} {student1.getGroup()} \n");
            student1.getSubjects().ForEach(el => Console.WriteLine(el.getInfo()));
            Console.WriteLine($"Average grade: {student1.calculateAverage()}");
            Console.WriteLine("\n\n-------------------");
        }
    }
}
