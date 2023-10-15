using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPrepration
{
    internal class Classes
    {
       /* public static void Main(string[] args)
        {
            Human.gwtDetails();
            Sealed.gwtDetails();
            PartialClass.gwtDetails();
            Area a1 = new Area();
            a1.getArea();
            Console.ReadLine();
        }*/
    }

    // Static class
    public static class Human
    {
        private static string name = "ritik";
        private static int age = 12;
       public static void gwtDetails()
        {
            Console.WriteLine("Name :" + name);
            Console.WriteLine("Age :" + age);

        }
    }

    // Sealed class
    public sealed class Sealed
    {

        private static string name = "ritik";
        private static int age = 12;
        public static void gwtDetails()
        {
            Console.WriteLine("Name :" + name);
            Console.WriteLine("Age :" + age);

        }
    }

    //cannot inherit sealed class
    //public class SealedTwo : Sealed
    //{

    //}

    // Partial Class :- Use same name of classes in same namespaces and after compliation we can access both class functionality

    public partial class PartialClass
    {
        private static string name = "ritik";
        private static int age = 12;
        public static void gwtDetails()
        {
            Console.WriteLine("Name :" + name);
            Console.WriteLine("Age :" + age);

        }

    }

    //Abstract class :- cannot create object
    public abstract class Shape
    {
        public double PI = 3.14;
        public abstract void getArea();

    }
    public class Area : Shape
    {
        private int radius = 5;
        public override  void getArea()
        {
            Console.WriteLine("Area is :" + radius * radius * PI);
        }
    }


}
