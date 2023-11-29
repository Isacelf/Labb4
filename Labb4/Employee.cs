using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Labb4
{
    internal class Employee // En klass som ska representera anställda
    {
        public int _id {  get; set; } // Olika egenskaper för anställda
        public string _name { get; set; }
        public string _gender { get; set; }
        public int _salary { get; set; }

        // Konstruktor för att skapa en ny anställd med givna egenskaper
        public Employee (int ID, string Name, string Gender, int Salary) 
        {
            _id = ID;
            _name = Name;
            _gender = Gender;
            _salary = Salary;
        }
        public void EmployeeInfo() // Metod för att skriva ut information om den anställda
        {
            Console.WriteLine($"ID = {_id} - Name = {_name} - Gender = {_gender} - Salary = {_salary}");

        }
    }
}
