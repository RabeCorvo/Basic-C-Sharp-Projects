using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a whole number.");
            String yourFirstNumber = Console.ReadLine();
            int firstNumber = Convert.ToInt32(yourFirstNumber);
            int product = firstNumber * 50;
            Console.WriteLine(yourFirstNumber + " multiplied by 50 is " + product);

            Console.WriteLine("Please enter another whole number.");
            String yourSecondNumber = Console.ReadLine();
            int secondNumber = Convert.ToInt32(yourSecondNumber);
            int sum = secondNumber + 25;
            Console.WriteLine(yourSecondNumber + " plus 25 is " + sum);

            Console.WriteLine("Please enter a third whole number.");
            String yourThirdNumber = Console.ReadLine();
            int thirdNumber = Convert.ToInt32(yourThirdNumber);
            double quotient = thirdNumber / 12.5;
            Console.WriteLine(yourThirdNumber + " divided by 12.5 is " + quotient);

            Console.WriteLine("Please enter a fourth whole number.");
            String yourFourthNumber = Console.ReadLine();
            int fourthNumber = Convert.ToInt32(yourFourthNumber);
            bool comparison = fourthNumber > 50;
            Console.WriteLine("Is " + yourFourthNumber + " greater than 50? " + comparison + "!");

            Console.WriteLine("Please enter a final whole number.");
            String yourFinalNumber = Console.ReadLine();
            int finalNumber = Convert.ToInt32(yourFinalNumber);
            int remainder = finalNumber % 7;
            Console.WriteLine(yourFinalNumber + " divided by 7 has a remainder of " + remainder);
            Console.ReadLine();
        }
    }
}
