using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace InfoAuto
{
    public class ContainsException : Exception
    {
        public ContainsException()
        {
        }

        public ContainsException(string? message) : base(message)
        {
        }

        public ContainsException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected ContainsException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }

}
