using C42_G02_OOP03.Binding;
using C42_G02_OOP03.Polymorphism;
using System.Security.Cryptography.X509Certificates;

namespace C42_G02_OOP03
{
    internal class Program
    {

        #region OverLoading

        public static int Sum(int x, int y)
        {
            return x * y;
        }

        // Change The Number Of Parameters
        public static int Sum(int x, int y, int z)
        {
            return x * y * z;
        }

        // Change The Type of Parameters
        public static string Sum(string Name, int y, int z)
        {
            return $"Name = {Name} , Number = { y * z}";
        }

        // Change The Order Of the datatype of the parameters
        public static string Sum( int y, string Name, int z)
        {
            return $"Name = {Name} , Number = {y * z}";
        }

        #endregion

        #region Ex01 - Employee 

        // Binding
        // Employee reference can refer for an object from employee type and object from child type
        public static void ProccessEmployee(Employee employee)
        {
            if (employee is not null)
            {
                employee.GetEmployeeType();
                employee.GetEmployeeData();
            }
        }
        //public static void ProccessEmployee(PartTimeEmployee employee)
        //{
        //    if (employee is not null)
        //    {
        //        employee.GetEmployeeType();
        //        employee.GetEmployeeData();
        //    }
        //}
        //public static void ProccessEmployee(FullTimeEmployee employee)
        //{
        //    if (employee is not null)
        //    {
        //        employee.GetEmployeeType();
        //        employee.GetEmployeeData();
        //    }
        //}

        #endregion

        static void Main()
        {
            // RelationShip Between Classes
            // PolyMorphism [OverLoading]
            // Polymorphism [OverRiding]
            // Binding

            #region 1- Association - Inheritance

            /** Not All The Realtion Between Classes is Inheritance
             * The Full Time Employee is a Employee [Inheritance] 
             * The Room Has Chairs [ Association - Aggregation ] if there are no charis still there a room [Partial]
             * The Room Has Walls [ Association - Composition ] if there are no walls so no Room [Mendatory]
             * The Order Has An item [ Association - Composition ] if there are no item no order [Mendatory]
             */

            #endregion

            #region 2- PolyMorphism - OverLoading

            /** What is the meaning of polymorphism
             * poly = Many
             * morphism = forms
             * so its mean many types of something
             */

            /** Types Of OverLoading
             * 1- Functions(Methods) overloading
             * 2- Constructor OverLoading 
             * 3- Indexer Overloading
             * 
             * You can make every one of them called by three things [Type, Numbers, order] of parameters
             * 
             * If You Change The Parameters and don't change the logic this is still repeatation
             * 
             * Load More on the same function
             * 
             * The OverLoading with the Methods is just for readablility
             * like the console.WriteLine(); You already has 18 types from it
             * 
             */

            /** Overriding
             * When You inherit methods from another calss and want to change the behavior of it
             */

            //Console.WriteLine(Sum(1,4));
            //Console.WriteLine(Sum(1,2,3));
            //Console.WriteLine(Sum("Muhamed Hajajii",5,4));
            //Console.WriteLine(Sum(1, "Muhamed Hajajii", 4));


            #endregion

            #region 3- PolyMorphism - overriding

            /** While there is inheritance only [Only with class]
             * Overriding with Relationship ==> Inheritance 
             * You Inherit functions from other class and want to change it behavior as long as the parent class allow the override 
             * if not allow the override you still can override it but in binding you will still cannot lets know why
             */

            // In This case nothing will change even i use the new or the override and virtual
            // The Reference refer to the object so it can see all the data on it 
            //TypeA typeA = new TypeA(1);
            //typeA.A = 10;
            //typeA.MyFun01();
            //typeA.MyFun02();

            //Console.WriteLine("======================");

            //TypeB typeB = new TypeB(10,20);
            //typeB.A = 10;
            //typeB.B = 10;
            //typeB.MyFun01();
            //typeB.MyFun02();




            #endregion

            #region 4- Binding

            /** When You make a reference from parent refer to object from the child Datatype
             * TypeA is the base and Type B is the child 
             */

            //TypeA refBase = new TypeA(1);
            //TypeA refBase;
            //// Declare for a reference from typeA can refer for an object from typeA and any object inherit from TypeA
            //refBase = new TypeB(1, 2);
            //// This Is Binding
            //// its not refer to the whole object of the TypeB its only refer to the parent data

            //refBase.A = 1;
            ////refBase.B = 1; // invalid -- bacause its own by the child not the parent reference
            //refBase.MyFun01();
            //refBase.MyFun02();
            // Both of the Parent
            // with the new you call the parent method
            // with override you call the object method

            /** ONLY WHEN THERE ARE A BINDING - Reference from the parent refer for a object from the child
             * 
             * with NEW --> Static Bounded -- static bounded method -- Early binding -- compliation Time 
             * -- static binding works during the compile time -- Bind The function call based on the referecne type
             * woth override --> dynamic bounded , dynamic bounded method -- late binding , runtime , clr will make it 
             * -- Clr will bind the function call based on the object type not the reference type
             */


            #endregion

            #region 5- Not Binding

            // thats not binding its just explicit casting -- unsafe casting
            //TypeB ChildRed = (TypeB) new TypeA(1);
            // casting operator 

            //TypeA typeA = new TypeA(1);

            //TypeB typeB = (TypeB) typeA;

            //Console.WriteLine(typeB.A);
            //Console.WriteLine(typeB.B);
            // Invalid Casting Exception
            // this casting operator you didn't implement it yet 

            //TypeA typeA = new TypeB(1,2);

            //TypeB typeB = (TypeB) typeA;

            //Console.WriteLine(typeB.A);
            //Console.WriteLine(typeB.B);
            // Valid Because its a child will hold the parent and the child data
            // its not casting because i transfare from data type to the same datatype 
            // otherwise go implement the casting operator


            #endregion

            #region Ex01

            //FullTimeEmployee fullTimeEmployee = new FullTimeEmployee(); // its not binding
            //fullTimeEmployee.GetEmployeeData();
            //fullTimeEmployee.GetEmployeeType();
            // Will Fire from the parent

            // No binding
            //FullTimeEmployee employee = new FullTimeEmployee(10,"Muhamed Hajajii",30,6000) { };
            //ProccessEmployee(employee);

            //PartTimeEmployee partEmp = new PartTimeEmployee()
            //{
            //    ID = 1,
            //    Name = "Muhamed Hajiii",
            //    Age = 25,
            //    HourRate = 25,
            //    CountOfHours = 25
            //};

            //ProccessEmployee(partEmp);

            #endregion

            #region Ex02



            #endregion

        }
    }
}
