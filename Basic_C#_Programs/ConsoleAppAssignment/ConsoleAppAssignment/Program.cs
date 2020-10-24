using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] stringArray = { "The world loves", "Dinosaurs predominately ate", "Missiles bounce off of", "Look inside and you will find"};

            //Part 1:
            Console.WriteLine("Please enter your name.");
            string userName = Console.ReadLine();

            for (int i = 0; i < stringArray.Length; i++)
            {
                Console.WriteLine(stringArray[i] + " " + userName + ".");
            }


            //Part 2:
            //for (int i = 6; i > stringArray.Length; i++)
            //fixed:
            for (int i = 0; i < stringArray.Length; i++)
            {
                Console.WriteLine(userName + " is INFINITE!!");
            }


            //Part 3:
            for (int i = 0; i < stringArray.Length; i++)
            {
                Console.WriteLine(stringArray[i] + " tasty nuggets.");
            }
            //did not work!
            //for (int i = 0; i <= stringArray.Length; i++)
            //{
            //    Console.WriteLine(stringArray[i] + " tasty nuggets.");
            //}


            //Part 4:
            List<string> colors = new List<string>() { "red", "yellow", "green", "blue", "purple" };
            Console.WriteLine("Search for a color. Type a color in lowercase to see if it is in the list.");
            string colorName = Console.ReadLine();

            for (int i = 0; i < colors.Count; i++)
            {
                if (colors[i] == colorName)
                {
                    Console.WriteLine("Match found at Index " + i);
                    break;
                }
            }
            if (!colors.Contains(colorName))
            {
                Console.WriteLine("This is not in the list.");
            }


            //Part 5:
            List<string> luckyTokens = new List<string>() { "four leaf clover", "horseshoe", "penny", "two dollar bill", "horseshoe", "penny" };
            Console.WriteLine("Lucky token list.  Look for your lucky token of choice in our list.");
            string tokenName = Console.ReadLine();

            for (int i = 0; i < luckyTokens.Count; i++)
            {
                if (luckyTokens[i] == tokenName)
                {
                    Console.WriteLine("Match found at " + i);
                }
            }
            if (!luckyTokens.Contains(tokenName))
            {
                Console.WriteLine("This token is not in the list.");
            }


            //Part 6:
            List<string> petList = new List<string>() { "dog", "cat", "bird", "dog", "lizard", "fish" };
            List<string> uniqueList = new List<string>();

            for (int i = 0; i < petList.Count(); i++)
            {
                foreach (string element in uniqueList)
                {
                    if (petList[i] == element)
                    {
                        Console.WriteLine(element + " has appeared before.");
                    }
                }
                uniqueList.Add(petList[i]);
            }
            Console.ReadLine();
        }
    }
}
