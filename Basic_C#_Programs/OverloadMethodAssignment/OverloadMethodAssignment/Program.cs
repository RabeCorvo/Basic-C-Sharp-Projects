using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int answer = 0;
            Division division = new Division();
            Console.WriteLine("Please enter a whole number.");
            int userNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Division.DivideByTwo(userNumber, answer));   
            Console.ReadLine();
        }
    }
}
