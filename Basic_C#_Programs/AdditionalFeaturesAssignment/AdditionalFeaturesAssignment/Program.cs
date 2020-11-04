using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalFeaturesAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            const string name = "Sam Breidenbach";

            var numberList = new List<int>() { 12, 13, 14, 15, 16 };

            Console.WriteLine("My name is {0}.", name);
            Console.WriteLine(numberList[2]);

            Person person = new Person(name);
            Console.WriteLine(person.Age + ", " + person.Name);
            Console.ReadLine();
        }
    }
}
