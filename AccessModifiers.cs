using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPrepration
{
    internal class AccessModifiers
    {
       // public static void Main(string[] args)
       // {
           //Person p1 = new Person();
        //    p1.f1();
          //    p1.f2();
        //    p1.f3();
        //    Student s1 = new Student();
        //    s1.AccessProtectedofParent();
          // p1.f4();
          // p1.f5();
           
            
           //Console.ReadLine();
       // }
    }
     class Person
    {
        //Public Method
        public void f1()
        {
            Console.WriteLine("Public method f1() is Running");
            
        }
        
        //Private Method
        private void f2()
        {
            Console.WriteLine("Public method f2() is Running");
        }

        //Protected Method
        protected void f3()
        {
            Console.WriteLine("Protected method f3() is Running");
        }

        //Internal Method
        internal void f4()
        {
            Console.WriteLine("Internal method f4() is Running");
        }

        //Protected Internal 
        protected internal void f5()
        {
            Console.WriteLine("Protected internal method f5() is Running");
        }
        //Private Protected

        private protected void f6()
        {
            Console.WriteLine("Private Protected  method f6() is Running");
        }
    }
    class Student : Person
    {
        public void AccessProtectedofParent()
        {
            f3();
            f6();
            
        }

    }
}
