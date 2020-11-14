using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFinalProject
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var schoolContext = new SchoolContext())
            {
                var student = new Student() { FirstName = "Sam", LastName = "Breidenbach" };

                schoolContext.Students.Add(student);
                schoolContext.SaveChanges();                
            }
        }
    }
}
