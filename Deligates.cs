using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPrepration
{
    delegate void DeligateDemo(int x, int y);
    internal class Deligates
    {
        static void Addition(int a,int b)
        {
            Console.WriteLine(a + b);
        }
        static void Subtraction(int a,int b)
        {
            if (b > a)
            {
                throw new ArgumentException("value of b must be greater than a");
            }
            else
            {
                Console.WriteLine(a - b);
            }
        }
       /* public static void Main()
        {
            DeligateDemo d1, d2, d3;
            d1 = Addition;
            d2 = Subtraction;
            d1(3, 5);
            d2(10, 5);
            d3 = d1;
            d3 =d3+ d2;
            d3(120, 90);
           Console.ReadLine();

        }*/
    }
}
