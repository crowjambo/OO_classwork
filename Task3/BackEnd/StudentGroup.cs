using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.BackEnd
{

    public class StudentGroup
    {
        private string title;
        private string semesterNumber;
        public List<Subject> subjectList = new List<Subject>();
        public List<Student> studentList = new List<Student>();

        //get set
        public void setTitle(string title)
        {
            this.title = title;
        }
        public string getTitle()
        {
            return title;
        }
        public void setSemesterNumber(string sN)
        {
            this.semesterNumber = sN;
        }
        public string getSemesterNumber()
        {
            return semesterNumber;
        }
        public List<Subject> GetSubjects()
        {
            return subjectList;
        }
        public List<Student> GetStudents()
        {
            return studentList;
        }

        //constructor
        public StudentGroup(string title, string semesterNumber)
        {
            this.title = title;
            this.semesterNumber = semesterNumber;
        }

        public StudentGroup()
        {

        }

        //methods
        public void AddStudent(string name, string lastName)
        {
            Student x = new Student(name, lastName);
            studentList.Add(x);
        }
        public void AddSubject(string title, int credits)
        {
            Subject x = new Subject(title, credits);
            subjectList.Add(x);
        }
        public float calcAllGroupAverage()
        {
            float total = 0;
            int index = 0;
            studentList.ForEach(student =>
            {
               total+= student.calcOverallAverage();
                index++;
            });

            return total/index;
        }

        public List<Student> Top3Students()
        {
            List<Student> temp = new List<Student>();
            Student x = new Student("test", "test");
            temp.Add(x);
            temp.Add(x);
            temp.Add(x);

            float top1Val = 0;
            float top2Val = 0;
            float top3Val = 0;
            float avg;

            studentList.ForEach(student =>
            {
                avg = student.calcOverallAverage();

                if (avg > top1Val)
                {
                    top1Val = avg;
        
                    temp.Insert(0, student);
                }

                else if (avg > top2Val && avg > top3Val)
                {
                    top2Val = avg;
                   
                    temp.Insert(1, student);
                }

                else if (avg > top3Val)
                {
                    top3Val = avg;
                    temp.Insert(2, student);
                }


            });


            return temp;
        }
    }
}
