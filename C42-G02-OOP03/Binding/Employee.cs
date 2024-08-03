using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G02_OOP03.Binding
{
    internal class Employee
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }

        public Employee(int iD, string? name, int age)
        {
            ID = iD;
            Name = name;
            Age = age;
        }

        public Employee()
        {
            
        }

        public void GetEmployeeType()
        {
            Console.WriteLine("I'm Employee");
        }

        public virtual void GetEmployeeData()
        {
            Console.WriteLine($"Employee : Id = {ID} , Name = {Name} , Age = {Age}");
        }

    }
}
