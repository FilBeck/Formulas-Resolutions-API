using System;

namespace Formulas.Core.Exceptions
{
    public class InvalidInputException : Exception
    {
        public string[] Variables { get; set; }

        public InvalidInputException(string message) : base(message)
        {
        }

        public InvalidInputException(string[] variables, string message = "") : base(message)
        {
            Variables = variables;
        }
    }
}
