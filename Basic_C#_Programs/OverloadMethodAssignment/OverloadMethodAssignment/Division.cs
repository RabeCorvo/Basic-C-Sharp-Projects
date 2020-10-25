using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadMethodAssignment
{
    public class Division
    {
        public static void DivideByTwo(int number, out int output)
        {
            output = number / 2;
        }
        public static int DivideByTwo(int number1, int neverUsed)
        {
            int dividend = (number1 + number2) / 2;
            return dividend;
        }

    }
}
