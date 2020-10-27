using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamdaFunctionsAssignment
{
    public struct Employee
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int Id { get; set; }

        public static Employee CreateEmployee(string firstName, string lastName, int Id)
        {
            Employee employee = new Employee
            {
                firstName = firstName,
                lastName = lastName,
                Id = Id
            };
            return employee;
        }
    }



}
