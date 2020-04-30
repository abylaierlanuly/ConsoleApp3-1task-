using System;
using System.Collections.Generic;

namespace ConsoleApp3_1task_
{
    class Program
    {
        static void Main(string[] args)
        {
            School sh = new School(2);
            Console.WriteLine(sh);
        }
    }

    class School {
        List<School> schools = new List<School>();
       public int number;
        public School(int numberr) {
            number = numberr;
        }

        public void AddClass(School schools) {
            schools.AddClass(schools);
        }
     
    }

    class Claas {
        List<Students> students = new List<Students>();
        public string claasname;
        public Claas(string claasnamee) {
            claasname = claasnamee;
        }
        public void AddStudents(Students student) {
            students.Add(student); 
        }
    
    }

    class Students {
       public  string studentname;
        public Students(String studentnamee) {
            studentname = studentnamee;
        }
    }



}
