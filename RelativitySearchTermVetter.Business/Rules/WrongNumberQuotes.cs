using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelativitySearchTermVetter.Business.Rules
{
    public class WrongNumberQuotes : Rule
    {
        public override String ViolationDescription { get { return "Uneven Number of Quotes"; } }

        public override bool Validate(Term term)
        {
            if (String.IsNullOrEmpty(term.RawText) || term.RawText.Count(c => c == '"') % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
