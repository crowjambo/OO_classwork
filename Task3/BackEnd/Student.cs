using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.BackEnd
{



    public class Student
    {
        private string name;
        private string lastName;
        Dictionary<string, List<int>> gradesDict = new Dictionary<string, List<int>>();


        //getters setters
        public void setName(string name)
        {
            this.name = name;
        }
        public string getName()
        {
            return name;
        }
        public void setLastName(string lastName)
        {
            this.lastName = lastName;
        }
        public string getLastName()
        {
            return lastName;
        }

        //constructor
        public Student(string name, string lastName)
        {
            this.name = name;
            this.lastName = lastName;
        }



        //methods
        public float calcAverageGradeForSubject(string subject)
        {
            if (gradesDict.ContainsKey(subject))
            {
                int total = 0;
                int index = 0;
                gradesDict[subject].ForEach(grade =>
                {
                    total += grade;
                    index++;
                });
                float result = (float)total / (float)index;
                return result;
            }
            else
            {
                return 0;
            }
        }

        public void AddGrade(string subject,int grade)
        {
            
            if (gradesDict.ContainsKey(subject))
            {
                gradesDict[subject].Add(grade);
            }
            else
            {
                List<int> x = new List<int>();
                gradesDict.Add(subject,x);
                gradesDict[subject].Add(grade);
                
            }


        }

        public void DeleteGrade(string subject, int grade)
        {
            gradesDict[subject].Remove(grade);
        }

        public List<int> GetGrades(string subject)
        {
            if (gradesDict.ContainsKey(subject))
            {
                return gradesDict[subject];
            }
            else
            {
                return null;
            }
        }

        public float calcOverallAverage()
        {

            int total = 0;
            int index = 0;
            gradesDict.ToList().ForEach(x =>
            {
                x.Value.ForEach(grade =>
                {
                    total += grade;
                    index++;
                });
            });
            float result = (float)total / (float)index;
            return result;
        }
    }
}
