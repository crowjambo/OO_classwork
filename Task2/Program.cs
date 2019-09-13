// Parašykite programą, kuri apskaičiuoja studento pažymių vidurkį, atsižvelgdama į dalykų apimtį kreditais.

// Pagrindiniai reikalavimai:

//     Programa turi leisti įvesti studento duomenis (vardas, pavarde, grupė) ir išklausytus dalykus (pavadinimas, įvertinimas, kreditų kiekis) klaviatūra. (7 taškai)
//     Programa ekrane turi išvesti pilną studento informaciją ir apskaičiuotojo vidurkio reikšmę. (8 taškai)

// Papildomas reikalavimas:

//     Programos architektūra turi atitikti vienafunkciškumo principą (angl. Single Responsibility). (10 taškų)

//EVALDAS PAULAUSKAS PI18E
//TASK 2


using System;

namespace Task2
{
    
    class Program
    {

        static void Main(string[] args)
        {
            //create student
            Student student1 = new Student();

            //user input
            Console.Write("Enter student name: ");
            string name = Console.ReadLine();
            Console.Write("Enter LastName: ");
            string lastName = Console.ReadLine();
            Console.Write("Enter Group Name: ");
            string groupName = Console.ReadLine();

            //use setters
            student1.setFullName(name,lastName);
            student1.setGroup(groupName);
            
            //subjects input
            student1 = Student.SubjectsInput(student1);


            //outputs
            Console.Write("{0} {1} \n", student1.getFullName(), student1.getGroup());
            student1.getSubjects().ForEach(el => Console.WriteLine(el.getInfo()));
        }
    }
}
