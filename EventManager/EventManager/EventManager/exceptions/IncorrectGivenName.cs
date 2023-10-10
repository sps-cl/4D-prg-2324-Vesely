﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManager.exception
{
    public class IncorrectGivenNameException : Exception
    {
        public IncorrectGivenNameException(string message = "Incorrect given name") : base(message)
        {
        }
    }
}
