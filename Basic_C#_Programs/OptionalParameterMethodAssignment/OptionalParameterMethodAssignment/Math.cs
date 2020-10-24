using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParameterMethodAssignment
{
    class Math
    {
        public static int Mathalicious(int number1, int number2 = 0)
        {
            int answer = number1 * 365 + number2;
            return answer;
        }
    }
}
