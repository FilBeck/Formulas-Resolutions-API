using Formulas.Core.Resolutions;
using Formulas.Core.Validations;
using System.Collections.Generic;

namespace Formulas.Core.Entities
{
    public class Result
    {
        public List<string> Answers { get; set; }
        public List<Resolution> Resolutions { get; set; }
        public string Message { get; set; }

        public Result()
        {
            Answers = new List<string>();
            Resolutions = new List<Resolution>();
        }

        public void Validate()
        {
            var resultValidator = new ResultValidation(Answers);
            Answers = resultValidator.AnswerList;
        }
    }
}
