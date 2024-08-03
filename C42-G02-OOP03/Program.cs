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

        static void Main()
        {
            // RelationShip Between Classes
            // PolyMorphism [OverLoading]
            // Polymorphism [OverRiding]
            //

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
            TypeA typeA = new TypeA(1);
            typeA.A = 10;
            typeA.MyFun01();
            typeA.MyFun02();

            Console.WriteLine("======================");

            TypeB typeB = new TypeB(10,20);
            typeB.A = 10;
            typeB.B = 10;
            typeB.MyFun01();
            typeB.MyFun02();

            #endregion

        }
    }
}
