using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPark.CarException
{
    public class GetTransportByParameterException : Exception
    {
        public GetTransportByParameterException(string message) : base(message)
        {
            this.Message = message;
        }
        public string Message { get; }
    }
}
