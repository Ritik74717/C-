using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ExamPrepration
{
    internal class ThreadExampleThree
    {
        public static int sharedVariable=0;
        public static object locker = new object();
        public static void Main()
        {
            Thread t1 = new Thread(Increment);
            Thread t2 = new Thread(Increment);
            t1.Start();
            t2.Start();
            t1.Join();
            t2.Join();
            Console.WriteLine("Final Value of Shared Variable is :" + sharedVariable);
            Console.ReadLine();
        }
        public static void Increment()
        {
           
            for(int i= 0; i < 5; i++)
            {
                Console.WriteLine($"Executing Thread {Thread.CurrentThread.ManagedThreadId} and status is {Thread.CurrentThread.ThreadState}");
                lock (locker)
                {
                    sharedVariable++;
                    Thread.Sleep(1000);
                    int temp = sharedVariable;
                    Thread.Sleep(1000);
                    Console.WriteLine($"Value changed by {Thread.CurrentThread.ManagedThreadId} and new value is {temp}");
                }


            }

        }
    }
}
