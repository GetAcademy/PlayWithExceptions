using System;
using System.Collections.Generic;
using System.Text;

namespace PlayWithExceptions
{
    class UnknownApplicationException : ApplicationException
    {
        public UnknownApplicationException(Exception innerException)
        : base(innerException.Message, innerException)
        {

        }
    }
}
