using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPrepration
{
    internal class GenericsExample
    {
       /* public static void Main()
        {
            Generics<int> g1 = new Generics<int>();
            g1.Data = 12;
            Generics<string> g2 = new Generics<string>();
            g2.Data = "ritik";
            g1.Details(5);
            Console.WriteLine(g1.Data);
            Console.WriteLine(g2.Data);
            Console.ReadLine();

        }*/
    }

    public class Generics<T>
    {
        private T data;
        public T Data
        {
            get
            {
                return data;
            }
            set
            {
                data = value;
            }
        }

        public void  Details (T args)
        {
            Console.WriteLine("Details are {0}", args);
            
        }

    }
}
