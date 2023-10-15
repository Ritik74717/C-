using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPrepration
{
    internal class ExceptionHandling
    {
       /* public static void Main()
        {
            Calcultor c1 = new Calcultor();
            c1.Division();
            Console.ReadLine();
        }*/
    }
    public class Calcultor
    {
       public void Division()
        {
            Console.WriteLine("Enter Two Numbers");
            try
            {
              
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());
                int c = a / b;
                Console.WriteLine($"Result is {c}");
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine($"Divide by zero error {e.Message}");
            }
            catch (FormatException e)
            {
                Console.WriteLine("Format Exception " + e.Message);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Index out of range exception " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception " + e.Message);
            }
            finally
            {
                Console.WriteLine("Program End");
            }
        }
    }

    
}
