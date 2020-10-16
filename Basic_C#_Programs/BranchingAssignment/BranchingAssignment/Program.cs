using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express.  Please follow the instructions below.");
            Console.WriteLine("Please enter package weight.");
            int packageWeight = Convert.ToInt32(Console.ReadLine());
            if (packageWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express.  Have a GOOD day.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Please enter package width.");
                decimal packageWidth = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter package height.");
                decimal packageHeight = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter package length.");
                decimal packageLength = Convert.ToInt32(Console.ReadLine());
                if ((packageWidth + packageHeight + packageLength) > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.  Have a GREAT day.");
                    Console.ReadLine();
                }
                else
                {
                    decimal quote = (((packageWidth * packageHeight * packageLength) * packageWeight) / 100);
                    Console.WriteLine("The estimated total for shipping this package is: " + quote.ToString("C"));
                    Console.WriteLine("Will that be cash or credit?");
                    Console.ReadLine();
                }
            }
        }
    }
}
