using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace DepotEice.Shared.Exceptions
{
    public class DateTimeOutOfRangeException : Exception
    {
        public DateTimeOutOfRangeException()
        {
        }

        public DateTimeOutOfRangeException(string message) : base(message)
        {
        }

        public DateTimeOutOfRangeException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        protected DateTimeOutOfRangeException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}
