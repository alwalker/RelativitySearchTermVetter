using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RelativitySearchTermVetter.Business.Rules
{
    public class StarInQuotes : Rule
    {
        public override String ViolationDescription { get { return "Wildcard character inside quotations"; } }

        public override bool Validate(Term term)
        {
           var result = false;

            if (String.IsNullOrEmpty(term.RawText))
            {
                result = true;
            }
            else if(!Regex.Match(term.RawText, "\\\".*\\*.*\\\"").Success) {
                result = true;
            }

            return result;
        }
    }
}
