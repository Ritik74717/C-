using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPrepration
{
    internal class Structures
    {
      /*  public static void Main()
        {
            StructureDemo s1 = new StructureDemo(5,4);
            s1.getValues();
            Console.ReadLine();
        }*/
    }

    struct StructureDemo
    {
        int x,y;
        public StructureDemo(int x,int y)
        {
            this.x = x;
            this.y = y;
        }
        public void getValues()
        {
            Console.WriteLine(" x = {0} y = {1}",x,y);
        }
  
    }
}
