using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                List<int> numberList = new List<int>() { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };
                Console.WriteLine("Pick a number to divide by.");
                int divideBy = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < numberList.Count; i++)
                {
                    Console.WriteLine(numberList[i] / divideBy);
                }
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("All calculations are complete.");
            Console.ReadLine();
        }
    }
}
