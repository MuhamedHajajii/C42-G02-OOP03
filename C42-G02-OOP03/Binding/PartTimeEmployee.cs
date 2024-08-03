using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G02_OOP03.Binding
{
    internal class PartTimeEmployee : Employee
    {
        public int HourRate { get; set; }
        public int CountOfHours { get; set; }


        //public PartTimeEmployee( int hourRate, int countOfHours)
        //{
        //    HourRate = hourRate;
        //    CountOfHours = countOfHours;
        //}

        public new void GetEmployeeType()
        {
            Console.WriteLine("I'm PartTime Employee");
        }

        public override void GetEmployeeData()
        {
            Console.WriteLine($"PartTimeEmployee : Id = {ID} , Name = {Name} , Age = {Age} , CountOfHour = {CountOfHours} , HourRate = {HourRate}");
        }

    }
}
