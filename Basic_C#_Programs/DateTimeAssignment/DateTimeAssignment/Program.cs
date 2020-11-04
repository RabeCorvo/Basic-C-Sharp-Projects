using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime currentDateTime = DateTime.Now;
            Console.WriteLine(currentDateTime);
            try
            {
                Console.WriteLine("Please enter a number.");
                double userNumber = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine(currentDateTime.AddHours(userNumber));
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Format error.");
            }



            Console.ReadLine();
        }
    }
}
