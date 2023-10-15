/* 
Properties in C#

Properties in C# provide a flexible mechanism to handle private fields. 
They are named members of classes, structures etc. 
Properties use accessors to read, write or manipulate the values of private fields.

Properties behave like fields when they're accessed. 
However, unlike fields, properties are implemented with accessors that 
define the statements executed when a property is accessed or assigned.

Some of the salient points on properties are given as follows:

1. Properties allow a public way of getting and setting values in a class. 
2. The implementation and verification code is hidden.
3. The get and set accessors are used in properties. 
4. The get accessor returns the property value while a set accessor sets a new value.
5. Some properties have both get and set accessor(read-write).
6. Some have only a get accessor (read only) while some have only a set accessor (write only).
7. The value that is assigned by the set assessor is defined using the value keyword.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ExamPrepration
{
    internal class Properties
    {
       /* public static void Main()
        {
            PropertiesExample p1 = new PropertiesExample();
            p1.Name = "Ritik";
            p1.Age = 12;
            p1.Course = "mca";
            Console.WriteLine("Name is : {0} AND Age is : {1} AND Course is {2}", p1.Name, p1.Age,p1.Course);
            Console.ReadLine();
        }*/
    }

    public class PropertiesExample
    {
        private string name;
        private int age;
        private string course;

        //Property
        public int Age
        {
            get { return age; }
            set { age = value; }
        } 

        public string Name
        {
            get { return name; }
            set { name = value; }
        }


        /* The syntax shown is the auto property syntax. 
       * The compiler generates the storage location for the field that backs up the property. 
       * The compiler also implements the body of the get and set accessors.*/
        public string Course
        { 
            get;
            set;
        }
       

    }
}
