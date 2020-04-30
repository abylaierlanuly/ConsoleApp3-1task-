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
        int _number;
        public School(int number) {
            _number = number;
        }

        public void AddClass(School schools) {
            schools.AddClass(schools);
        }
     
    }

    class Claas {
        List<Students> students = new List<Students>();
        string _claasname;
        public Claas(string claasname) {
            _claasname = claasname;
        }
        public void AddStudents(Students student) {
            students.Add(student); 
        }
    
    }

    class Students {
        string _studentname;
        public Students(String studentname) {
            _studentname = studentname;
        }
    }



}
