using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTADailyReport
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy\nStudent Daily Report");
            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();
            Console.WriteLine("What course are you on?");
            string yourCourse = Console.ReadLine();
            Console.WriteLine("What page number?");
            string yourPageNumber = Console.ReadLine();
            int pageNumber = Convert.ToInt32(yourPageNumber);
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
            string yourHelpBool = Console.ReadLine();
            bool helpBool = Convert.ToBoolean(yourHelpBool);
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string yourExperiences = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you'd like to provide?  Please be specific.");
            string yourFeedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            string yourStudyHours = Console.ReadLine();
            int studyHours = Convert.ToInt32(yourStudyHours);
            Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly.\nHave a great day!");
            Console.ReadLine();

        }
    }
}
