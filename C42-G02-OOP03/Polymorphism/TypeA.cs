using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G02_OOP03.Polymorphism
{
    internal class TypeA
    {
        // Automatic Property
        // the compiler will generate a private hidden attribute [Baking Field]
        public int A { get; set; }

        public TypeA(int a)
        {
            A = a;
        }

        // object member fucntion // non static function call it from the object

        public void MyFun01()
        {
            Console.WriteLine("I'm base I'm Parent");
        }

        public virtual void MyFun02()
        {
            Console.WriteLine($"TypeA : A = {A}");
        }

    }
}
