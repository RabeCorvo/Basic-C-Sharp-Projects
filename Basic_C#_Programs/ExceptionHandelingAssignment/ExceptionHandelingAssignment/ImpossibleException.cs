﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandelingAssignment
{
    public class ImpossibleException : Exception
    {
        public ImpossibleException()
            : base() { }
        public ImpossibleException(string message)
            : base(message) { }
    }
}
