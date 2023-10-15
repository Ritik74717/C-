/*
* Enums in C# *
The enum keyword in C# declares a list of named integer constants. 
An enum can be defined in a namespace, structure or class. 
However, it is better to define it in a namespace so that all the classes can access it.

*Enum Syntax*
The syntax for an enum is given as follows:

enum NameOfEnum
{
   // The enumerator list
};
The keyword enum is used to create an enumeration with the name NameOfEnum.
Then the enumeration list is available within curly braces in the enum body. 
The value of the first identifier in the enumerator list is zero by default.
*/



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPrepration
{
    public enum Days
    {
        Monday =1, Tuesday =2, Wednesday =3, Thursday, Friday =4, Saturday =5,Sunday =6
    }

    [Flags]
    public enum DaysTwo
    {
        None = 0,
        Monday = 1,
        Tuesday = 2,
        Wednesday = 4,
        Thursday = 8,
        Friday = 16,
        Saturday = 32,
        Sunday = 64,
        Weekend = Saturday | Sunday
    }
    internal class Enums
    {
       /* public static void Main()
        {
            /*int d1 = (int)Days.Monday;
            int d2 = (int)Days.Tuesday;
            Console.WriteLine("{0} {1}",d1,Days.Monday);
            Console.WriteLine("{0} {1}",d2 , Days.Tuesday);

            foreach(Days d in Enum.GetValues(typeof(Days)))
            {
                Console.WriteLine("Day number {0} and Day is {1}", (int)d, d);
            }
            DaysTwo meetingDays = DaysTwo.Monday | DaysTwo.Friday | DaysTwo.Wednesday;
            Console.WriteLine("Meeting days are : {0}", meetingDays);

            DaysTwo workFromHome = DaysTwo.Friday | DaysTwo.Saturday;
            Console.WriteLine("Calling days are :{0}", meetingDays & workFromHome);

            bool isMeetingOnTuesday = (DaysTwo.Tuesday & meetingDays) == (DaysTwo.Tuesday);
            Console.WriteLine("Meeting on Tuesday {0}", isMeetingOnTuesday);

            var a = (DaysTwo)37;
            Console.WriteLine(a);
           


            Console.ReadLine();
        }*/
    }
}
