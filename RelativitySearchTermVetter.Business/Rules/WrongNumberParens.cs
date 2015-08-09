using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelativitySearchTermVetter.Business.Rules
{
    public class WrongNumberParens : Rule
    {
        public override String GetViolationDescription(params String[] args)
        {
            return "Mismatched Parenthesis";
        }

        public override bool Validate(Term term)
        {
            var result = false;

            if (String.IsNullOrEmpty(term.RawText))
            {
                result = true;
            }
            else
            {
                var leftCount = term.RawText.Count(c => c == '(');
                var rightCount = term.RawText.Count(c => c == ')');
                if (leftCount == rightCount)
                {
                    result = true;
                }
            }

            return result;
        }
    }
}
