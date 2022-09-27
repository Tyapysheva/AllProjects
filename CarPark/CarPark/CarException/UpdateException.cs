using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPark.CarException
{
    public class UpdateException : Exception
    {
        public UpdateException(string message) : base(message)
        {
            this.Message = message;
        }
        public string Message { get; }
    }
}
