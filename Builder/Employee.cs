using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    internal class Employee
    {
        public string StaffNo { get; set; }
        public string IDNumber { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Nationailty { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public double Salary { get; set; }
        public bool SACitizen { get; set; }

        public Employee(string staffNo, string idnumber, string name, string surname, string nationailty, string email, string username, string password, double salary, bool sACitizen)
        {
            StaffNo = staffNo;
            IDNumber = idnumber;
            Name = name;
            Surname = surname;
            Nationailty = nationailty;
            Email = email;
            Username = username;
            Password = password;
            Salary = salary;
            SACitizen = sACitizen;
        }

        public Employee(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public Employee(string staffNo, string name, string surname) : this(staffNo, name)
        {
            StaffNo = staffNo;
            Surname = surname;
            Surname = surname;
        }


    }
}
