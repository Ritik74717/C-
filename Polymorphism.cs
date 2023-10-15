using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPrepration
{
    internal class Polymorphism
    {
        /*
        public static void Main()
        {
            Sum s1 = new Sum();
            s1.add(4, 5);
            s1.add(2, 3, 5);
            s1.add(3.78, 6.5, 8.9);
            SumTwo s2 = new SumTwo();
            s2.add(2, 3, 4);
            MethodHidding m1= new MethodHidding();
            m1.product(2, 3);
            Console.ReadLine();
        }*/
    }

    //PolyMorphism -> 1- Runtimme , 2- Compile Time

    //Compile Time -> Method overloading

    public class Sum
    {
        public void add(int a,int b)
        {
            Console.WriteLine("Sum is " +( a + b));
        }
        public virtual void add(int a, int b, int c)
        {
            Console.WriteLine("Sum is " + (a + b + c));
        }

        public void add(double a, double b, double c)
        {
            Console.WriteLine("Sum is " + (a + b + c));
        }

        public void product(int a, int b)
        {
            Console.WriteLine(a * b);
        }
    }

    //Runtime -> Method overriding
    public class SumTwo :Sum
    {
        public override void add(int a, int b, int c)
        {
            Console.WriteLine("Sum is " + (a + b + c)*2);
        }
    }

    //Method Hidding
    public class MethodHidding : Sum
    {
        public new void product(int a, int b)
        {
            base.product(a, b);//calling parent method from child class
            Console.WriteLine("Product of {0} and {1} is {2}", a, b, a * b);
        }
    }
}
