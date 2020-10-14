using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparisonOperatorsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program\nPerson 1\nHourly Rate?");
            string personOneRateString = Console.ReadLine();
            int personOneRate = Convert.ToInt32(personOneRateString);
            Console.WriteLine("Hours worked per week?");
            string personOneHoursString = Console.ReadLine();
            int personOneHours = Convert.ToInt32(personOneHoursString);
            int annualSalary1 = personOneRate * personOneHours * 52;

            Console.WriteLine("Person 2");
            string personTwoRateString = Console.ReadLine();
            int personTwoRate = Convert.ToInt32(personTwoRateString);
            Console.WriteLine("Hours worked per week?");
            string personTwoHoursString = Console.ReadLine();
            int personTwoHours = Convert.ToInt32(personTwoHoursString);
            int annualSalary2 = personTwoRate * personTwoHours * 52;

            Console.WriteLine("Annual salary of Person 1:");
            Console.WriteLine(annualSalary1);
            Console.WriteLine("Annual salary of Person 2:");
            Console.WriteLine(annualSalary2);

            bool salarycomparison = annualSalary1 > annualSalary2;
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.WriteLine(salarycomparison);
            Console.ReadLine();
        }
    }
}
