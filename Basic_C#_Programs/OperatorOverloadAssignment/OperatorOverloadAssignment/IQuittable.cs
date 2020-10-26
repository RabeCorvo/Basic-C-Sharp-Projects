using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloadAssignment
{
    interface IQuittable
    {
        void Quit();            //Requires that any inheriting class uses a Quit(), but allows the class itself
    }                           //to define how the method is used and what it does.
}
