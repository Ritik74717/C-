using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ExamPrepration
{
    internal class ThreadingExampleTwo
    {
        static int threadCounterOne = 0;
        static int threadCounterTwo = 0;
        static int threadCounterThree= 0;
       /* public static void Main()
        {
            Thread t1 = new Thread(ExecuteThreadOne);
            Thread t2 = new Thread(ExecuteThreadTwo);
            Thread t3 = new Thread(ExecuteThreadThree);
            t1.Priority = ThreadPriority.Highest;
            t2.Priority = ThreadPriority.Normal;
            t3.Priority = ThreadPriority.Lowest;

            t1.Start();
            t2.Start();
            t3.Start();

            Thread.Sleep(1000);
            t1.Abort();
            t2.Abort();
            t3.Abort();

            Console.WriteLine("ThreadOne "+threadCounterOne/1000);
            Console.WriteLine("ThreadTwo "+threadCounterTwo/1000);
            Console.WriteLine("ThreadThree "+threadCounterThree / 1000);
            Console.ReadLine();

        }*/

        public static void ExecuteThreadOne()
        {
            while (true)
            {
                threadCounterOne++;
            }
        }

        public static void ExecuteThreadTwo()
        {
            while (true)
            {
                threadCounterTwo++;
            }
        }

       public static void ExecuteThreadThree()
        {
            while (true)
            {
                threadCounterThree++;
            }
        }

    }
}
