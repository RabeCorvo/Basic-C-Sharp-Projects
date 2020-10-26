using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAssignment
{
    class Employee<T>
    {
        public List<T> Things { get; set; }

    }
}
