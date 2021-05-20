using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqToXML
{
    public class Student
    {
        public int id { get; set; }
        public string name { get; set; }
        public string Gender { get; set; }
        public int Marks { get; set; }



        public static Student[] GetAllDetails()
        {
            Student[] std = new Student[4];
            std[0] = new Student { id = 1, name = "Ganesh", Gender = "Male", Marks = 89 };
            std[1] = new Student { id = 2, name = "Abhijeet", Gender = "Male", Marks = 90 };
            std[2] = new Student { id = 3, name = "Rohit", Gender = "Male", Marks = 79 };
            std[3] = new Student { id = 4, name = "GK", Gender = "Male", Marks = 99 };
            return std;
        }
    }
}
