using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileDoWhileAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The variable needs to be set to true to stop.");
            bool variable = true;
            while (variable)
            {
                Console.WriteLine("Type true or false to set the variable.");
                bool firstUserInput = Convert.ToBoolean(Console.ReadLine());
                if (firstUserInput == true)
                {
                    break;
                }
            }

            Console.WriteLine("Enter a capital letter G to win.");
            string secondUserInput = Console.ReadLine();
            bool letterG = false;

            do
            {
                switch (secondUserInput)
                {
                    case "G":
                        Console.WriteLine("You have entered a capital letter G.  You win.");
                        letterG = true;
                        break;
                    default:
                        Console.WriteLine("You did not enter a capital letter G.  Please try again.");
                        Console.WriteLine("Enter a capital letter G to win.");
                        secondUserInput = Console.ReadLine();
                        break;
                }
            }
            while (!letterG);
            Console.ReadLine();
        }
    }
}
