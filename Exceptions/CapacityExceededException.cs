using System;

namespace Curs11T.Exceptions
{
    public class CapacityExceededException : Exception
    {
        public CapacityExceededException(string message) : base(message) { }
    }
}