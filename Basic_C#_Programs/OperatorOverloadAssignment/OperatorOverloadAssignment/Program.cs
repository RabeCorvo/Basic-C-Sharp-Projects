using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloadAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Workforce workforce = new Workforce();                                                              //created a new workforce
            workforce.Employees = new List<Employee>();                                                         //created a new workforce list of employees

            Employee employee01 = new Employee() { FirstName = "Sample1", LastName = "Student1", ID = 01 };     //created a new employee
            employee01.SayName();                                                                               //stated its name
            workforce += employee01;                                                                            //added employee to workforce list of employees
            employee01.Quit();                                                                                  //this will run the Quit() on employee01

            Employee employee02 = new Employee() { FirstName = "Sample2", LastName = "Student2", ID = 01 };     //created a second new employee
            employee02.SayName();                                                                               //stated its name
            workforce += employee02;                                                                            //added employee to workforce list of employees

            if (employee01 == employee02)
            {
                Console.WriteLine("Employees have same ID information.");
            }
            else
            {
                Console.WriteLine("Employees do not have the same ID information");
            }


            Console.ReadLine();

        }
    }
}
