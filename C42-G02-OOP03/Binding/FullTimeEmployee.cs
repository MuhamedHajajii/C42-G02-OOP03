using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G02_OOP03.Binding
{
    internal class FullTimeEmployee : Employee
    {

        public decimal Salary { get; set; }

        public FullTimeEmployee(int id, string name , int age, decimal salary): base(id,name,age)
        {
            Salary = salary;
        }

        public new void GetEmployeeType()
        {
            Console.WriteLine("I'm Full Time Employee");
        }

        public override void GetEmployeeData()
        {
            Console.WriteLine($"FullTimeEmployee : Id = {ID} , Name = {Name} , Age = {Age} , Salary = {Salary}");
        }

    }
}
