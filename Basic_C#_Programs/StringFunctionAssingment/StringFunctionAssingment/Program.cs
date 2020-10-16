using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctionAssingment
{
    class Program
    {
        static void Main(string[] args)
        {
            string string1 = "Down by the bay,";
            string string2 = " \nwhere the watermelons grow!";
            string string3 = " \nBack to my home, I dare not go!";

            Console.WriteLine(string1 + string2 + string3);

            string string4 = "\nFor if I do, my mother would say:";
            string string5 = "\nhave you ever seen a bear combing its hair down by the bay?!";

            Console.WriteLine(string4 + string5.ToUpper());

            string string6 = "\nhave you ever seen a whale with a polka dot tail down by the bay?!";
            string[] stringArray = { string1, string2, string3, string4, string6.ToUpper()};
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < stringArray.Length; i++)
            {
                sb.Append(stringArray[i]).Append("");
            }
            Console.WriteLine(sb);

            Console.ReadLine();
        }
    }
}
