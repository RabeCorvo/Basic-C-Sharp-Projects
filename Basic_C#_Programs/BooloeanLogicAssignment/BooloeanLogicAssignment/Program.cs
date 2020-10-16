using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooloeanLogicAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            string userAgeStr = Console.ReadLine();
            int userAgeInt = Convert.ToInt32(userAgeStr);

            Console.WriteLine("Have you ever had a DUI? Please enter 'true' or 'false'.");
            string userDUIStr = Console.ReadLine();
            bool userDUIBool = Convert.ToBoolean(userDUIStr);

            Console.WriteLine("How many speeding tickets do you have?");
            string userTicketStr = Console.ReadLine();
            int userTicketInt = Convert.ToInt32(userTicketStr);

            Console.WriteLine("Qualified?");
            Console.WriteLine(userAgeInt > 15 && userDUIBool == false && userTicketInt < 3);

            Console.ReadLine();
                

        }
    }
}
