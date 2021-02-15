using System;
using System.Runtime.Serialization;

namespace AlphaLocation.Customers.Domain.Exceptions
{
    [Serializable]
    internal class InvalidNameException : Exception
    {
        private const string ERROR_MESSAGE = "Name must not be empty";
        public InvalidNameException() : base(ERROR_MESSAGE)
        {
        }

        public InvalidNameException(string message) : base(ERROR_MESSAGE)
        {
        }

        public InvalidNameException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InvalidNameException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
