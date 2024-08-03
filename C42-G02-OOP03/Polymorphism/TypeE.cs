using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G02_OOP03.Polymorphism
{
    // Type E Direct Parent is Type D
    // And The Heirarchy of the rest types like
    // TypeA : TypeB : TypeC : TypeD
    internal class TypeE : TypeD

    {
        public int E { get; set; }

        public TypeE(int a , int b , int c , int d , int e): base(a,b,c,d)
        {
            E = e;
        }

        public new void MyFun01()
        {
            Console.WriteLine("I'm Child Grand Child Child");
        }

        // if you let it override using the new you will not can still override in the binding 
        // but to override you must inherit it with virtual
        // and you can not end the sequence without make it new 
        public override void MyFun02()
        {
            Console.WriteLine($"TypeE : A = {A} , B = {B} , C = {C} , D = {D} , E = {E}");
        }

    }
}
