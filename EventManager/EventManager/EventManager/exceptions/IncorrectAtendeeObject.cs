using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManager.exception
{
    public class IncorrectAtendeeObjectException : Exception
    {
        public IncorrectAtendeeObjectException(string message = "Invalid Atendee type") : base(message)
        {
        }
    }
}
