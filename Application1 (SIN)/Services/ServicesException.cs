using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ServicesException : Exception
    {
        public ServicesException() : base() { }
        public ServicesException(string Message) : base(Message) { }
        public ServicesException(string Message, Exception e) : base(Message, e) { }
    }
}
