using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamdaFunctionsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employeeList = new List<Employee>()
            {
                Employee.CreateEmployee("Joe", "North Dakota", 1),
                Employee.CreateEmployee("Sarah", "Harding", 2),
                Employee.CreateEmployee("Alan", "Grant", 3),
                Employee.CreateEmployee("Ian", "Malcom", 4),
                Employee.CreateEmployee("Robert", "Muldoon", 5),
                Employee.CreateEmployee("Nick", "Van Owen", 6),
                Employee.CreateEmployee("Owen", "Grady", 7),
                Employee.CreateEmployee("Ellie", "Sattler", 8),
                Employee.CreateEmployee("Clair", "Dearing", 9),
                Employee.CreateEmployee("Joe", "Wyoming", 10)
        };

            List<Employee> joeList = new List<Employee>();
            foreach (Employee employee in employeeList)
            {
                if (employee.firstName == "Joe")
                {
                    joeList.Add(employee);
                }
            }
            foreach (Employee joe in joeList)
            {
                Console.WriteLine(joe.firstName + " " + joe.lastName);
            }

            List<Employee> idList = employeeList.Where(x => x.Id > 5).ToList();
            foreach (Employee person in idList)
            {
                Console.WriteLine(person.firstName + " " + person.lastName);
            }


            Console.ReadLine();
        }
    }
}
