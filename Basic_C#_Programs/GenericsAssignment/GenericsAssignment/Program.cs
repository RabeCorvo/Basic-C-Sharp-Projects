using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> employeeStr = new Employee<string>();
            employeeStr.Things = new List<string>() { "Head", "Shoulders", "Knees", "Toes" };
            Employee<int> employeeInt = new Employee<int>();
            employeeInt.Things = new List<int>() { 1, 1, 7, 13, 21 };
            
            foreach (string thing in employeeStr.Things)
            {
                Console.WriteLine(thing);
            }
            foreach (int thing in employeeInt.Things)
            {
                Console.WriteLine(thing);
            }
            Console.ReadLine();
            
        }
    }
}
