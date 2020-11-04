using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LoggingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter a whole number.");
                int userNumber = Convert.ToInt32(Console.ReadLine());
                using (StreamWriter file = new StreamWriter(@"C:\Users\ywing\Desktop\log.txt", true))
                {
                    file.WriteLine(userNumber);
                }
                Console.WriteLine("Your number has been logged.");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("A whole number was not entered. No log has been created.");
            }
            Console.WriteLine("List of logged numbers:");
            string logFile = File.ReadAllText(@"C:\Users\ywing\Desktop\log.txt");
            Console.WriteLine(logFile);
            Console.ReadLine();
        }
    }
}
