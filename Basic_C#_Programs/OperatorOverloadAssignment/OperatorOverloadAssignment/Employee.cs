using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloadAssignment
{
    public class Employee : Person, IQuittable, IEquatable<Employee>
    {
        public int ID { get; set; }             //properties of class Employee

        public override void SayName()          //calling method from class Person through class Employee
        {
            base.SayName();
        }
        public void Quit()
        {
            Console.WriteLine(FirstName + " " + LastName + " has quit.");
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Employee);
        }

        public bool Equals(Employee other)
        {
            return other != null &&
                   ID == other.ID;
        }

        public override int GetHashCode()
        {
            return 1213502048 + ID.GetHashCode();
        }

        public static Workforce operator+ (Workforce workforce, Employee employee)  //overloaded operator to add employee to workforce
        {
            workforce.Employees.Add(employee);
            return workforce;
        }
        public static Workforce operator- (Workforce workforce, Employee employee)  //overloaded operator to remove employee from workforce
        {
            workforce.Employees.Remove(employee);
            return workforce;
        }
        public static Boolean operator== (Employee employee01, Employee employee02) //overloaded operator to compare employee ID's
        {
            if (employee01.ID == employee02.ID)                                     //uses longer IF-THAN-ELSE statement
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static Boolean operator !=(Employee employee01, Employee employee02) 
        {
            return employee01.ID != employee02.ID ? true : false;                   //uses simpler ternary statement to acheive the same as the above IF-THAN-ELSE
        }

    }
    
}
