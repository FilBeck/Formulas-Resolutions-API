using System;

namespace Formulas.Core.Exceptions
{
    public class InvalidInputException : Exception
    {
        public string[] Variables { get; set; }

        public InvalidInputException(string message = "Input variables were not informed correctly") : base(message)
        { }

        public InvalidInputException(string[] variables, string message = "Input variables were not informed correctly") : base(message)
        {
            Variables = variables;
        }
    }
}
