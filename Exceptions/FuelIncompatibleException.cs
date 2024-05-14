using System;

namespace Curs11T.Exceptions
{
    public class FuelIncompatibleException : Exception
    {
        public FuelIncompatibleException(string message) : base(message) { }
    }
}