using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace ExamPrepration
{
    internal class MultiThreading
    {
       /* static void Main()
        {
           // Test1();
           // Test2();
            Thread th1 = new Thread(Test1);
            Thread th2 = new Thread(Test2);
            th1.Start();
            th2.Start();
            Console.WriteLine("Program End Pres Any Key to continue....");
            Console.ReadLine();

        }*/
        static void Test1()
        {
            Console.WriteLine("Thread 1 is Running");
            
            for(int i = 1; i <= 10; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine("Thread 1 Executed {0}", i);
            }
        }
        static void Test2()
        {
            Console.WriteLine("Thread 2 is Running");
           
            for (int i = 11; i <=20; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine("Thread 2 Executed {0}", i);
            }
        }
    }
}
