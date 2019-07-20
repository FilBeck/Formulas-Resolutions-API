using System.Collections.Generic;
using System.Linq;

namespace Formulas.Core.Validations
{
    public class ResultValidation
    {
        public List<string> AnswerList { get; set; }

        public ResultValidation(List<string> answerList)
        {
            AnswerList = answerList;
            ValidateResult();
        }

        public void ValidateResult()
        {
            RemoveRepeatedResults();
        }

        private void RemoveRepeatedResults()
        {
            AnswerList = AnswerList.Distinct().ToList();
        }
    }
}
