using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Labb4
{
    internal class Employee
    {
        public int _id {  get; set; }
        public string _name { get; set; }
        public string _gender { get; set; }
        public int _salary { get; set; }

        public Employee (int ID, string Name, string Gender, int Salary)
        {
            _id = ID;
            _name = Name;
            _gender = Gender;
            _salary = Salary;
        }
        public void EmployeeInfo()
        {
            Console.WriteLine($"ID = {_id} - Name = {_name} - Gender = {_gender} - Salary = {_salary}");

        }
    }
}
