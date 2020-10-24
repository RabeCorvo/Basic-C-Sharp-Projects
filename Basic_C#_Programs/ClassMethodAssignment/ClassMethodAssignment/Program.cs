using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 class1 = new Class1();
            Console.WriteLine("Please enter a whole number.");
            int userNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(userNumber + " plus 35 totals " + Class1.Addition(userNumber));
            Console.WriteLine(userNumber + " multiplied by 15 totals " + Class1.Multiplication(userNumber));
            Console.WriteLine(userNumber + " minus 2 totals " + Class1.Subtraction(userNumber));

            Console.ReadLine();

        }
    }
}
