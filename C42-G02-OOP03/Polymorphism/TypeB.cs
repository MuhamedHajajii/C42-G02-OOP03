using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G02_OOP03.Polymorphism
{
    internal class TypeB : TypeA
    {
        public int B { get; set; }


        // When You Inherit so by defult the class will make constructor chaning with the parameterless constructor for the parent but if there are not so you must 
        // choose which constructor to call and choose it with the parameters number,type,order
        public TypeB(int b, int a) : base(a)
        {
            B = b;
        }

        // maskiog .. hide from the parent
        // The overriding done with two keywords
        // new and this make masking refer to the reference in the comilation time Early bonded method static bounded
        // virtual overriding refer to the object in the runtime lately bounded method dynamic bonded


        public new void MyFun01()
        {
            Console.WriteLine("I'm Child");
        }

        public override void MyFun02()
        {
            Console.WriteLine($"TypeB : A = {A} , B = {B}");
        }

    }
}
