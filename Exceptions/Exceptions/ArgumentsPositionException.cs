using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class ArgumentsPositionException : Exception
    {
        public ArgumentsPositionException(string message) : base(message)
        {
        }
    }
}
