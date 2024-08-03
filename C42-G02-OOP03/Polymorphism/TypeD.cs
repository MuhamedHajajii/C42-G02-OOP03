using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G02_OOP03.Polymorphism
{
    // Direct Parent TypeC and ind direct Parent Hierarchy like TypeA : TypeB 
    internal class TypeD : TypeC
    {
        public int D { get; set; }

        public TypeD(int a , int b , int c ,int d) :base(a, b, c) 
        {
            D = d;
        }

        public new void MyFun01()
        {
            Console.WriteLine("I'm Child Grand Child");
        }

        // End for the sequence with the new 
        // virtual means we start a new sequence
        public new virtual  void MyFun02()
        {
            Console.WriteLine($"TypeD : A = {A} , B = {B} , C = {C} , D = {D}");
        }

    }
}
