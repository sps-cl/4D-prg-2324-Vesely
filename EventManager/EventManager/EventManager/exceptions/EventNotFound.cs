using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManager.exception
{
    public class EventNotFoundException : Exception
    {
        public EventNotFoundException(string message = "Event not found") : base(message)
        {
        }
    }
}
