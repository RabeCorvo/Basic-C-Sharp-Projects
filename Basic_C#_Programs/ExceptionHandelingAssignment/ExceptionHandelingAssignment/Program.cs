using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandelingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime currentDateTime = DateTime.Now;    //Gets current date and time
            int currentYear = currentDateTime.Year;     //Gets the year info from current date and time and sets to currentYear variable
            try
            {
                Console.WriteLine("How old are you?");
                int userAge = Convert.ToInt32(Console.ReadLine());
                if (userAge <= 0)
                {
                    throw new ImpossibleException();
                }
                Console.WriteLine(currentYear - userAge);
                Console.ReadLine();
            }
            catch (ImpossibleException)
            {
                Console.WriteLine("You have entered a zero or a negative number.  Please enter a postive whole number.");
                Console.ReadLine();
                return;
            }
            catch (Exception)
            {
                Console.WriteLine("An error has occurred.");
                Console.ReadLine();
                return;
            }
        }
    }
}
