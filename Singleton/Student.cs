using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton
{
    internal class Student
    {
        private string surname;

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        public string StudentID { get; set; }
        public string Name { get; set; }

        private static Student student;


        private Student() {}

        private Student(string id, string name)
        {
            this.StudentID = id;
            this.Name = name;   
        }

        public static Student GetStudent(string x, string y) 
        {
            if (student == null)
            {
                student = new Student(x, y);
            }
            return student;
        }

    }
}
