using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPrepration
{
    internal class Indexers
    {
       /* public static void Main()
        {
            Indexer1 i1 = new Indexer1();
            i1[0] = 1;
            i1[1] = 2;
            i1[2] = 3;
            i1[3] = 4;
            i1[4] = 5;
            Console.WriteLine(i1);
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine(i1[i]);
            }

            IndexerTwo i2 = new IndexerTwo();
            i2[1] = 1;
            i2[2] = "Ritik Kaushik";
            Console.WriteLine(i2[1]);
            Console.WriteLine(i2[2]);

            IndexerThree i3 = new IndexerThree();
            i3["id"] = 2;
            i3["name"] = "Parag";
            Console.WriteLine(i3["id"]);
            Console.WriteLine(i3["name"]);

            IndexerFour i4 = new IndexerFour();
            i4[0, 0] = 1;
            i4[0, 1] = 2;
            i4[1, 0] = 3;
            i4[1, 1] = 4;
            Console.WriteLine(i4[0, 0]);
            Console.WriteLine(i4[0, 1]);
            Console.WriteLine(i4[1, 0]);
            Console.WriteLine(i4[1, 1]);

            Console.ReadLine();
        }*/
    }
    public class Indexer1
    {
        private int[] arr = new int[5];
        public int this[int i]
        {
            get {return arr[i];}
            set { arr[i] = value;}
        }
    }

    public class IndexerTwo
    {
        private int id;
        private string name;

        public object this[int index]
        {
            get
            {
                if (index == 1) 
                {
                    return id; 
                }
                else if (index == 2) 
                {
                    return name;
                }
                else
                {
                    return "Invalid index value please enter 1 for id and 2 for name";
                }

            }

            set
            {
                if (index == 1)
                {
                    id = (int)value;
                }
                else if(index == 2)
                {
                    name = value.ToString();
                }
                
            }
        }
    }

    public class IndexerThree
    {
        private int id;
        private string name;

        public object this[string index]
        {
            get
            {
                if (index == "id")
                {
                    return id;
                }
                else if(index== "name")
                {
                    return name;
                }
                else
                {
                    return "Invalid index";
                }
            }
            set
            {
                if (index == "id")
                {
                    id= (int)value;
                }
                else if (index == "name")
                {
                    name = value.ToString();  
                }
            }
        }
    }

    public class IndexerFour
    {
        private int[,] arr = new int[2,2];
        public int this[int index1, int index2]
        {
            get 
            { 
                return arr[index1,index2]; 
             }
            set 
            { 
                arr[index1,index2] = value;
            }
        }
    }
}
