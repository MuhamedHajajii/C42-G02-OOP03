using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G02_OOP03.Polymorphism
{
    // TypeC now has two pernent 
    // Direct Parent {TypeB}
    // indirect Parent {TypeA}
    internal class TypeC : TypeB
    {
        public int C { get; set; }

        public TypeC(int a, int b, int c): base(a,b)
        {
            C = c;
        }

        public new void MyFun01()
        {
            Console.WriteLine("I'm Grand Child");
        }

        public  override void MyFun02()
        {
            Console.WriteLine($"TypeC : A = {A} , B = {B} , C = {C}");
        }

    }
}
