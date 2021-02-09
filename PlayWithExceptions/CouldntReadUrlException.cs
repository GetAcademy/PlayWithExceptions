using System;
using System.Collections.Generic;
using System.Text;

namespace PlayWithExceptions
{
    class CouldntReadUrlException : ApplicationException
    {
        public string Url { get; }

        public CouldntReadUrlException(string url)
        {
            Url = url;
        }
    }
}
