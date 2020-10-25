using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParameterMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Math math = new Math();
            int thirdNumber = 0;
            Console.WriteLine("Please enter a whole number.");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("If you would like to enter a second whole number, please do so. Otherwise press 'Enter'.");
            string secondNumber = Console.ReadLine();
            if (string.IsNullOrEmpty(secondNumber))
            {
                thirdNumber = 0;
            }
            else
            {
                thirdNumber = Convert.ToInt32(secondNumber);
            }
            Console.WriteLine("After mathing your numbers I have arrived at " + Math.Mathalicious(firstNumber, thirdNumber) + " as your final solution.");
            Console.ReadLine();
        }        
    }
}
