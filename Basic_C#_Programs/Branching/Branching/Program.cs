using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Masses of evil monsters surround you.  You see three objects in front of you.\nAn axe, a sword, and a pen.  Which do you choose?");
            Console.WriteLine("Press 1 for the Axe, 2 for the sword, and 3 for the pen.");
            int userChoice = Convert.ToInt32(Console.ReadLine());
            switch (userChoice)
            {
                case 1:
                    Console.WriteLine("You chose the axe.  The hordes of evil will stand little chance against you.");
                    break;
                case 2:
                    Console.WriteLine("You chose the sword. Balanced and sturdy, you will have little trouble\nsurviving against the evil mobs.");
                    break;
                case 3:
                    Console.WriteLine("The pen?  You chose the pen?  Ugh...the evil monster instantly jump and devour you.\nBut the world isn't too sad because you chose the pen and obviously had it coming.");
                    break;
            }
            Console.ReadLine();


            //Console.WriteLine("What is your favorite number?");
            //int favNum = Convert.ToInt32(Console.ReadLine());

            //string result = favNum == 12 ? "You have an awesome favorite number." : "You do not have an awesome favorite number.";

            //Console.WriteLine(result);
            
            //int roomTemperature = 70;

            //Console.WriteLine("Hi, what is your name?");
            //string name = Console.ReadLine();

            //Console.WriteLine("Hi, " + name + ", what is the temperature where you are?");
            //int currentTemperature = Convert.ToInt32(Console.ReadLine());

            //if (currentTemperature == roomTemperature)
            //{
            //    Console.WriteLine("It is exactly room temperature.");
            //}
            //else if (currentTemperature > roomTemperature)
            //{
            //    Console.WriteLine("It is warmer than room temperature.");
            //}
            //else if (roomTemperature > currentTemperature)
            //{
            //    Console.WriteLine("It is colder than room temperature.");
            //}
            //else
            //{
            //    Console.WriteLine("Uhhh.....something went wrong.");
            //}
            //Console.ReadLine();


            //int currentTemperature = 80;
            //int roomTermperature = 70;

            //string comaprisonResult = currentTemperature == roomTermperature ? "It is room temp." : "It is not room temp.";
            //Console.ReadLine();

            //if (currentTemperature == roomTermperature)
            //{
            //    Console.WriteLine("It is exactly room temperature.");
            //}
            //else if (currentTemperature > roomTermperature)
            //{
            //    Console.WriteLine("It is warmer than room temperature.");
            //}
            //else if (roomTermperature > currentTemperature)
            //{
            //    Console.WriteLine("Room temperature is warmer than current temperature.");
            //}
            //else
            //{
            //    Console.WriteLine("It is not exactly room temperature.");
            //}
            Console.ReadLine();
        }
    }
}
