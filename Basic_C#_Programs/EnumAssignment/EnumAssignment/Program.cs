using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Days days = new Days();
            Console.WriteLine("Please enter the current day of the week.");
            string userDay = Console.ReadLine();
            try
            {
                Enum.Parse(typeof(Days.DaysOfTheWeek), userDay);
            }
            catch
            {
                Console.WriteLine("Please enter an ACTUAL day of the week.");
            }
            Console.ReadLine();
        }
    }
}
